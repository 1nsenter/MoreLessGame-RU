using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.Forms
{
    public partial class GuessForm : Form
    {
        GameInfo gameInfo;
        GameInfo playerGameInfo;

        private int attemp = 0;

        public GuessForm()
        {
            InitializeComponent();
            ResetGame();
        }

        private void ResetGame()
        {
            attemp = 0;
            InitializeGameInfo();
            InitializeEvents();
            UpdateUI();
        }

        private void InitializeGameInfo()
        {
            gameInfo = new GameInfo();
            playerGameInfo = new GameInfo();

            gameInfo.RandomizeWishedNumber();
        }

        private void InitializeEvents()
        {
            playerGameInfo.OnMinMaxChanged += UpdateUI;
        }

        private void UpdateUI()
        {
            GuessNumberLabel.Text = $"Введите число от {playerGameInfo.MinNumber} до {playerGameInfo.MaxNumber}.";
            GuessAttempsLabel.Text = "Количество попыток: " + attemp.ToString();

            if (attemp <= 0)
            {
                GuessAttempsLabel.Visible = false;
                GuessNumberTextBox.Text = string.Empty;
                MainTextBox.Text = $"Я загадал число от {gameInfo.MinNumber} до {gameInfo.MaxNumber}, " +
                    $"попробуй его угадать!";
            }
            else
            {
                GuessAttempsLabel.Visible = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private bool RestartGame()
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите перезапустить игру?", "Подтвердите действие",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ResetGame();
                return true;
            }

            return false;
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            int wishedNumber;
            bool success;

            if (int.TryParse(GuessNumberTextBox.Text, out wishedNumber))
            {
                success = playerGameInfo.SetWishedNumber(wishedNumber);

                if (success)
                    MakeAMove();           
            }
            else
                MessageBox.Show("Введены некорректные данные, попробуйте снова.", "Произошла ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MakeAMove()
        {
            attemp++;

            if (playerGameInfo.WishedNumber > gameInfo.WishedNumber)
            {
                MainTextBox.Text = $"Загаданное число меньше чем {playerGameInfo.WishedNumber}";
                playerGameInfo.SetMaxNumber(playerGameInfo.WishedNumber);
            }
            else if (playerGameInfo.WishedNumber < gameInfo.WishedNumber)
            {
                MainTextBox.Text = $"Загаданное число больше чем {playerGameInfo.WishedNumber}";
                playerGameInfo.SetMinNumber(playerGameInfo.WishedNumber);
            }
            else
            {
                UpdateUI();
                Win();
            }
        }

        private void Win()
        {
            MessageBox.Show($"Вы победили! Загаданное число - {gameInfo.WishedNumber}. " +
                $"Количeство затраченных попыток - {attemp}.", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Question);

            ResetGame();
        }
    }
}
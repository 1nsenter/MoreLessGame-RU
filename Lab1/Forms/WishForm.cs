using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.Forms
{
    public partial class WishForm : Form
    {
        private GameInfo gameInfo;
        private GameInfo botGameInfo;

        private int attemp = 0;

        public WishForm()
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

        public void InitializeGameInfo()
        {
            gameInfo = new GameInfo();
            botGameInfo = new GameInfo();
        }

        public void InitializeEvents()
        {
            gameInfo.OnWishedNumberChanged += UpdateUI;
            gameInfo.OnWishedNumberChanged += MakeAMove;
            botGameInfo.OnMinMaxChanged += MakeAMove;
        }

        private void UpdateUI()
        {
            if (gameInfo.WishedNumber < gameInfo.MinNumber ||
                gameInfo.WishedNumber > gameInfo.MaxNumber)
            {
                MainTextBox.Text = "Для начала игры загадайте число.";
                WishedNumberLabel.Text = string.Empty;
                MoreButton.Enabled = false;
                LessButton.Enabled = false;
            }
            else
            {
                WishedNumberLabel.Text = "Загаданное число: " + gameInfo.WishedNumber.ToString();
                MoreButton.Enabled = true;
                LessButton.Enabled = true;
            }
        }

        private void MakeAMove()
        {
            botGameInfo.RandomizeWishedNumber();
            attemp++;
            MainTextBox.Text = $"Предположу, что ваше число - {botGameInfo.WishedNumber}";

            if (botGameInfo.WishedNumber == gameInfo.WishedNumber)
                BotWin();
        }

        private void BotWin()
        {
            MessageBox.Show($"Игра окончена. Бот выявил, что загаданное число - {botGameInfo.WishedNumber}. " +
                $"Количeство затраченных попыток - {attemp}.", "Бот победил", MessageBoxButtons.OK, MessageBoxIcon.Question);

            ResetGame();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MoreButton_Click(object sender, EventArgs e)
        {
            if (gameInfo.WishedNumber > botGameInfo.WishedNumber)
                botGameInfo.SetMinNumber(botGameInfo.WishedNumber);
            else
                PlayerWin();
        }

        private void LessButton_Click(object sender, EventArgs e)
        {
            if (gameInfo.WishedNumber < botGameInfo.WishedNumber)
                botGameInfo.SetMaxNumber(botGameInfo.WishedNumber);
            else
                PlayerWin();
        }

        private void PlayerWin()
        {
            MessageBox.Show("Поздравляю! Вы победили, обманув бота.", "Победа игрока",
                MessageBoxButtons.OK, MessageBoxIcon.Question);
            ResetGame();
        }

        private void WishButton_Click(object sender, EventArgs e)
        {
            if (gameInfo.WishedNumber != 0)
            {
                bool success = RestartGame();

                if (success)
                    ShowSetWishNumberForm();
            }
            else
                ShowSetWishNumberForm();
        }

        public bool RestartGame()
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

        private void ShowSetWishNumberForm()
        {
            SetWishNumberForm setWishNumberForm = new(gameInfo);
            setWishNumberForm.ShowDialog();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}

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
        private Wish gameNums;
        private Wish botNums;

        private int attemp = 0;

        public WishForm()
        {
            InitializeComponent();
            ResetGame();
        }

        private void ResetGame()
        {
            InitializeWishNumbers();
            InitializeEvents();
            UpdateUI();
            attemp = 0;
            MainTextBox.Text = "Для начала игры загадайте число.";
        }

        public void InitializeWishNumbers()
        {
            gameNums = new Wish();
            botNums = new Wish();
        }

        public void InitializeEvents()
        {
            gameNums.OnWishedNumberChanged += UpdateUI;
            gameNums.OnWishedNumberChanged += MakeABotMove;
            botNums.OnMinMaxChanged += MakeABotMove;
        }

        private void UpdateUI()
        {
            if (gameNums.WishedNumber < gameNums.MinNumber ||
                gameNums.WishedNumber > gameNums.MaxNumber)
            {
                WishedNumberTextBox.Text = string.Empty;
                MoreButton.Enabled = false;
                LessButton.Enabled = false;
            }
            else
            {
                WishedNumberTextBox.Text = gameNums.WishedNumber.ToString();
                MoreButton.Enabled = true;
                LessButton.Enabled = true;
            }

        }

        private void MakeABotMove()
        {
            
            botNums.RandomizeWishedNumber();
            attemp++;
            MainTextBox.Text = $"Предположу, что ваше число - {botNums.WishedNumber}";

            if (botNums.WishedNumber == gameNums.WishedNumber)
                Win();
        }

        private void Win()
        {
            MessageBox.Show($"Игра окончена. Бот выявил, что загаданное число - {botNums.WishedNumber}. " +
                $"Количeство затраченных попыток = {attemp}.", "Бот победил", MessageBoxButtons.OK, MessageBoxIcon.Question);

            ResetGame();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MoreButton_Click(object sender, EventArgs e)
        {
            botNums.SetMinNumber(botNums.WishedNumber);
        }

        private void LessButton_Click(object sender, EventArgs e)
        {
            botNums.SetMaxNumber(botNums.WishedNumber);
        }

        private void WishButton_Click(object sender, EventArgs e)
        {
            if (gameNums.WishedNumber != 0)
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
            SetWishNumberForm setWishNumberForm = new(gameNums);
            setWishNumberForm.ShowDialog();
        }
    }
}

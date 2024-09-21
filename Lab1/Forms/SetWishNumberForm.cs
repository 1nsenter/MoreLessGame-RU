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
    public partial class SetWishNumberForm : Form
    {
        private GameInfo _wishNums;

        public SetWishNumberForm(GameInfo wishNums)
        {
            InitializeComponent();

            _wishNums = wishNums;

            MainLabel.Text = $"Введите число между {_wishNums.MinNumber} и {_wishNums.MaxNumber}.";
        }

        private void SetWishButton_Click(object sender, EventArgs e)
        {
            int wishedNumber;
            bool success;

            if (int.TryParse(MainTextBox.Text, out wishedNumber))
            {
                success = _wishNums.SetWishedNumber(wishedNumber);

                if (success)
                    this.Close();
                else
                    MainTextBox.Text = string.Empty;
            }
            else
                MessageBox.Show("Введены некорректные данные. Попробуйте еще раз", "Произошла ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

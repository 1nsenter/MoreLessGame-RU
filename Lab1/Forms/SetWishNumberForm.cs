namespace Lab1.Forms
{
    public partial class SetWishNumberForm : Form
    {
        private GameInfo _gameInfo;

        public SetWishNumberForm(GameInfo gameInfo)
        {
            InitializeComponent();

            _gameInfo = gameInfo;

            MainLabel.Text = $"Введите число между {_gameInfo.MinNumber} и {_gameInfo.MaxNumber}.";
        }

        private void SetWishButton_Click(object sender, EventArgs e)
        {
            int wishedNumber;
            bool success;

            if (int.TryParse(MainTextBox.Text, out wishedNumber))
            {
                success = _gameInfo.SetWishedNumber(wishedNumber);

                if (success)
                    this.Close();
                else
                    MainTextBox.Text = string.Empty;
            }
            else
            {
                MainTextBox.Text = string.Empty;
                MessageBox.Show("Введены некорректные данные. Попробуйте еще раз", "Произошла ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

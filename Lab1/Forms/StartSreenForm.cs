namespace Lab1.Forms
{
    public partial class StartScreenForm : Form
    {
        public StartScreenForm()
        {
            InitializeComponent();
        }

        private void WishButton_Click(object sender, EventArgs e)
        {
            WishForm whishForm = new();
            whishForm.ShowDialog();
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            GuessForm guessForm = new();
            guessForm.ShowDialog();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

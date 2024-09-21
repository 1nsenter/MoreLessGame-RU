namespace Lab1.Forms
{
    partial class GuessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuessForm));
            BackButton = new Button();
            GuessNumberLabel = new Label();
            GuessButton = new Button();
            GuessNumberTextBox = new TextBox();
            MainTextBox = new TextBox();
            GuessAttempsLabel = new Label();
            RestartButton = new Button();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = SystemColors.Control;
            BackButton.BackgroundImage = Properties.Resources.free_icon_arrow_left_9847479;
            BackButton.BackgroundImageLayout = ImageLayout.Stretch;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Location = new Point(12, 10);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(45, 45);
            BackButton.TabIndex = 1;
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // GuessNumberLabel
            // 
            GuessNumberLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GuessNumberLabel.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GuessNumberLabel.Location = new Point(12, 195);
            GuessNumberLabel.Name = "GuessNumberLabel";
            GuessNumberLabel.Size = new Size(310, 35);
            GuessNumberLabel.TabIndex = 6;
            GuessNumberLabel.Text = "Введите число от n до nnn\r\n";
            GuessNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GuessButton
            // 
            GuessButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            GuessButton.BackColor = SystemColors.Control;
            GuessButton.FlatAppearance.BorderSize = 0;
            GuessButton.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GuessButton.Location = new Point(172, 239);
            GuessButton.Name = "GuessButton";
            GuessButton.Size = new Size(150, 60);
            GuessButton.TabIndex = 7;
            GuessButton.Text = "Ввести";
            GuessButton.UseVisualStyleBackColor = false;
            GuessButton.Click += GuessButton_Click;
            // 
            // GuessNumberTextBox
            // 
            GuessNumberTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            GuessNumberTextBox.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GuessNumberTextBox.Location = new Point(12, 250);
            GuessNumberTextBox.Name = "GuessNumberTextBox";
            GuessNumberTextBox.Size = new Size(150, 40);
            GuessNumberTextBox.TabIndex = 8;
            GuessNumberTextBox.Text = "nnn";
            GuessNumberTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // MainTextBox
            // 
            MainTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MainTextBox.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainTextBox.Location = new Point(12, 77);
            MainTextBox.Multiline = true;
            MainTextBox.Name = "MainTextBox";
            MainTextBox.ReadOnly = true;
            MainTextBox.Size = new Size(310, 104);
            MainTextBox.TabIndex = 9;
            MainTextBox.Text = "Lorem";
            // 
            // GuessAttempsLabel
            // 
            GuessAttempsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            GuessAttempsLabel.AutoSize = true;
            GuessAttempsLabel.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GuessAttempsLabel.Location = new Point(149, 16);
            GuessAttempsLabel.Name = "GuessAttempsLabel";
            GuessAttempsLabel.Size = new Size(176, 25);
            GuessAttempsLabel.TabIndex = 10;
            GuessAttempsLabel.Text = "Количество попыток: nn";
            // 
            // RestartButton
            // 
            RestartButton.BackColor = SystemColors.Control;
            RestartButton.BackgroundImage = (Image)resources.GetObject("RestartButton.BackgroundImage");
            RestartButton.BackgroundImageLayout = ImageLayout.Stretch;
            RestartButton.FlatAppearance.BorderSize = 0;
            RestartButton.FlatStyle = FlatStyle.Flat;
            RestartButton.Location = new Point(63, 10);
            RestartButton.Name = "RestartButton";
            RestartButton.Size = new Size(45, 45);
            RestartButton.TabIndex = 11;
            RestartButton.UseVisualStyleBackColor = false;
            RestartButton.Click += RestartButton_Click;
            // 
            // GuessForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 311);
            Controls.Add(RestartButton);
            Controls.Add(GuessAttempsLabel);
            Controls.Add(MainTextBox);
            Controls.Add(GuessNumberTextBox);
            Controls.Add(GuessButton);
            Controls.Add(GuessNumberLabel);
            Controls.Add(BackButton);
            MaximizeBox = false;
            MaximumSize = new Size(350, 350);
            MinimumSize = new Size(350, 350);
            Name = "GuessForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guess";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Label GuessNumberLabel;
        private Button GuessButton;
        private TextBox GuessNumberTextBox;
        private TextBox MainTextBox;
        private Label GuessAttempsLabel;
        private Button RestartButton;
    }
}
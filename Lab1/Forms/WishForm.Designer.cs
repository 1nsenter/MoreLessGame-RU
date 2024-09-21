namespace Lab1.Forms
{
    partial class WishForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WishForm));
            BackButton = new Button();
            LessButton = new Button();
            MoreButton = new Button();
            WishButton = new Button();
            MainTextBox = new TextBox();
            WishedNumberLabel = new Label();
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
            BackButton.TabIndex = 0;
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // LessButton
            // 
            LessButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LessButton.BackColor = SystemColors.Control;
            LessButton.FlatAppearance.BorderSize = 0;
            LessButton.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LessButton.Location = new Point(12, 178);
            LessButton.Name = "LessButton";
            LessButton.Size = new Size(150, 60);
            LessButton.TabIndex = 1;
            LessButton.Text = "Меньше";
            LessButton.UseVisualStyleBackColor = false;
            LessButton.Click += LessButton_Click;
            // 
            // MoreButton
            // 
            MoreButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MoreButton.BackColor = SystemColors.Control;
            MoreButton.FlatAppearance.BorderSize = 0;
            MoreButton.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MoreButton.Location = new Point(172, 178);
            MoreButton.Name = "MoreButton";
            MoreButton.Size = new Size(150, 60);
            MoreButton.TabIndex = 2;
            MoreButton.Text = "Больше";
            MoreButton.UseVisualStyleBackColor = false;
            MoreButton.Click += MoreButton_Click;
            // 
            // WishButton
            // 
            WishButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WishButton.BackColor = SystemColors.Control;
            WishButton.FlatAppearance.BorderSize = 0;
            WishButton.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WishButton.Location = new Point(12, 244);
            WishButton.Name = "WishButton";
            WishButton.Size = new Size(310, 60);
            WishButton.TabIndex = 3;
            WishButton.Text = "Загадать число";
            WishButton.UseVisualStyleBackColor = false;
            WishButton.Click += WishButton_Click;
            // 
            // MainTextBox
            // 
            MainTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MainTextBox.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainTextBox.Location = new Point(12, 68);
            MainTextBox.Multiline = true;
            MainTextBox.Name = "MainTextBox";
            MainTextBox.ReadOnly = true;
            MainTextBox.Size = new Size(310, 104);
            MainTextBox.TabIndex = 4;
            MainTextBox.Text = "Lorem";
            // 
            // WishedNumberLabel
            // 
            WishedNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            WishedNumberLabel.AutoSize = true;
            WishedNumberLabel.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WishedNumberLabel.Location = new Point(149, 16);
            WishedNumberLabel.Name = "WishedNumberLabel";
            WishedNumberLabel.Size = new Size(173, 25);
            WishedNumberLabel.TabIndex = 6;
            WishedNumberLabel.Text = "Загаданное число: nnn";
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
            RestartButton.TabIndex = 12;
            RestartButton.UseVisualStyleBackColor = false;
            RestartButton.Click += RestartButton_Click;
            // 
            // WishForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 311);
            Controls.Add(RestartButton);
            Controls.Add(WishedNumberLabel);
            Controls.Add(MainTextBox);
            Controls.Add(WishButton);
            Controls.Add(MoreButton);
            Controls.Add(LessButton);
            Controls.Add(BackButton);
            MaximizeBox = false;
            MaximumSize = new Size(350, 350);
            MinimumSize = new Size(350, 350);
            Name = "WishForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wish";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Button LessButton;
        private Button MoreButton;
        private Button WishButton;
        private TextBox MainTextBox;
        private Label WishedNumberLabel;
        private Button RestartButton;
    }
}
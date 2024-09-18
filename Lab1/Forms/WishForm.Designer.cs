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
            BackButton = new Button();
            LessButton = new Button();
            MoreButton = new Button();
            WishButton = new Button();
            MainTextBox = new TextBox();
            label1 = new Label();
            WishedNumberTextBox = new TextBox();
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
            LessButton.BackColor = SystemColors.Control;
            LessButton.FlatAppearance.BorderSize = 0;
            LessButton.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LessButton.Location = new Point(12, 178);
            LessButton.Name = "LessButton";
            LessButton.Size = new Size(151, 60);
            LessButton.TabIndex = 1;
            LessButton.Text = "Меньше";
            LessButton.UseVisualStyleBackColor = false;
            LessButton.Click += LessButton_Click;
            // 
            // MoreButton
            // 
            MoreButton.BackColor = SystemColors.Control;
            MoreButton.FlatAppearance.BorderSize = 0;
            MoreButton.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MoreButton.Location = new Point(174, 178);
            MoreButton.Name = "MoreButton";
            MoreButton.Size = new Size(148, 60);
            MoreButton.TabIndex = 2;
            MoreButton.Text = "Больше";
            MoreButton.UseVisualStyleBackColor = false;
            MoreButton.Click += MoreButton_Click;
            // 
            // WishButton
            // 
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
            MainTextBox.Location = new Point(12, 68);
            MainTextBox.Multiline = true;
            MainTextBox.Name = "MainTextBox";
            MainTextBox.ReadOnly = true;
            MainTextBox.Size = new Size(310, 104);
            MainTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(127, 16);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 5;
            label1.Text = "Загаданное число:";
            // 
            // WishedNumberTextBox
            // 
            WishedNumberTextBox.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WishedNumberTextBox.Location = new Point(275, 13);
            WishedNumberTextBox.Name = "WishedNumberTextBox";
            WishedNumberTextBox.ReadOnly = true;
            WishedNumberTextBox.Size = new Size(47, 33);
            WishedNumberTextBox.TabIndex = 6;
            // 
            // WishForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 311);
            Controls.Add(WishedNumberTextBox);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox WishedNumberTextBox;
    }
}
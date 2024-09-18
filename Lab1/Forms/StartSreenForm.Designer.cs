namespace Lab1.Forms
{
    partial class StartScreenForm
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
            WishButton = new Button();
            GuessButton = new Button();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // WishButton
            // 
            WishButton.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WishButton.Location = new Point(50, 40);
            WishButton.Name = "WishButton";
            WishButton.Size = new Size(250, 70);
            WishButton.TabIndex = 0;
            WishButton.Text = "Загадать число";
            WishButton.UseVisualStyleBackColor = true;
            WishButton.Click += WishButton_Click;
            // 
            // GuessButton
            // 
            GuessButton.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GuessButton.Location = new Point(50, 120);
            GuessButton.Name = "GuessButton";
            GuessButton.Size = new Size(250, 70);
            GuessButton.TabIndex = 1;
            GuessButton.Text = "Отгадать число";
            GuessButton.UseVisualStyleBackColor = true;
            GuessButton.Click += GuessButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseButton.Location = new Point(50, 200);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(250, 70);
            CloseButton.TabIndex = 2;
            CloseButton.Text = "Выход";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // StartScreenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 311);
            Controls.Add(CloseButton);
            Controls.Add(GuessButton);
            Controls.Add(WishButton);
            Name = "StartScreenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartScreen";
            ResumeLayout(false);
        }

        #endregion

        private Button WishButton;
        private Button GuessButton;
        private Button CloseButton;
    }
}
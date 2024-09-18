namespace Lab1.Forms
{
    partial class SetWishNumberForm
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
            MainLabel = new Label();
            SetWishButton = new Button();
            MainTextBox = new TextBox();
            SuspendLayout();
            // 
            // MainLabel
            // 
            MainLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainLabel.Location = new Point(11, 9);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(211, 55);
            MainLabel.TabIndex = 0;
            // 
            // SetWishButton
            // 
            SetWishButton.BackColor = SystemColors.Control;
            SetWishButton.FlatAppearance.BorderSize = 0;
            SetWishButton.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SetWishButton.Location = new Point(11, 67);
            SetWishButton.Name = "SetWishButton";
            SetWishButton.Size = new Size(72, 32);
            SetWishButton.TabIndex = 1;
            SetWishButton.Text = "Загадать";
            SetWishButton.UseVisualStyleBackColor = false;
            SetWishButton.Click += SetWishButton_Click;
            // 
            // MainTextBox
            // 
            MainTextBox.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainTextBox.Location = new Point(100, 71);
            MainTextBox.Name = "MainTextBox";
            MainTextBox.Size = new Size(122, 27);
            MainTextBox.TabIndex = 2;
            // 
            // SetWishNumberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 111);
            Controls.Add(MainTextBox);
            Controls.Add(SetWishButton);
            Controls.Add(MainLabel);
            Name = "SetWishNumberForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SetWishNumber";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainLabel;
        private Button SetWishButton;
        private TextBox MainTextBox;
    }
}
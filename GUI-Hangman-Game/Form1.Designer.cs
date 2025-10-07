namespace GUI_Hangman_Game
{
    partial class Form1
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
            this.gamePanel = new System.Windows.Forms.Panel();
            this.wordLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.hangManPicture = new System.Windows.Forms.PictureBox();
            this.hintWordLabel = new System.Windows.Forms.Label();
            this.buttonLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangManPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.startGameButton);
            this.gamePanel.Controls.Add(this.wordLayoutPanel);
            this.gamePanel.Controls.Add(this.hangManPicture);
            this.gamePanel.Controls.Add(this.hintWordLabel);
            this.gamePanel.Controls.Add(this.buttonLayoutPanel);
            this.gamePanel.Controls.Add(this.label1);
            this.gamePanel.Location = new System.Drawing.Point(12, 12);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(1473, 858);
            this.gamePanel.TabIndex = 0;
            // 
            // wordLayoutPanel
            // 
            this.wordLayoutPanel.AutoSize = true;
            this.wordLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wordLayoutPanel.Location = new System.Drawing.Point(650, 720);
            this.wordLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.wordLayoutPanel.Name = "wordLayoutPanel";
            this.wordLayoutPanel.Size = new System.Drawing.Size(0, 0);
            this.wordLayoutPanel.TabIndex = 8;
            // 
            // hangManPicture
            // 
            this.hangManPicture.Image = global::GUI_Hangman_Game.Properties.Resources.Mistake_0;
            this.hangManPicture.Location = new System.Drawing.Point(650, 112);
            this.hangManPicture.Name = "hangManPicture";
            this.hangManPicture.Size = new System.Drawing.Size(743, 570);
            this.hangManPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hangManPicture.TabIndex = 7;
            this.hangManPicture.TabStop = false;
            // 
            // hintWordLabel
            // 
            this.hintWordLabel.AutoSize = true;
            this.hintWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.hintWordLabel.Location = new System.Drawing.Point(73, 685);
            this.hintWordLabel.MaximumSize = new System.Drawing.Size(512, 150);
            this.hintWordLabel.Name = "hintWordLabel";
            this.hintWordLabel.Size = new System.Drawing.Size(162, 55);
            this.hintWordLabel.TabIndex = 5;
            this.hintWordLabel.Text = "HINT: ";
            // 
            // buttonLayoutPanel
            // 
            this.buttonLayoutPanel.Location = new System.Drawing.Point(73, 112);
            this.buttonLayoutPanel.Name = "buttonLayoutPanel";
            this.buttonLayoutPanel.Size = new System.Drawing.Size(531, 570);
            this.buttonLayoutPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(131, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHOOSE A LETTER";
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(601, 354);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(212, 121);
            this.startGameButton.TabIndex = 9;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 882);
            this.Controls.Add(this.gamePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangManPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel buttonLayoutPanel;
        private System.Windows.Forms.Label hintWordLabel;
        private System.Windows.Forms.PictureBox hangManPicture;
        private System.Windows.Forms.FlowLayoutPanel wordLayoutPanel;
        private System.Windows.Forms.Button startGameButton;
    }
}


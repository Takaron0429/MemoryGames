namespace MemoryGames
{
    partial class Help
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
            this.closeButton = new System.Windows.Forms.Button();
            this.backwardButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.helpLabel1 = new System.Windows.Forms.Label();
            this.helpLabel2 = new System.Windows.Forms.Label();
            this.helpLabel3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(341, 386);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(118, 55);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "BEZÁRÁS";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // backwardButton
            // 
            this.backwardButton.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backwardButton.Location = new System.Drawing.Point(277, 386);
            this.backwardButton.Name = "backwardButton";
            this.backwardButton.Size = new System.Drawing.Size(58, 55);
            this.backwardButton.TabIndex = 2;
            this.backwardButton.Text = "<";
            this.backwardButton.UseVisualStyleBackColor = true;
            this.backwardButton.Click += new System.EventHandler(this.backwardButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forwardButton.Location = new System.Drawing.Point(465, 386);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(58, 55);
            this.forwardButton.TabIndex = 3;
            this.forwardButton.Text = ">";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::MemoryGames.Properties.Resources.help1;
            this.pictureBox.Location = new System.Drawing.Point(12, -1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(776, 381);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // helpLabel1
            // 
            this.helpLabel1.AutoSize = true;
            this.helpLabel1.BackColor = System.Drawing.Color.Black;
            this.helpLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.helpLabel1.Location = new System.Drawing.Point(32, 334);
            this.helpLabel1.Name = "helpLabel1";
            this.helpLabel1.Size = new System.Drawing.Size(227, 42);
            this.helpLabel1.TabIndex = 4;
            this.helpLabel1.Text = "A játék kezdéséhez kattintson\r\na \"JÁTÉK KEZDÉSE\" gombra!";
            // 
            // helpLabel2
            // 
            this.helpLabel2.AutoSize = true;
            this.helpLabel2.BackColor = System.Drawing.Color.Black;
            this.helpLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.helpLabel2.Location = new System.Drawing.Point(119, 80);
            this.helpLabel2.Name = "helpLabel2";
            this.helpLabel2.Size = new System.Drawing.Size(239, 42);
            this.helpLabel2.TabIndex = 5;
            this.helpLabel2.Text = "A műsorvezető gombra kattintva\r\nmegjelenik a következő kérdés";
            // 
            // helpLabel3
            // 
            this.helpLabel3.AutoSize = true;
            this.helpLabel3.BackColor = System.Drawing.Color.Black;
            this.helpLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.helpLabel3.Location = new System.Drawing.Point(530, 62);
            this.helpLabel3.Name = "helpLabel3";
            this.helpLabel3.Size = new System.Drawing.Size(265, 42);
            this.helpLabel3.TabIndex = 6;
            this.helpLabel3.Text = "Ezzek a segítségek, de vigyázz nem\r\nbiztos hogy a helyes választ adják!";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.helpLabel3);
            this.Controls.Add(this.helpLabel2);
            this.Controls.Add(this.helpLabel1);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.backwardButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Help";
            this.Text = "Legyen Ön is milliomos!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button backwardButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Label helpLabel1;
        private System.Windows.Forms.Label helpLabel2;
        private System.Windows.Forms.Label helpLabel3;
    }
}
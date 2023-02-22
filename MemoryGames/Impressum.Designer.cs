namespace MemoryGames
{
    partial class Impressum
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
            this.tkLabel = new System.Windows.Forms.Label();
            this.vrLabel = new System.Windows.Forms.Label();
            this.madebyLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(143, 377);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(97, 38);
            this.closeButton.TabIndex = 16;
            this.closeButton.Text = "BEZÁRÁS";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // tkLabel
            // 
            this.tkLabel.AutoSize = true;
            this.tkLabel.BackColor = System.Drawing.Color.Transparent;
            this.tkLabel.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tkLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.tkLabel.Location = new System.Drawing.Point(107, 134);
            this.tkLabel.Name = "tkLabel";
            this.tkLabel.Size = new System.Drawing.Size(171, 30);
            this.tkLabel.TabIndex = 15;
            this.tkLabel.Text = "Takács Áron";
            // 
            // vrLabel
            // 
            this.vrLabel.AutoSize = true;
            this.vrLabel.BackColor = System.Drawing.Color.Transparent;
            this.vrLabel.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.vrLabel.Location = new System.Drawing.Point(59, 81);
            this.vrLabel.Name = "vrLabel";
            this.vrLabel.Size = new System.Drawing.Size(273, 30);
            this.vrLabel.TabIndex = 14;
            this.vrLabel.Text = "Vodenicsár Rajmund";
            // 
            // madebyLabel
            // 
            this.madebyLabel.AutoSize = true;
            this.madebyLabel.BackColor = System.Drawing.Color.Transparent;
            this.madebyLabel.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madebyLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.madebyLabel.Location = new System.Drawing.Point(77, 9);
            this.madebyLabel.Name = "madebyLabel";
            this.madebyLabel.Size = new System.Drawing.Size(233, 44);
            this.madebyLabel.TabIndex = 13;
            this.madebyLabel.Text = "Készítette:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::MemoryGames.Properties.Resources.legyen_on_is_milliomos_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Impressum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(388, 437);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.tkLabel);
            this.Controls.Add(this.vrLabel);
            this.Controls.Add(this.madebyLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Impressum";
            this.Text = "Legyen Ön is milliomos!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label tkLabel;
        private System.Windows.Forms.Label vrLabel;
        private System.Windows.Forms.Label madebyLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
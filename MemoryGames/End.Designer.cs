namespace MemoryGames
{
    partial class End
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.Cim = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MemoryGames.Properties.Resources.box;
            this.pictureBox1.Location = new System.Drawing.Point(71, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(661, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Black;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.name.Location = new System.Drawing.Point(251, 234);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(305, 55);
            this.name.TabIndex = 1;
            this.name.Text = "Takács Áron";
            this.name.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cim
            // 
            this.Cim.AutoSize = true;
            this.Cim.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cim.ForeColor = System.Drawing.Color.White;
            this.Cim.Location = new System.Drawing.Point(293, 344);
            this.Cim.Name = "Cim";
            this.Cim.Size = new System.Drawing.Size(213, 51);
            this.Cim.TabIndex = 2;
            this.Cim.Text = "Milliomos";
            this.Cim.Click += new System.EventHandler(this.label2_Click);
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Money.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Money.Location = new System.Drawing.Point(207, 107);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(443, 73);
            this.Money.TabIndex = 3;
            this.Money.Text = "40.000.000 Ft";
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.Cim);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "End";
            this.Text = "End";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Cim;
        private System.Windows.Forms.Label Money;
    }
}
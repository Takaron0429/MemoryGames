using System.Drawing;

namespace MemoryGames
{
    partial class Menu
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
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.scoreboardListBox = new System.Windows.Forms.ListBox();
            this.scoreboardLabel = new System.Windows.Forms.Label();
            this.impressumLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.Control;
            this.startButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startButton.Location = new System.Drawing.Point(624, 141);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(121, 53);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "ÚJ JÁTÉK";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitButton.Location = new System.Drawing.Point(624, 259);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(121, 53);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "KILÉPÉS";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(728, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Version 0.9";
            // 
            // scoreboardListBox
            // 
            this.scoreboardListBox.BackColor = System.Drawing.Color.Black;
            this.scoreboardListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreboardListBox.ForeColor = System.Drawing.Color.White;
            this.scoreboardListBox.FormattingEnabled = true;
            this.scoreboardListBox.ItemHeight = 15;
            this.scoreboardListBox.Location = new System.Drawing.Point(15, 141);
            this.scoreboardListBox.Name = "scoreboardListBox";
            this.scoreboardListBox.Size = new System.Drawing.Size(197, 199);
            this.scoreboardListBox.TabIndex = 5;
            this.scoreboardListBox.SelectedIndexChanged += new System.EventHandler(this.scoreboardListBox_SelectedIndexChanged);
            // 
            // scoreboardLabel
            // 
            this.scoreboardLabel.AutoSize = true;
            this.scoreboardLabel.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboardLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.scoreboardLabel.Location = new System.Drawing.Point(55, 101);
            this.scoreboardLabel.Name = "scoreboardLabel";
            this.scoreboardLabel.Size = new System.Drawing.Size(121, 27);
            this.scoreboardLabel.TabIndex = 6;
            this.scoreboardLabel.Text = "RANGLISTA";
            // 
            // impressumLabel
            // 
            this.impressumLabel.AutoSize = true;
            this.impressumLabel.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impressumLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.impressumLabel.Location = new System.Drawing.Point(355, 428);
            this.impressumLabel.Name = "impressumLabel";
            this.impressumLabel.Size = new System.Drawing.Size(92, 17);
            this.impressumLabel.TabIndex = 7;
            this.impressumLabel.Text = "Impresszum";
            this.impressumLabel.Click += new System.EventHandler(this.impressumLabel_Click);
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(624, 200);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(121, 53);
            this.helpButton.TabIndex = 8;
            this.helpButton.Text = "SÚGÓ";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(60, 346);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(90, 30);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "FRISSÍTÉS";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(83)))));
            this.BackgroundImage = global::MemoryGames.Properties.Resources.legyen_on_is_milliomos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.impressumLabel);
            this.Controls.Add(this.scoreboardLabel);
            this.Controls.Add(this.scoreboardListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Legyen Ön is milliomos!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox scoreboardListBox;
        private System.Windows.Forms.Label scoreboardLabel;
        private System.Windows.Forms.Label impressumLabel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button updateButton;
    }
}


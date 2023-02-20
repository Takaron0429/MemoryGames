﻿using System.Drawing;

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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scoreboardListBox = new System.Windows.Forms.ListBox();
            this.scoreboardLabel = new System.Windows.Forms.Label();
            this.impressumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.Control;
            this.startButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startButton.Location = new System.Drawing.Point(630, 153);
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
            this.exitButton.Location = new System.Drawing.Point(630, 260);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(121, 53);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "KILÉPÉS";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IN DEVELOPMENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(728, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Version 0.6";
            // 
            // scoreboardListBox
            // 
            this.scoreboardListBox.BackColor = System.Drawing.Color.Black;
            this.scoreboardListBox.ForeColor = System.Drawing.SystemColors.Control;
            this.scoreboardListBox.FormattingEnabled = true;
            this.scoreboardListBox.Location = new System.Drawing.Point(27, 140);
            this.scoreboardListBox.Name = "scoreboardListBox";
            this.scoreboardListBox.Size = new System.Drawing.Size(178, 199);
            this.scoreboardListBox.TabIndex = 5;
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
            this.impressumLabel.Location = new System.Drawing.Point(358, 428);
            this.impressumLabel.Name = "impressumLabel";
            this.impressumLabel.Size = new System.Drawing.Size(92, 17);
            this.impressumLabel.TabIndex = 7;
            this.impressumLabel.Text = "Impresszum";
            this.impressumLabel.Click += new System.EventHandler(this.impressumLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(43)))), ((int)(((byte)(83)))));
            this.BackgroundImage = global::MemoryGames.Properties.Resources.legyen_on_is_milliomos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.impressumLabel);
            this.Controls.Add(this.scoreboardLabel);
            this.Controls.Add(this.scoreboardListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Legyen Ön is milliomos! (Fejlesztés alatt)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox scoreboardListBox;
        private System.Windows.Forms.Label scoreboardLabel;
        private System.Windows.Forms.Label impressumLabel;
    }
}

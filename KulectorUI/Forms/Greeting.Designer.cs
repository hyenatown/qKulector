﻿namespace KulectorUI.Forms
{
    partial class Greeting
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
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.LblSubtitle = new System.Windows.Forms.Label();
            this.SfdCreateKul = new System.Windows.Forms.SaveFileDialog();
            this.OfdOpenKul = new System.Windows.Forms.OpenFileDialog();
            this.BtnAdvanceImport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(79, 121);
            this.BtnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(150, 31);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "Create a Kulection";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(79, 160);
            this.BtnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(150, 31);
            this.BtnOpen.TabIndex = 1;
            this.BtnOpen.Text = "Open a Kulection";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // LblSubtitle
            // 
            this.LblSubtitle.AutoSize = true;
            this.LblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSubtitle.Location = new System.Drawing.Point(87, 64);
            this.LblSubtitle.Name = "LblSubtitle";
            this.LblSubtitle.Size = new System.Drawing.Size(137, 46);
            this.LblSubtitle.TabIndex = 3;
            this.LblSubtitle.Text = "Collect what you\r\ncare about";
            this.LblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SfdCreateKul
            // 
            this.SfdCreateKul.DefaultExt = "kul";
            this.SfdCreateKul.Filter = "Kulections|*.kul";
            // 
            // OfdOpenKul
            // 
            this.OfdOpenKul.DefaultExt = "kul";
            this.OfdOpenKul.Filter = "Kulections|*.kul";
            // 
            // BtnAdvanceImport
            // 
            this.BtnAdvanceImport.Location = new System.Drawing.Point(79, 199);
            this.BtnAdvanceImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAdvanceImport.Name = "BtnAdvanceImport";
            this.BtnAdvanceImport.Size = new System.Drawing.Size(150, 31);
            this.BtnAdvanceImport.TabIndex = 6;
            this.BtnAdvanceImport.Text = "Advanced Import";
            this.BtnAdvanceImport.UseVisualStyleBackColor = true;
            this.BtnAdvanceImport.Click += new System.EventHandler(this.BtnAdvanceImport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KulectorUI.Properties.Resources.MainLogo;
            this.pictureBox1.Location = new System.Drawing.Point(64, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 238);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Greeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 288);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnAdvanceImport);
            this.Controls.Add(this.LblSubtitle);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.BtnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::KulectorUI.Properties.Resources.MainIcon;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Greeting";
            this.Text = "Kulector - Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnCreate;
        private Button BtnOpen;
        private Label LblSubtitle;
        private SaveFileDialog SfdCreateKul;
        private OpenFileDialog OfdOpenKul;
        private Button BtnAdvanceImport;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
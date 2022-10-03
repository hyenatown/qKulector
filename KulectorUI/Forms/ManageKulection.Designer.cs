﻿namespace KulectorUI.Forms
{
    partial class ManageKulection
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
            this.DGVItems = new System.Windows.Forms.DataGridView();
            this.ClmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNSave = new System.Windows.Forms.Button();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.BTNRemove = new System.Windows.Forms.Button();
            this.TLPEditButtons = new System.Windows.Forms.TableLayoutPanel();
            this.SfdCreateKul = new System.Windows.Forms.SaveFileDialog();
            this.PNLTitle = new System.Windows.Forms.Panel();
            this.LBLTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).BeginInit();
            this.TLPEditButtons.SuspendLayout();
            this.PNLTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVItems
            // 
            this.DGVItems.AllowUserToAddRows = false;
            this.DGVItems.AllowUserToDeleteRows = false;
            this.DGVItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmName,
            this.ClmDescrip,
            this.ClmGuid,
            this.ClmnQuantity});
            this.DGVItems.Location = new System.Drawing.Point(14, 13);
            this.DGVItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVItems.Name = "DGVItems";
            this.DGVItems.ReadOnly = true;
            this.DGVItems.RowHeadersVisible = false;
            this.DGVItems.RowHeadersWidth = 51;
            this.DGVItems.RowTemplate.Height = 25;
            this.DGVItems.Size = new System.Drawing.Size(886, 488);
            this.DGVItems.TabIndex = 0;
            // 
            // ClmName
            // 
            this.ClmName.HeaderText = "Name";
            this.ClmName.MinimumWidth = 6;
            this.ClmName.Name = "ClmName";
            this.ClmName.ReadOnly = true;
            // 
            // ClmDescrip
            // 
            this.ClmDescrip.HeaderText = "Description";
            this.ClmDescrip.MinimumWidth = 6;
            this.ClmDescrip.Name = "ClmDescrip";
            this.ClmDescrip.ReadOnly = true;
            this.ClmDescrip.Visible = false;
            // 
            // ClmGuid
            // 
            this.ClmGuid.HeaderText = "GUID";
            this.ClmGuid.MinimumWidth = 6;
            this.ClmGuid.Name = "ClmGuid";
            this.ClmGuid.ReadOnly = true;
            this.ClmGuid.Visible = false;
            // 
            // ClmnQuantity
            // 
            this.ClmnQuantity.HeaderText = "Quantity";
            this.ClmnQuantity.MinimumWidth = 6;
            this.ClmnQuantity.Name = "ClmnQuantity";
            this.ClmnQuantity.ReadOnly = true;
            // 
            // BTNSave
            // 
            this.BTNSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNSave.Location = new System.Drawing.Point(568, 4);
            this.BTNSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(315, 44);
            this.BTNSave.TabIndex = 2;
            this.BTNSave.Text = "Save Kulection";
            this.BTNSave.UseVisualStyleBackColor = true;
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // BTNAdd
            // 
            this.BTNAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNAdd.Location = new System.Drawing.Point(3, 4);
            this.BTNAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(271, 44);
            this.BTNAdd.TabIndex = 3;
            this.BTNAdd.Text = "Add Item";
            this.BTNAdd.UseVisualStyleBackColor = true;
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // BTNRemove
            // 
            this.BTNRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTNRemove.Location = new System.Drawing.Point(280, 4);
            this.BTNRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNRemove.Name = "BTNRemove";
            this.BTNRemove.Size = new System.Drawing.Size(282, 44);
            this.BTNRemove.TabIndex = 4;
            this.BTNRemove.Text = "Remove Item";
            this.BTNRemove.UseVisualStyleBackColor = true;
            this.BTNRemove.Click += new System.EventHandler(this.BTNRemove_Click);
            // 
            // TLPEditButtons
            // 
            this.TLPEditButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLPEditButtons.ColumnCount = 3;
            this.TLPEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPEditButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPEditButtons.Controls.Add(this.BTNAdd, 0, 0);
            this.TLPEditButtons.Controls.Add(this.BTNSave, 2, 0);
            this.TLPEditButtons.Controls.Add(this.BTNRemove, 1, 0);
            this.TLPEditButtons.Location = new System.Drawing.Point(14, 544);
            this.TLPEditButtons.Name = "TLPEditButtons";
            this.TLPEditButtons.RowCount = 1;
            this.TLPEditButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPEditButtons.Size = new System.Drawing.Size(886, 52);
            this.TLPEditButtons.TabIndex = 5;
            // 
            // SfdCreateKul
            // 
            this.SfdCreateKul.DefaultExt = "kul";
            this.SfdCreateKul.Filter = "Kulections|*.kul";
            // 
            // PNLTitle
            // 
            this.PNLTitle.Controls.Add(this.LBLTitle);
            this.PNLTitle.Location = new System.Drawing.Point(14, 504);
            this.PNLTitle.Name = "PNLTitle";
            this.PNLTitle.Size = new System.Drawing.Size(883, 37);
            this.PNLTitle.TabIndex = 6;
            // 
            // LBLTitle
            // 
            this.LBLTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBLTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLTitle.Location = new System.Drawing.Point(0, 0);
            this.LBLTitle.Name = "LBLTitle";
            this.LBLTitle.Size = new System.Drawing.Size(883, 37);
            this.LBLTitle.TabIndex = 0;
            this.LBLTitle.Text = "[ KUL TITLE ]";
            this.LBLTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageKulection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 605);
            this.Controls.Add(this.PNLTitle);
            this.Controls.Add(this.TLPEditButtons);
            this.Controls.Add(this.DGVItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageKulection";
            this.Text = "Kulector - Manage Kulection";
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).EndInit();
            this.TLPEditButtons.ResumeLayout(false);
            this.PNLTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DGVItems;
        private Button BTNSave;
        private Button BTNAdd;
        private Button BTNRemove;
        private DataGridViewTextBoxColumn ClmName;
        private DataGridViewTextBoxColumn ClmDescrip;
        private DataGridViewTextBoxColumn ClmGuid;
        private DataGridViewTextBoxColumn ClmnQuantity;
        private TableLayoutPanel TLPEditButtons;
        private SaveFileDialog SfdCreateKul;
        private Panel PNLTitle;
        private Label LBLTitle;
    }
}
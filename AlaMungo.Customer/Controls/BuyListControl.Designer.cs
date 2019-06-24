﻿namespace AlaMungo.Customer.Controls
{
    partial class BuyListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvBuy = new System.Windows.Forms.DataGridView();
            this.lblCount = new System.Windows.Forms.Label();
            this.bdsBuy = new System.Windows.Forms.BindingSource(this.components);
            this.BuyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookWriter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookQulity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuy
            // 
            this.dgvBuy.AutoGenerateColumns = false;
            this.dgvBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BuyID,
            this.BookTitle,
            this.BookWriter,
            this.BookQulity,
            this.BookPrice});
            this.dgvBuy.DataSource = this.bdsBuy;
            this.dgvBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBuy.Location = new System.Drawing.Point(0, 0);
            this.dgvBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBuy.Name = "dgvBuy";
            this.dgvBuy.RowTemplate.Height = 27;
            this.dgvBuy.Size = new System.Drawing.Size(689, 491);
            this.dgvBuy.TabIndex = 1;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCount.Location = new System.Drawing.Point(0, 479);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(29, 12);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "대기";
            // 
            // bdsBuy
            // 
            this.bdsBuy.DataSource = typeof(AlaMungo.Data.Buy);
            // 
            // BuyID
            // 
            this.BuyID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BuyID.DataPropertyName = "BuyID";
            this.BuyID.HeaderText = "중고책 ID";
            this.BuyID.Name = "BuyID";
            this.BuyID.ReadOnly = true;
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookTitle.DataPropertyName = "BookTitle";
            this.BookTitle.HeaderText = "책 제목";
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.ReadOnly = true;
            // 
            // BookWriter
            // 
            this.BookWriter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BookWriter.DataPropertyName = "BookWriter";
            this.BookWriter.HeaderText = "저자";
            this.BookWriter.Name = "BookWriter";
            this.BookWriter.ReadOnly = true;
            this.BookWriter.Width = 150;
            // 
            // BookQulity
            // 
            this.BookQulity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BookQulity.DataPropertyName = "BookQulity";
            this.BookQulity.HeaderText = "품질";
            this.BookQulity.Name = "BookQulity";
            this.BookQulity.ReadOnly = true;
            // 
            // BookPrice
            // 
            this.BookPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BookPrice.DataPropertyName = "BookPrice";
            this.BookPrice.HeaderText = "가격";
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.ReadOnly = true;
            // 
            // BuyListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dgvBuy);
            this.Name = "BuyListControl";
            this.Size = new System.Drawing.Size(689, 491);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuy;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.BindingSource bdsBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookWriter;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookQulity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPrice;
    }
}

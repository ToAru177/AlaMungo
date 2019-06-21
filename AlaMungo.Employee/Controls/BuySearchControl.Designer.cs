namespace AlaMungo.Employee.Controls
{
    partial class BuySearchControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chbTitle = new System.Windows.Forms.CheckBox();
            this.txbBuyerID = new System.Windows.Forms.TextBox();
            this.chbBuyerID = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbTitle);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chbTitle);
            this.groupBox1.Controls.Add(this.txbBuyerID);
            this.groupBox1.Controls.Add(this.chbBuyerID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 48);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(565, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "책 이름 :";
            // 
            // chbTitle
            // 
            this.chbTitle.AutoSize = true;
            this.chbTitle.Location = new System.Drawing.Point(217, 20);
            this.chbTitle.Name = "chbTitle";
            this.chbTitle.Size = new System.Drawing.Size(15, 14);
            this.chbTitle.TabIndex = 9;
            this.chbTitle.UseVisualStyleBackColor = true;
            // 
            // txbBuyerID
            // 
            this.txbBuyerID.Location = new System.Drawing.Point(101, 17);
            this.txbBuyerID.Name = "txbBuyerID";
            this.txbBuyerID.Size = new System.Drawing.Size(100, 21);
            this.txbBuyerID.TabIndex = 6;
            // 
            // chbBuyerID
            // 
            this.chbBuyerID.AutoSize = true;
            this.chbBuyerID.Location = new System.Drawing.Point(6, 20);
            this.chbBuyerID.Name = "chbBuyerID";
            this.chbBuyerID.Size = new System.Drawing.Size(15, 14);
            this.chbBuyerID.TabIndex = 3;
            this.chbBuyerID.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "구매자 ID :";
            // 
            // txbTitle
            // 
            this.txbTitle.Location = new System.Drawing.Point(297, 17);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(100, 21);
            this.txbTitle.TabIndex = 12;
            // 
            // BuySearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "BuySearchControl";
            this.Size = new System.Drawing.Size(646, 58);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbTitle;
        private System.Windows.Forms.TextBox txbBuyerID;
        private System.Windows.Forms.CheckBox chbBuyerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTitle;
    }
}

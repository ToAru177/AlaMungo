﻿namespace AlaMungo.Customer.Forms
{
    partial class SellForm
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
            this.uscList = new AlaMungo.Customer.Controls.SellListControl();
            this.uscSearch = new AlaMungo.Customer.Controls.SellSearchControl();
            this.SuspendLayout();
            // 
            // uscList
            // 
            this.uscList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscList.Location = new System.Drawing.Point(0, 62);
            this.uscList.Name = "uscList";
            this.uscList.Size = new System.Drawing.Size(800, 388);
            this.uscList.TabIndex = 0;
            // 
            // uscSearch
            // 
            this.uscSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscSearch.Location = new System.Drawing.Point(0, 0);
            this.uscSearch.Name = "uscSearch";
            this.uscSearch.Size = new System.Drawing.Size(800, 62);
            this.uscSearch.TabIndex = 1;
            this.uscSearch.SearchButtonClicked += new System.EventHandler<AlaMungo.Customer.Controls.SellSearchControl.SearchButtonClickedEventArgs>(this.uscSearch_SearchButtonClicked);
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uscList);
            this.Controls.Add(this.uscSearch);
            this.Name = "SellForm";
            this.Text = "SellForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.SellListControl uscList;
        private Controls.SellSearchControl uscSearch;
    }
}
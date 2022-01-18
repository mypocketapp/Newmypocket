
namespace Newmypocket
{
    partial class frmMain
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
            this.btnButton = new System.Windows.Forms.Button();
            this.btnSite = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnInStore = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(282, 56);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(75, 50);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "Update / Add Buttons";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // btnSite
            // 
            this.btnSite.Location = new System.Drawing.Point(481, 56);
            this.btnSite.Name = "btnSite";
            this.btnSite.Size = new System.Drawing.Size(75, 50);
            this.btnSite.TabIndex = 1;
            this.btnSite.Text = "Update / Add Site Info";
            this.btnSite.UseVisualStyleBackColor = true;
            this.btnSite.Click += new System.EventHandler(this.btnSite_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(282, 130);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(75, 50);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Update / Add Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnInStore
            // 
            this.btnInStore.Location = new System.Drawing.Point(481, 130);
            this.btnInStore.Name = "btnInStore";
            this.btnInStore.Size = new System.Drawing.Size(75, 50);
            this.btnInStore.TabIndex = 3;
            this.btnInStore.Text = "Update / Add Products in Store";
            this.btnInStore.UseVisualStyleBackColor = true;
            this.btnInStore.Click += new System.EventHandler(this.btnInStore_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(282, 203);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 50);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check Info";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(481, 203);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 50);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnInStore);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnSite);
            this.Controls.Add(this.btnButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu - My Pocket";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnSite;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnInStore;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnClose;
    }
}
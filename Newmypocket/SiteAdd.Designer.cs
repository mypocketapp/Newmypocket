
namespace Newmypocket
{
    partial class SiteAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCheckName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblURlCheck = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSiteId = new System.Windows.Forms.TextBox();
            this.txtStoreId = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtAffilate = new System.Windows.Forms.TextBox();
            this.txtSiteURL = new System.Windows.Forms.TextBox();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Site";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(578, 69);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Site Id From WordPress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Store Id (button Id)";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(497, 149);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Full Name";
            // 
            // lblCheckName
            // 
            this.lblCheckName.AutoSize = true;
            this.lblCheckName.Location = new System.Drawing.Point(497, 185);
            this.lblCheckName.Name = "lblCheckName";
            this.lblCheckName.Size = new System.Drawing.Size(0, 13);
            this.lblCheckName.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Affilate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "SiteURL";
            // 
            // lblURlCheck
            // 
            this.lblURlCheck.AutoSize = true;
            this.lblURlCheck.Location = new System.Drawing.Point(497, 256);
            this.lblURlCheck.Name = "lblURlCheck";
            this.lblURlCheck.Size = new System.Drawing.Size(0, 13);
            this.lblURlCheck.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(291, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Show Site 0 = Show 1 = Not Show";
            // 
            // txtSiteId
            // 
            this.txtSiteId.Location = new System.Drawing.Point(581, 106);
            this.txtSiteId.Name = "txtSiteId";
            this.txtSiteId.Size = new System.Drawing.Size(100, 20);
            this.txtSiteId.TabIndex = 12;
            this.txtSiteId.TextChanged += new System.EventHandler(this.txtSiteId_TextChanged);
            this.txtSiteId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSiteId_KeyPress);
            // 
            // txtStoreId
            // 
            this.txtStoreId.Location = new System.Drawing.Point(581, 142);
            this.txtStoreId.Name = "txtStoreId";
            this.txtStoreId.Size = new System.Drawing.Size(100, 20);
            this.txtStoreId.TabIndex = 13;
            this.txtStoreId.TextChanged += new System.EventHandler(this.txtStoreId_TextChanged);
            this.txtStoreId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStoreId_KeyPress);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(581, 178);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 14;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // txtAffilate
            // 
            this.txtAffilate.Location = new System.Drawing.Point(581, 213);
            this.txtAffilate.Name = "txtAffilate";
            this.txtAffilate.Size = new System.Drawing.Size(100, 20);
            this.txtAffilate.TabIndex = 15;
            this.txtAffilate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAffilate_KeyPress);
            // 
            // txtSiteURL
            // 
            this.txtSiteURL.Location = new System.Drawing.Point(581, 249);
            this.txtSiteURL.Name = "txtSiteURL";
            this.txtSiteURL.Size = new System.Drawing.Size(100, 20);
            this.txtSiteURL.TabIndex = 16;
            this.txtSiteURL.TextChanged += new System.EventHandler(this.txtSiteURL_TextChanged);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(581, 286);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(100, 20);
            this.txtShow.TabIndex = 17;
            this.txtShow.TextChanged += new System.EventHandler(this.txtShow_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(294, 362);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(500, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(500, 106);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(10, 13);
            this.lblWord.TabIndex = 20;
            this.lblWord.Text = " ";
            // 
            // SiteAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.txtSiteURL);
            this.Controls.Add(this.txtAffilate);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtStoreId);
            this.Controls.Add(this.txtSiteId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblURlCheck);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCheckName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SiteAdd";
            this.Text = "SiteAdd";
            this.Load += new System.EventHandler(this.SiteAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCheckName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblURlCheck;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSiteId;
        private System.Windows.Forms.TextBox txtStoreId;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtAffilate;
        private System.Windows.Forms.TextBox txtSiteURL;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWord;
    }
}
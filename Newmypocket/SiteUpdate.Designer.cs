
namespace Newmypocket
{
    partial class SiteUpdate
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtSiteId = new System.Windows.Forms.TextBox();
            this.txtButtonNumber = new System.Windows.Forms.TextBox();
            this.txtSiteURL = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtAffiate = new System.Windows.Forms.TextBox();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancal = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtButtonName = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAffiate = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Site";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Site Id From WordPress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Store Id (Button No.)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Site URL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Full Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Affiate Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Show Site ( 0 = Show 1 = Not Shown";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(498, 59);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 8;
            // 
            // txtSiteId
            // 
            this.txtSiteId.Location = new System.Drawing.Point(501, 83);
            this.txtSiteId.Name = "txtSiteId";
            this.txtSiteId.ReadOnly = true;
            this.txtSiteId.Size = new System.Drawing.Size(100, 20);
            this.txtSiteId.TabIndex = 9;
            // 
            // txtButtonNumber
            // 
            this.txtButtonNumber.Location = new System.Drawing.Point(501, 114);
            this.txtButtonNumber.Name = "txtButtonNumber";
            this.txtButtonNumber.Size = new System.Drawing.Size(100, 20);
            this.txtButtonNumber.TabIndex = 10;
            this.txtButtonNumber.TextChanged += new System.EventHandler(this.txtButtonNumber_TextChanged);
            this.txtButtonNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtButtonNumber_KeyPress);
            // 
            // txtSiteURL
            // 
            this.txtSiteURL.Location = new System.Drawing.Point(501, 179);
            this.txtSiteURL.Name = "txtSiteURL";
            this.txtSiteURL.Size = new System.Drawing.Size(100, 20);
            this.txtSiteURL.TabIndex = 11;
            this.txtSiteURL.TextChanged += new System.EventHandler(this.txtSiteURL_TextChanged);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(501, 211);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 12;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // txtAffiate
            // 
            this.txtAffiate.Location = new System.Drawing.Point(501, 245);
            this.txtAffiate.Name = "txtAffiate";
            this.txtAffiate.Size = new System.Drawing.Size(100, 20);
            this.txtAffiate.TabIndex = 13;
            this.txtAffiate.TextChanged += new System.EventHandler(this.txtAffiate_TextChanged);
            this.txtAffiate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAffiate_KeyPress);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(501, 279);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(100, 20);
            this.txtShow.TabIndex = 14;
            this.txtShow.TextChanged += new System.EventHandler(this.txtShow_TextChanged);
            this.txtShow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShow_KeyPress);
            this.txtShow.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtShow_KeyUp);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(219, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancal
            // 
            this.btnCancal.Location = new System.Drawing.Point(526, 333);
            this.btnCancal.Name = "btnCancal";
            this.btnCancal.Size = new System.Drawing.Size(75, 23);
            this.btnCancal.TabIndex = 16;
            this.btnCancal.Text = "Cancal";
            this.btnCancal.UseVisualStyleBackColor = true;
            this.btnCancal.Click += new System.EventHandler(this.btnCancal_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(501, 140);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 17;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtButtonName
            // 
            this.txtButtonName.Location = new System.Drawing.Point(237, 143);
            this.txtButtonName.Name = "txtButtonName";
            this.txtButtonName.Size = new System.Drawing.Size(100, 20);
            this.txtButtonName.TabIndex = 18;
            this.txtButtonName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtButtonName_KeyPress);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(640, 179);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(35, 13);
            this.lblUrl.TabIndex = 19;
            this.lblUrl.Text = "label9";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(643, 211);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "label10";
            // 
            // lblAffiate
            // 
            this.lblAffiate.AutoSize = true;
            this.lblAffiate.Location = new System.Drawing.Point(643, 245);
            this.lblAffiate.Name = "lblAffiate";
            this.lblAffiate.Size = new System.Drawing.Size(41, 13);
            this.lblAffiate.TabIndex = 21;
            this.lblAffiate.Text = "label11";
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(643, 278);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(41, 13);
            this.lblShow.TabIndex = 22;
            this.lblShow.Text = "label12";
            // 
            // SiteUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.lblAffiate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtButtonName);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnCancal);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.txtAffiate);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtSiteURL);
            this.Controls.Add(this.txtButtonNumber);
            this.Controls.Add(this.txtSiteId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SiteUpdate";
            this.Text = "SiteUpdate";
            this.Load += new System.EventHandler(this.SiteUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtSiteId;
        private System.Windows.Forms.TextBox txtButtonNumber;
        private System.Windows.Forms.TextBox txtSiteURL;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtAffiate;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancal;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtButtonName;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAffiate;
        private System.Windows.Forms.Label lblShow;
    }
}
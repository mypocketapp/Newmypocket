
namespace Newmypocket
{
    partial class frmSite
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
            this.txtNextId = new System.Windows.Forms.TextBox();
            this.txtCheckName = new System.Windows.Forms.TextBox();
            this.txtNameOutput = new System.Windows.Forms.TextBox();
            this.txtURLOutput = new System.Windows.Forms.TextBox();
            this.txtURLInput = new System.Windows.Forms.TextBox();
            this.txtButtonNo = new System.Windows.Forms.TextBox();
            this.txtButtonName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCheckName = new System.Windows.Forms.Button();
            this.btnCheckUEL = new System.Windows.Forms.Button();
            this.btnCheckHeading = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpdateNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Next ID Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Check Site Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Check URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Check Button Heading";
            // 
            // txtNextId
            // 
            this.txtNextId.Location = new System.Drawing.Point(241, 42);
            this.txtNextId.Name = "txtNextId";
            this.txtNextId.Size = new System.Drawing.Size(100, 20);
            this.txtNextId.TabIndex = 4;
            // 
            // txtCheckName
            // 
            this.txtCheckName.Location = new System.Drawing.Point(241, 70);
            this.txtCheckName.Name = "txtCheckName";
            this.txtCheckName.Size = new System.Drawing.Size(100, 20);
            this.txtCheckName.TabIndex = 5;
            // 
            // txtNameOutput
            // 
            this.txtNameOutput.Location = new System.Drawing.Point(77, 102);
            this.txtNameOutput.Multiline = true;
            this.txtNameOutput.Name = "txtNameOutput";
            this.txtNameOutput.Size = new System.Drawing.Size(622, 59);
            this.txtNameOutput.TabIndex = 6;
            // 
            // txtURLOutput
            // 
            this.txtURLOutput.Location = new System.Drawing.Point(77, 211);
            this.txtURLOutput.Multiline = true;
            this.txtURLOutput.Name = "txtURLOutput";
            this.txtURLOutput.Size = new System.Drawing.Size(622, 46);
            this.txtURLOutput.TabIndex = 7;
            // 
            // txtURLInput
            // 
            this.txtURLInput.Location = new System.Drawing.Point(241, 177);
            this.txtURLInput.Name = "txtURLInput";
            this.txtURLInput.Size = new System.Drawing.Size(100, 20);
            this.txtURLInput.TabIndex = 8;
            // 
            // txtButtonNo
            // 
            this.txtButtonNo.Location = new System.Drawing.Point(241, 270);
            this.txtButtonNo.Name = "txtButtonNo";
            this.txtButtonNo.Size = new System.Drawing.Size(100, 20);
            this.txtButtonNo.TabIndex = 9;
            // 
            // txtButtonName
            // 
            this.txtButtonName.Location = new System.Drawing.Point(370, 270);
            this.txtButtonName.Name = "txtButtonName";
            this.txtButtonName.Size = new System.Drawing.Size(100, 20);
            this.txtButtonName.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(522, 40);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(177, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCheckName
            // 
            this.btnCheckName.Location = new System.Drawing.Point(522, 73);
            this.btnCheckName.Name = "btnCheckName";
            this.btnCheckName.Size = new System.Drawing.Size(177, 23);
            this.btnCheckName.TabIndex = 12;
            this.btnCheckName.Text = "Check Name";
            this.btnCheckName.UseVisualStyleBackColor = true;
            this.btnCheckName.Click += new System.EventHandler(this.btnCheckName_Click);
            // 
            // btnCheckUEL
            // 
            this.btnCheckUEL.Location = new System.Drawing.Point(522, 177);
            this.btnCheckUEL.Name = "btnCheckUEL";
            this.btnCheckUEL.Size = new System.Drawing.Size(177, 23);
            this.btnCheckUEL.TabIndex = 13;
            this.btnCheckUEL.Text = "Check Name";
            this.btnCheckUEL.UseVisualStyleBackColor = true;
            this.btnCheckUEL.Click += new System.EventHandler(this.btnCheckUEL_Click);
            // 
            // btnCheckHeading
            // 
            this.btnCheckHeading.Location = new System.Drawing.Point(522, 273);
            this.btnCheckHeading.Name = "btnCheckHeading";
            this.btnCheckHeading.Size = new System.Drawing.Size(177, 23);
            this.btnCheckHeading.TabIndex = 14;
            this.btnCheckHeading.Text = "Cheak Heading";
            this.btnCheckHeading.UseVisualStyleBackColor = true;
            this.btnCheckHeading.Click += new System.EventHandler(this.btnCheckHeading_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(241, 322);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnup
            // 
            this.btnup.Location = new System.Drawing.Point(370, 322);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(75, 23);
            this.btnup.TabIndex = 16;
            this.btnup.Text = "Update";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(522, 322);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Return";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Site Id to Update";
            // 
            // txtUpdateNo
            // 
            this.txtUpdateNo.Location = new System.Drawing.Point(370, 376);
            this.txtUpdateNo.Name = "txtUpdateNo";
            this.txtUpdateNo.Size = new System.Drawing.Size(36, 20);
            this.txtUpdateNo.TabIndex = 19;
            // 
            // frmSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUpdateNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCheckHeading);
            this.Controls.Add(this.btnCheckUEL);
            this.Controls.Add(this.btnCheckName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtButtonName);
            this.Controls.Add(this.txtButtonNo);
            this.Controls.Add(this.txtURLInput);
            this.Controls.Add(this.txtURLOutput);
            this.Controls.Add(this.txtNameOutput);
            this.Controls.Add(this.txtCheckName);
            this.Controls.Add(this.txtNextId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Update Site Info";
            this.Load += new System.EventHandler(this.frmSite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNextId;
        private System.Windows.Forms.TextBox txtCheckName;
        private System.Windows.Forms.TextBox txtNameOutput;
        private System.Windows.Forms.TextBox txtURLOutput;
        private System.Windows.Forms.TextBox txtURLInput;
        private System.Windows.Forms.TextBox txtButtonNo;
        private System.Windows.Forms.TextBox txtButtonName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCheckName;
        private System.Windows.Forms.Button btnCheckUEL;
        private System.Windows.Forms.Button btnCheckHeading;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUpdateNo;
    }
}

using System;
using System.Windows.Forms;

partial class Form4
{
    private System.ComponentModel.IContainer components = null;
    private Button btnRemoveAward;
    private Button btnAddAward;
    private Button btnConfirm;
    private TextBox txtAwardName;

    private void InitializeComponent()
    {
            this.btnRemoveAward = new System.Windows.Forms.Button();
            this.btnAddAward = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtAwardName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRemoveAward
            // 
            this.btnRemoveAward.Location = new System.Drawing.Point(20, 50);
            this.btnRemoveAward.Name = "btnRemoveAward";
            this.btnRemoveAward.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveAward.TabIndex = 1;
            this.btnRemoveAward.Text = "Remove Award";
            this.btnRemoveAward.UseVisualStyleBackColor = true;
            // 
            // btnAddAward
            // 
            this.btnAddAward.Location = new System.Drawing.Point(20, 90);
            this.btnAddAward.Name = "btnAddAward";
            this.btnAddAward.Size = new System.Drawing.Size(100, 30);
            this.btnAddAward.TabIndex = 2;
            this.btnAddAward.Text = "Add Award";
            this.btnAddAward.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(20, 130);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 30);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtAwardName
            // 
            this.txtAwardName.Location = new System.Drawing.Point(20, 20);
            this.txtAwardName.Name = "txtAwardName";
            this.txtAwardName.Size = new System.Drawing.Size(150, 20);
            this.txtAwardName.TabIndex = 0;
            this.txtAwardName.TextChanged += new System.EventHandler(this.txtAwardName_TextChanged);
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.txtAwardName);
            this.Controls.Add(this.btnRemoveAward);
            this.Controls.Add(this.btnAddAward);
            this.Controls.Add(this.btnConfirm);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }
}

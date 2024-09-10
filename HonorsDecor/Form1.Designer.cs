using System;
using System.Windows.Forms;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private Button btnCreateAward;
    private Button btnAwardOption;

    private void InitializeComponent()
    {
        this.btnCreateAward = new Button();
        this.btnAwardOption = new Button();
        this.SuspendLayout();

        // btnCreateAward
        this.btnCreateAward.Location = new System.Drawing.Point(30, 30);
        this.btnCreateAward.Name = "btnCreateAward";
        this.btnCreateAward.Size = new System.Drawing.Size(120, 30);
        this.btnCreateAward.Text = "Create Award";
        this.btnCreateAward.UseVisualStyleBackColor = true;

        // btnAwardOption
        this.btnAwardOption.Location = new System.Drawing.Point(30, 70);
        this.btnAwardOption.Name = "btnAwardOption";
        this.btnAwardOption.Size = new System.Drawing.Size(120, 30);
        this.btnAwardOption.Text = "Award Option";
        this.btnAwardOption.UseVisualStyleBackColor = true;
        this.btnAwardOption.Click += new System.EventHandler(this.btnAwardOption_Click);

        // Form1
        this.ClientSize = new System.Drawing.Size(200, 150);
        this.Controls.Add(this.btnCreateAward);
        this.Controls.Add(this.btnAwardOption);
        this.Name = "Form1";
        this.Text = "Form1";
        this.ResumeLayout(false);
    }
}

using System;
using System.Windows.Forms;

partial class Form2
{
    private System.ComponentModel.IContainer components = null;
    private Button btnUpdateAwards;

    private void InitializeComponent()
    {
        this.btnUpdateAwards = new Button();
        this.SuspendLayout();

        // btnUpdateAwards
        this.btnUpdateAwards.Location = new System.Drawing.Point(30, 30);
        this.btnUpdateAwards.Name = "btnUpdateAwards";
        this.btnUpdateAwards.Size = new System.Drawing.Size(150, 50);
        this.btnUpdateAwards.Text = "Update Awards & Decorations";
        this.btnUpdateAwards.UseVisualStyleBackColor = true;
        this.btnUpdateAwards.Click += new System.EventHandler(this.btnUpdateAwards_Click);

        // Form2
        this.ClientSize = new System.Drawing.Size(220, 100);
        this.Controls.Add(this.btnUpdateAwards);
        this.Name = "Form2";
        this.Text = "Form2";
        this.ResumeLayout(false);
    }
}

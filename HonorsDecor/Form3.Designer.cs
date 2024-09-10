using System;
using System.Windows.Forms;

partial class Form3
{
    private System.ComponentModel.IContainer components = null;
    private Button btnAFP;
    private Button btnBFP;
    private Button btnBJMP;
    private Button btnCoastguards;
    private Button btnPNP;
    private Button btnAddAward;

    private void InitializeComponent()
    {
        this.btnAFP = new Button();
        this.btnBFP = new Button();
        this.btnBJMP = new Button();
        this.btnCoastguards = new Button();
        this.btnPNP = new Button();
        this.btnAddAward = new Button();
        this.SuspendLayout();

        // Buttons setup
        this.btnAFP.Location = new System.Drawing.Point(20, 20);
        this.btnAFP.Name = "btnAFP";
        this.btnAFP.Size = new System.Drawing.Size(100, 30);
        this.btnAFP.Text = "AFP";
        this.btnAFP.UseVisualStyleBackColor = true;
        this.btnAFP.Click += new System.EventHandler(this.btnAward_Click);

        this.btnBFP.Location = new System.Drawing.Point(20, 60);
        this.btnBFP.Name = "btnBFP";
        this.btnBFP.Size = new System.Drawing.Size(100, 30);
        this.btnBFP.Text = "BFP";
        this.btnBFP.UseVisualStyleBackColor = true;
        this.btnBFP.Click += new System.EventHandler(this.btnAward_Click);

        this.btnBJMP.Location = new System.Drawing.Point(20, 100);
        this.btnBJMP.Name = "btnBJMP";
        this.btnBJMP.Size = new System.Drawing.Size(100, 30);
        this.btnBJMP.Text = "BJMP";
        this.btnBJMP.UseVisualStyleBackColor = true;
        this.btnBJMP.Click += new System.EventHandler(this.btnAward_Click);

        this.btnCoastguards.Location = new System.Drawing.Point(20, 140);
        this.btnCoastguards.Name = "btnCoastguards";
        this.btnCoastguards.Size = new System.Drawing.Size(100, 30);
        this.btnCoastguards.Text = "COASTGUARDS";
        this.btnCoastguards.UseVisualStyleBackColor = true;
        this.btnCoastguards.Click += new System.EventHandler(this.btnAward_Click);

        this.btnPNP.Location = new System.Drawing.Point(20, 180);
        this.btnPNP.Name = "btnPNP";
        this.btnPNP.Size = new System.Drawing.Size(100, 30);
        this.btnPNP.Text = "PNP";
        this.btnPNP.UseVisualStyleBackColor = true;
        this.btnPNP.Click += new System.EventHandler(this.btnAward_Click);

        // Add Award button setup
        this.btnAddAward.Location = new System.Drawing.Point(20, 220); // Adjust location as needed
        this.btnAddAward.Name = "btnAddAward";
        this.btnAddAward.Size = new System.Drawing.Size(100, 30);
        this.btnAddAward.Text = "Add Award";
        this.btnAddAward.UseVisualStyleBackColor = true;
        this.btnAddAward.Click += new System.EventHandler(this.btnAddAward_Click);

        // Form3
        this.ClientSize = new System.Drawing.Size(150, 300); // Adjust size as needed
        this.Controls.Add(this.btnAFP);
        this.Controls.Add(this.btnBFP);
        this.Controls.Add(this.btnBJMP);
        this.Controls.Add(this.btnCoastguards);
        this.Controls.Add(this.btnPNP);
        this.Controls.Add(this.btnAddAward);
        this.Name = "Form3";
        this.Text = "Form3";
        this.ResumeLayout(false);
    }
}

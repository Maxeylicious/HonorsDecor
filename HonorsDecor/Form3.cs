using HonorsDecor;
using System;
using System.Linq;
using System.Windows.Forms;

public partial class Form3 : Form
{
    public Form3()
    {
        InitializeComponent();
    }

    private void btnAward_Click(object sender, EventArgs e)
    {
        Button clickedButton = sender as Button;
        Form4 form4 = new Form4(this, clickedButton.Name);
        form4.Show();
        this.Hide();
    }

    private void btnAddAward_Click(object sender, EventArgs e)
    {
        Form4 form4 = new Form4(this, null); // Pass null as no specific button is being updated
        form4.Show();
        this.Hide();
    }

    public void UpdateButtonName(string buttonName, string newAwardName)
    {
        switch (buttonName)
        {
            case "btnAFP":
                btnAFP.Text = newAwardName;
                break;
            case "btnBFP":
                btnBFP.Text = newAwardName;
                break;
            case "btnBJMP":
                btnBJMP.Text = newAwardName;
                break;
            case "btnCoastguards":
                btnCoastguards.Text = newAwardName;
                break;
            case "btnPNP":
                btnPNP.Text = newAwardName;
                break;
        }
    }
    ERICPOGI123
    public void UpdateAddAwardButton(string newAwardName)
    {
        btnAddAward.Text = newAwardName;
    }

    public void AddButton(string buttonName)
    {
        Button newButton = new Button();
        newButton.Text = buttonName;
        newButton.Name = "btn" + buttonName;
        newButton.Size = new System.Drawing.Size(100, 30);

        // Calculate the location for the new button
        int buttonCount = this.Controls.OfType<Button>().Count();
        newButton.Location = new System.Drawing.Point(20, 20 + (buttonCount * 40)); // Adjust location as needed

        newButton.Click += new System.EventHandler(this.btnAward_Click);
        this.Controls.Add(newButton);
    }

    public void RemoveButton(string buttonName)
    {
        foreach (Control control in this.Controls)
        {
            if (control is Button && control.Text == buttonName)
            {
                this.Controls.Remove(control);
                break;
            }
        }
    }
}

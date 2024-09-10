using System;
using System.Windows.Forms;

public partial class Form4 : Form
{
    private Form3 form3;
    private string buttonName;

    public Form4(Form3 form3, string buttonName)
    {
        InitializeComponent();
        this.form3 = form3;
        this.buttonName = buttonName;
    }

    private void btnConfirm_Click(object sender, EventArgs e)
    {
        // Get the text from the text box
        string newAwardName = txtAwardName.Text;

        // Update the specific button name in Form3
        if (buttonName != null)
        {
            form3.UpdateButtonName(buttonName, newAwardName);
        }
        else
        {
            form3.UpdateAddAwardButton(newAwardName);
        }
        form3.Show();
        this.Hide();
    }

    private void btnAddAward_Click(object sender, EventArgs e)
    {
        // Get the text from the text box
        string newAwardName = txtAwardName.Text;

        // Add a new button to Form3
        form3.AddButton(newAwardName);
        form3.Show();
        this.Hide();
    }

    private void btnRemoveAward_Click(object sender, EventArgs e)
    {
        // Get the text from the text box
        string awardNameToRemove = txtAwardName.Text;

        // Remove the button from Form3
        form3.RemoveButton(awardNameToRemove);
        form3.Show();
        this.Hide();
    }

    private void txtAwardName_TextChanged(object sender, EventArgs e)
    {
        // This can be used to handle text changes if needed
    }

    private void Form4_Load(object sender, EventArgs e)
    {

    }
}

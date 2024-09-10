using HonorsDecor;
using System;
using System.Windows.Forms;

public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
    }

    private void btnUpdateAwards_Click(object sender, EventArgs e)
    {
        // Navigate to Form3
        Form3 form3 = new Form3();
        form3.Show();
        this.Hide();
    }
}

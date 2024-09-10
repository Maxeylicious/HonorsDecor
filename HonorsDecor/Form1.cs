using System;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnAwardOption_Click(object sender, EventArgs e)
    {
        // Navigate to Form2
        // Create and show Form2
        Form2 form2 = new Form2();
        form2.Show();
    }
}

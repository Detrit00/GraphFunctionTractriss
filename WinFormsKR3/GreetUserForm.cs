using System;
using System.Windows.Forms;


namespace WinFormsKR3
{
    public partial class GreetUserForm : Form
    {
        public GreetUserForm()
        {
            InitializeComponent();
        }
        private void close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Windows.Forms;

namespace PCAuto_ShutDown
{
    public partial class NewMessageBox : Form
    {
        public DialogResult dialogResult = DialogResult.None;
        public NewMessageBox()
        {
            InitializeComponent();
        }

        private void NewMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsForAutarization
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.PasswordField.AutoSize = false;
            this.PasswordField.Size = new Size(this.PasswordField.Size.Width, 54);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = PasswordField.Text;

        }
    }
}

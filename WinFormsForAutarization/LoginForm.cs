using System.Data;
using MySql.Data.MySqlClient;

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
            String loginUser = loginField.Text;
            String passUser = PasswordField.Text;

            DtBase db = new DtBase();

            DataTable dtTable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL AND `password`=@uP", db.getConnection());
            sqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            sqlCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = sqlCommand;

            adapter.Fill(dtTable);


            if (dtTable.Rows.Count > 0)
                MessageBox.Show("yes");
            else
                MessageBox.Show("no");


        }
    }
}

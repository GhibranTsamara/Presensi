using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Presensi
{
    public partial class Login : Form
    {
        MySqlConnection conn;

        public Login()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=absensi;Uid=root;Pwd=;");

            txtPassword.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    string roleQuery = "SELECT role FROM users WHERE username = @username";
                    MySqlCommand roleCmd = new MySqlCommand(roleQuery, conn);
                    roleCmd.Parameters.AddWithValue("@username", username);

                    string role = roleCmd.ExecuteScalar() as string;

                    if (role != null)
                        if (role == "administrator")
                    {
                        // Buka tampilan administrator
                        AdministratorForm adminForm = new AdministratorForm(); // Ganti dengan nama form admin
                        adminForm.Show();
                    }
                    else if (role == "operator")
                    {
                        // Buka tampilan operator
                        OperatorForm operatorForm = new OperatorForm(); // Ganti dengan nama form operator
                        operatorForm.Show();
                    }
                    else if (role == "participant")
                    {
                        // Buka tampilan participant
                        ParticipantForm participantForm = new ParticipantForm(); // Ganti dengan nama form participant
                        participantForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Login gagal. Periksa kembali username dan password.");
                }

                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }   
    }
}

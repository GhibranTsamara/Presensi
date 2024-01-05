using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presensi
{

    public partial class ParticipantForm : Form
    {
        MySqlConnection conn;
        public ParticipantForm()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=absensi;Uid=root;Pwd=;");
            DisplayAttendanceData();
        }

        private void DisplayAttendanceData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM attendance"; // Query untuk mengambil data dari tabel attendance
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable attendanceTable = new DataTable();
                adapter.Fill(attendanceTable);

                dataGridViewAttendance.DataSource = attendanceTable; // Menampilkan data di DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Kode yang ingin Anda jalankan saat label diklik
        }

        private void judul_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

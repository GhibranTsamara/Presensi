using Microsoft.VisualBasic.ApplicationServices;
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
using ClosedXML.Excel;



namespace Presensi
{
    public partial class AdministratorForm : Form
    {
        MySqlConnection conn;
        public AdministratorForm()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=absensi;Uid=root;Pwd=;");
            txtUserId.ReadOnly = true;
            txtEventId.ReadOnly = true;
            AddScrolling();
            title.Click += title_Click;
            Deskripsi.Click += Deskripsi_Click;
            label2.Click += label2_Click;
            label3.Click += label3_Click;
        }

        private Panel panel1;

        private void title_Click(object sender, EventArgs e)
        {
            // Logika yang ingin Anda jalankan saat label title diklik
        }
        private void Deskripsi_Click(object sender, EventArgs e)
        {
            // Logika yang ingin Anda jalankan saat label Deskripsi diklik
        }
        private void label2_Click(object sender, EventArgs e)
        {
            // Logika yang ingin Anda jalankan saat label2 diklik
        }
        private void label3_Click(object sender, EventArgs e)
        {
            // Logika yang ingin Anda jalankan saat label3 diklik
        }



        private void AddScrolling()
        {
            panel1 = new Panel();
            panel1.AutoScroll = true;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Size = new System.Drawing.Size(1750, 2000); // Sesuaikan ukuran panel sesuai kebutuhan

            // Pindahkan semua kontrol ke dalam panel
            panel1.Controls.Add(dataGridViewUsers);
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(btnEditUser);
            panel1.Controls.Add(btnDeleteUser);
            // ... (tambahkan kontrol lainnya)

            this.Controls.Add(panel1);
        }


        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            LoadUserList();
            LoadRoles(); // Panggil fungsi untuk mengisi ComboBox dengan roles
            LoadAttendanceList();
            LoadEventList();
        }

        private void LoadRoles()
        {
            try
            {
                conn.Open();
                string rolesQuery = "SELECT DISTINCT role FROM users";
                MySqlCommand rolesCmd = new MySqlCommand(rolesQuery, conn);

                MySqlDataReader reader = rolesCmd.ExecuteReader();
                while (reader.Read())
                {
                    string role = reader.GetString("role");
                    comboBoxRole.Items.Add(role); // Tambahkan role ke ComboBox
                }
                reader.Close();
            }
            catch (MySqlException ex)
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

        private void LoadUserList()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=absensi;Uid=root;Pwd=;"))
                {
                    connection.Open();
                    string userListQuery = "SELECT * FROM users";
                    MySqlCommand userListCmd = new MySqlCommand(userListQuery, conn);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(userListCmd);
                    DataTable userList = new DataTable();
                    adapter.Fill(userList);

                    // Menampilkan data pengguna ke dalam DataGridView
                    dataGridViewUsers.DataSource = userList;

                    conn.Close();
                }
            }
            catch (MySqlException ex)
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

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan baris yang diklik valid
            {
                DataGridViewRow selectedRow = dataGridViewUsers.Rows[e.RowIndex];
                // Ambil nilai dari sel-sel yang diklik
                int userId = Convert.ToInt32(selectedRow.Cells["user_id"].Value);
                string username = selectedRow.Cells["username"].Value.ToString();
                string password = selectedRow.Cells["password"].Value.ToString();
                string role = selectedRow.Cells["role"].Value.ToString();

                // Tampilkan nilai di TextBox dan ComboBox untuk pengeditan
                txtUserId.Text = userId.ToString(); // TextBox untuk menampilkan user_id
                txtUsername.Text = username; // TextBox untuk username
                txtPassword.Text = password; // TextBox untuk password
                comboBoxRole.SelectedItem = role; // ComboBox untuk memilih role
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text; // Assuming txtUsername is the TextBox for the username
            string password = txtPassword.Text; // Assuming txtPassword is the TextBox for the password
            string role = comboBoxRole.SelectedItem.ToString(); // Assuming comboBoxRole is the ComboBox for roles

            try
            {
                conn.Open();
                string addUserQuery = "INSERT INTO users (username, password, role) VALUES (@username, @password, @role)";
                MySqlCommand addUserCmd = new MySqlCommand(addUserQuery, conn);
                addUserCmd.Parameters.AddWithValue("@username", username);
                addUserCmd.Parameters.AddWithValue("@password", password);
                addUserCmd.Parameters.AddWithValue("@role", role);

                int rowsAffected = addUserCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User added successfully.");
                    LoadUserList(); // Reload the user list after adding the new user
                }
                else
                {
                    MessageBox.Show("Failed to add user.");
                }
            }
            catch (MySqlException ex)
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

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            // Mengambil nilai yang diedit dari TextBox dan ComboBox
            int userId = Convert.ToInt32(txtUserId.Text);
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = comboBoxRole.SelectedItem.ToString();

            // Melakukan perubahan ke database (Update query)
            try
            {
                conn.Open();
                string editUserQuery = "UPDATE users SET username = @username, password = @password, role = @role WHERE user_id = @userId";
                MySqlCommand editUserCmd = new MySqlCommand(editUserQuery, conn);
                editUserCmd.Parameters.AddWithValue("@username", username);
                editUserCmd.Parameters.AddWithValue("@password", password);
                editUserCmd.Parameters.AddWithValue("@role", role);
                editUserCmd.Parameters.AddWithValue("@userId", userId);

                int rowsAffected = editUserCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User updated successfully.");
                    LoadUserList(); // Reload the user list after updating
                }
                else
                {
                    MessageBox.Show("Failed to update user.");
                }
            }
            catch (MySqlException ex)
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

        private Label Username;

        private void Username_Click(object sender, EventArgs e)
        {
            // Tambahkan logika yang ingin dijalankan saat label Username diklik
        }

        private void Password_Click(object sender, EventArgs e)
        {
            // Tambahkan logika yang ingin dijalankan saat label Password diklik
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // Mengambil ID pengguna yang akan dihapus
            int userId = Convert.ToInt32(txtUserId.Text);

            try
            {
                conn.Open();
                string deleteUserQuery = "DELETE FROM users WHERE user_id = @userId";
                MySqlCommand deleteUserCmd = new MySqlCommand(deleteUserQuery, conn);
                deleteUserCmd.Parameters.AddWithValue("@userId", userId);

                int rowsAffected = deleteUserCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User deleted successfully.");
                    LoadUserList(); // Reload the user list after deletion
                }
                else
                {
                    MessageBox.Show("Failed to delete user.");
                }
            }
            catch (MySqlException ex)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Membersihkan field username, password, dan combo box role
            txtUsername.Text = "";
            txtPassword.Text = "";
            comboBoxRole.SelectedIndex = -1; // Mengatur pilihan ComboBox ke default (-1)
        }

        private int selectedUserId = -1;
        private int selectedEventId = -1;
        private int selectedAttendanceId = -1;

        private void dateTimePickerAttendance_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRecordAttendance_Click(object sender, EventArgs e)
        {
            if (selectedAttendanceId != -1) // Pastikan ID yang valid
            {
                string statusKehadiran = "sakit"; // Misalnya, ubah status kehadiran ke "sakit"
                DateTime attendanceTime = DateTime.Now; // Waktu kehadiran saat ini

                RecordAttendance(selectedAttendanceId, statusKehadiran, attendanceTime);
            }
            else
            {
                MessageBox.Show("Data kehadiran tidak valid.");
            }
        }

        private int GetSelectedUserId()
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewUsers.SelectedRows[0];
                int userId = Convert.ToInt32(selectedRow.Cells["user_id"].Value);
                return userId;
            }
            return -1; // Nilai default jika tidak ada baris yang dipilih
        }

        private int GetSelectedEventId()
        {
            if (dataGridViewEvents.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewEvents.SelectedRows[0];
                int eventId = Convert.ToInt32(selectedRow.Cells["event_id"].Value);
                return eventId;
            }
            return -1; // Nilai default jika tidak ada baris yang dipilih
        }

        private void RecordAttendance(int attendanceId, string statusKehadiran, DateTime attendanceTime)
        {
            try
            {
                conn.Open();

                string recordAttendanceQuery = "UPDATE attendance SET status_kehadiran = @statusKehadiran, attendance_time = @attendanceTime WHERE attendance_id = @attendanceId";
                MySqlCommand recordAttendanceCmd = new MySqlCommand(recordAttendanceQuery, conn);
                recordAttendanceCmd.Parameters.AddWithValue("@statusKehadiran", statusKehadiran);
                recordAttendanceCmd.Parameters.AddWithValue("@attendanceTime", attendanceTime);
                recordAttendanceCmd.Parameters.AddWithValue("@attendanceId", attendanceId);

                int rowsAffected = recordAttendanceCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Perubahan kehadiran berhasil disimpan untuk attendanceId: " + attendanceId);
                    MessageBox.Show("Perubahan kehadiran berhasil disimpan.");
                    LoadAttendanceList(); // Memuat ulang data setelah perubahan
                }
                else
                {
                    Console.WriteLine("Gagal menyimpan perubahan kehadiran untuk attendanceId: " + attendanceId);
                    MessageBox.Show("Gagal menyimpan perubahan kehadiran.");
                }

                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void LoadAttendanceList()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=absensi;Uid=root;Pwd=;"))
                {
                    connection.Open();
                    string attendanceListQuery = "SELECT * FROM attendance";
                    MySqlCommand attendanceListCmd = new MySqlCommand(attendanceListQuery, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(attendanceListCmd);
                    DataTable attendanceList = new DataTable();
                    adapter.Fill(attendanceList);

                    dataGridViewAttendance.DataSource = attendanceList; // Menampilkan data absensi ke dalam DataGridView

                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridViewAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewAttendance.Rows[e.RowIndex];
                int attendanceId = Convert.ToInt32(selectedRow.Cells["attendance_id"].Value);

                // Periksa apakah nilai attendanceId sudah benar
                if (attendanceId != -1)
                {
                    selectedAttendanceId = attendanceId; // Update nilai selectedAttendanceId
                    btnRecordAttendance.Enabled = true; // Aktivasi tombol rekam kehadiran karena ID valid
                }
                else
                {
                    selectedAttendanceId = -1; // Set ke -1 jika tidak valid
                    btnRecordAttendance.Enabled = false; // Nonaktifkan tombol rekam kehadiran jika ID tidak valid
                }
            }
        }

        private void UpdateSelectedIds(int userId, int eventId)
        {
            // Menyimpan ID yang dipilih untuk rekaman kehadiran
            selectedUserId = userId;
            selectedEventId = eventId;

            // Aktivasi tombol rekam kehadiran jika kedua ID valid
            btnRecordAttendance.Enabled = (selectedUserId != -1 && selectedEventId != -1);
        }

        private void txtEventId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEventName_TextChanged(object sender, EventArgs e)
        {

        }

        private void description_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerStartTimeEvent_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerEndTimeEvent_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            string eventName = txttitle.Text;
            string eventDescription = description.Text;
            DateTime startTime = dateTimePickerStartTimeEvent.Value;
            DateTime endTime = dateTimePickerEndTimeEvent.Value;

            try
            {
                conn.Open();
                string addEventQuery = "INSERT INTO events (title, description, start_time, end_time) VALUES (@title, @description, @startTime, @endTime)";
                MySqlCommand addEventCmd = new MySqlCommand(addEventQuery, conn);
                addEventCmd.Parameters.AddWithValue("@title", eventName);
                addEventCmd.Parameters.AddWithValue("@description", eventDescription);
                addEventCmd.Parameters.AddWithValue("@startTime", startTime);
                addEventCmd.Parameters.AddWithValue("@endTime", endTime);

                int rowsAffected = addEventCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Acara berhasil ditambahkan.");
                    LoadEventList(); // Memuat ulang daftar acara setelah menambahkan acara baru
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan acara.");
                }
            }
            catch (MySqlException ex)
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

        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEventId.Text) && int.TryParse(txtEventId.Text, out int eventId))
            {
                string eventName = txttitle.Text;
                string eventDescription = description.Text;
                DateTime startTime = dateTimePickerStartTimeEvent.Value;
                DateTime endTime = dateTimePickerEndTimeEvent.Value;

                try
                {
                    conn.Open();
                    string editEventQuery = "UPDATE events SET title = @title, description = @description, start_time = @startTime, end_time = @endTime WHERE event_id = @eventId";
                    MySqlCommand editEventCmd = new MySqlCommand(editEventQuery, conn);
                    editEventCmd.Parameters.AddWithValue("@title", eventName);
                    editEventCmd.Parameters.AddWithValue("@description", eventDescription);
                    editEventCmd.Parameters.AddWithValue("@startTime", startTime);
                    editEventCmd.Parameters.AddWithValue("@endTime", endTime);
                    editEventCmd.Parameters.AddWithValue("@eventId", eventId);

                    int rowsAffected = editEventCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Acara berhasil diperbarui.");
                        LoadEventList(); // Memuat ulang daftar acara setelah mengedit acara
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui acara.");
                    }
                }
                catch (MySqlException ex)
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
            else
            {
                MessageBox.Show("ID acara tidak valid.");
            }
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            int eventId;
            if (!string.IsNullOrEmpty(txtEventId.Text) && int.TryParse(txtEventId.Text, out eventId))
            {
                try
                {
                    conn.Open();
                    string deleteEventQuery = "DELETE FROM events WHERE event_id = @eventId";
                    MySqlCommand deleteEventCmd = new MySqlCommand(deleteEventQuery, conn);
                    deleteEventCmd.Parameters.AddWithValue("@eventId", eventId);

                    int rowsAffected = deleteEventCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Acara berhasil dihapus.");
                        LoadEventList(); // Memuat ulang daftar acara setelah menghapus acara
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus acara. ID acara tidak ditemukan.");
                    }
                }
                catch (MySqlException ex)
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
            else
            {
                MessageBox.Show("ID acara tidak valid.");
            }
        }

        private void LoadEventList()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=absensi;Uid=root;Pwd=;"))
                {
                    connection.Open();
                    string eventListQuery = "SELECT * FROM events";
                    MySqlCommand eventListCmd = new MySqlCommand(eventListQuery, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(eventListCmd);
                    DataTable eventList = new DataTable();
                    adapter.Fill(eventList);

                    // Menampilkan data acara ke dalam DataGridView
                    dataGridViewEvents.DataSource = eventList;

                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridViewEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewEvents.Rows[e.RowIndex];
                txtEventId.Text = selectedRow.Cells["event_id"].Value.ToString();
                txttitle.Text = selectedRow.Cells["title"].Value.ToString();
                description.Text = selectedRow.Cells["description"].Value.ToString();
                dateTimePickerStartTimeEvent.Value = Convert.ToDateTime(selectedRow.Cells["start_time"].Value);
                dateTimePickerEndTimeEvent.Value = Convert.ToDateTime(selectedRow.Cells["end_time"].Value);
            }
        }

        private void btnClearEvent_Click(object sender, EventArgs e)
        {
            // Mengosongkan atau mereset input pada formulir
            txttitle.Text = string.Empty;
            description.Text = string.Empty;
            dateTimePickerStartTimeEvent.Value = DateTime.Now; // Ubah sesuai nilai default yang diinginkan
            dateTimePickerEndTimeEvent.Value = DateTime.Now; // Ubah sesuai nilai default yang diinginkan
            txtEventId.Text = string.Empty; // Hanya jika ada field ID yang perlu dihapus
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel((DataTable)dataGridViewAttendance.DataSource);
        }

        private void ExportToExcel(DataTable dataTable)
        {
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Attendance");

                    worksheet.Cell(1, 1).InsertTable(dataTable);

                    var saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveFileDialog.Title = "Save Attendance Report";
                    saveFileDialog.FileName = "AttendanceReport_" + DateTime.Now.ToString("yyyyMMddHHmmss");

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Laporan kehadiran berhasil diekspor.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Tidak ada data untuk diekspor.");
            }
        }

        private void Event_id_Click(object sender, EventArgs e)
        {

        }
    }
}
    
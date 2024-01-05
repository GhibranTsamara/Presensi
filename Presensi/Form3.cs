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
    public partial class OperatorForm : Form
    {
        MySqlConnection conn;
        public OperatorForm()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=absensi;Uid=root;Pwd=;");
            txtEventId.ReadOnly = true;


            dataGridViewEvents.CellContentClick += dataGridViewEvents_CellContentClick;

            btnAddEvent.Click += btnAddEvent_Click;
            btnEditEvent.Click += btnEditEvent_Click;
            btnDeleteEvent.Click += btnDeleteEvent_Click;
            btnClearEvent.Click += btnClearEvent_Click;
        }

        private void OperatorForm_Load(object sender, EventArgs e)
        {
            LoadEventList();
            LoadAttendanceList();
            LoadStatusKehadiran();
            btnAddEvent.Enabled = true;
            btnEditEvent.Enabled = true;
            btnDeleteEvent.Enabled = true;
            btnClearEvent.Enabled = true;
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

        private void Event_id_Click(object sender, EventArgs e)
        {

        }

        private void AttendanceId_Click(object sender, EventArgs e)
        {

        }

        private void txtUserIdAttendance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEventIdAttendance_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerAttendanceTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LoadStatusKehadiran()
        {
            try
            {
                conn.Open();
                string statusQuery = "SELECT DISTINCT status_kehadiran FROM attendance"; // Ambil nilai unik dari kolom status_kehadiran
                MySqlCommand statusCmd = new MySqlCommand(statusQuery, conn);
                MySqlDataReader reader = statusCmd.ExecuteReader();

                while (reader.Read())
                {
                    string status = reader["status_kehadiran"].ToString();
                    comboBoxStatusKehadiran.Items.Add(status); // Tambahkan nilai enum ke ComboBox
                }

                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBoxStatusKehadiran_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridViewAttendance.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridViewAttendance.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewAttendance.Rows[selectedRowIndex];
                int attendanceId = Convert.ToInt32(selectedRow.Cells["attendance_id"].Value);

                string selectedStatus = comboBoxStatusKehadiran.SelectedItem.ToString();

                try
                {
                    conn.Open();
                    string updateStatusQuery = "UPDATE attendance SET status_kehadiran = @status WHERE attendance_id = @attendanceId";
                    MySqlCommand updateStatusCmd = new MySqlCommand(updateStatusQuery, conn);
                    updateStatusCmd.Parameters.AddWithValue("@status", selectedStatus);
                    updateStatusCmd.Parameters.AddWithValue("@attendanceId", attendanceId);

                    int rowsAffected = updateStatusCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Status kehadiran berhasil diperbarui.");
                        LoadAttendanceList(); // Memuat ulang data absensi setelah update
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui status kehadiran.");
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewAttendance.Rows[e.RowIndex];
                int attendanceId = Convert.ToInt32(selectedRow.Cells["attendance_id"].Value);
                int userId = Convert.ToInt32(selectedRow.Cells["user_id"].Value);
                int eventId = Convert.ToInt32(selectedRow.Cells["event_id"].Value);
                DateTime attendanceTime = Convert.ToDateTime(selectedRow.Cells["attendance_time"].Value);
                string statusKehadiran = selectedRow.Cells["status_kehadiran"].Value.ToString();

                // Mengisi nilai dari DataGridView ke dalam TextBox dan kontrol lainnya
                txtAttendanceIdAttendance.Text = attendanceId.ToString();
                txtUserIdAttendance.Text = userId.ToString();
                txtEventIdAttendance.Text = eventId.ToString();
                dateTimePickerAttendanceTime.Value = attendanceTime;
                comboBoxStatusKehadiran.SelectedItem = statusKehadiran;
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

        private void txtAttendanceIdAttendance_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

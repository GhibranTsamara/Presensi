namespace Presensi
{
    partial class ParticipantForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            judul = new Label();
            btnRefresh = new Button();
            dataGridViewAttendance = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).BeginInit();
            SuspendLayout();
            // 
            // judul
            // 
            judul.AutoSize = true;
            judul.Location = new Point(768, 249);
            judul.Name = "judul";
            judul.Size = new Size(324, 41);
            judul.TabIndex = 0;
            judul.Text = "Rekam Kehadiran Anda";
            judul.Click += judul_Click;

            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(444, 341);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(188, 58);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAttendance
            // 
            dataGridViewAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttendance.Location = new Point(444, 449);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.RowHeadersWidth = 102;
            dataGridViewAttendance.Size = new Size(987, 375);
            dataGridViewAttendance.TabIndex = 2;
            dataGridViewAttendance.CellContentClick += dataGridViewAttendance_CellContentClick;
            // 
            // ParticipantForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1739, 938);
            Controls.Add(dataGridViewAttendance);
            Controls.Add(btnRefresh);
            Controls.Add(judul);
            Name = "ParticipantForm";
            Text = "ParticipantForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label judul;
        private Button btnRefresh;
        private DataGridView dataGridViewAttendance;
    }
}
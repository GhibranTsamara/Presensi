namespace Presensi
{
    partial class OperatorForm
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
            btnClearEvent = new Button();
            btnDeleteEvent = new Button();
            btnEditEvent = new Button();
            btnAddEvent = new Button();
            dataGridViewEvents = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            Deskripsi = new Label();
            title = new Label();
            Event_id = new Label();
            dateTimePickerEndTimeEvent = new DateTimePicker();
            dateTimePickerStartTimeEvent = new DateTimePicker();
            description = new RichTextBox();
            txttitle = new TextBox();
            txtEventId = new TextBox();
            txtUserIdAttendance = new TextBox();
            txtAttendanceIdAttendance = new TextBox();
            txtEventIdAttendance = new TextBox();
            dateTimePickerAttendanceTime = new DateTimePicker();
            comboBoxStatusKehadiran = new ComboBox();
            userid = new Label();
            AttendanceId = new Label();
            Eventid = new Label();
            AttendanceTime = new Label();
            StatusKehadiran = new Label();
            dataGridViewAttendance = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).BeginInit();
            SuspendLayout();
            // 
            // btnClearEvent
            // 
            btnClearEvent.Location = new Point(1249, 782);
            btnClearEvent.Name = "btnClearEvent";
            btnClearEvent.Size = new Size(188, 58);
            btnClearEvent.TabIndex = 46;
            btnClearEvent.Text = "Clear";
            btnClearEvent.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEvent
            // 
            btnDeleteEvent.Location = new Point(952, 782);
            btnDeleteEvent.Name = "btnDeleteEvent";
            btnDeleteEvent.Size = new Size(188, 58);
            btnDeleteEvent.TabIndex = 45;
            btnDeleteEvent.Text = "Delete";
            btnDeleteEvent.UseVisualStyleBackColor = true;
            // 
            // btnEditEvent
            // 
            btnEditEvent.Location = new Point(630, 782);
            btnEditEvent.Name = "btnEditEvent";
            btnEditEvent.Size = new Size(188, 58);
            btnEditEvent.TabIndex = 44;
            btnEditEvent.Text = "Edit";
            btnEditEvent.UseVisualStyleBackColor = true;
            // 
            // btnAddEvent
            // 
            btnAddEvent.Location = new Point(309, 782);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(188, 58);
            btnAddEvent.TabIndex = 43;
            btnAddEvent.Text = "Add";
            btnAddEvent.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEvents
            // 
            dataGridViewEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEvents.Location = new Point(166, 492);
            dataGridViewEvents.Name = "dataGridViewEvents";
            dataGridViewEvents.RowHeadersWidth = 102;
            dataGridViewEvents.Size = new Size(1417, 240);
            dataGridViewEvents.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1087, 301);
            label3.Name = "label3";
            label3.Size = new Size(141, 41);
            label3.TabIndex = 41;
            label3.Text = "End Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1087, 161);
            label2.Name = "label2";
            label2.Size = new Size(151, 41);
            label2.TabIndex = 40;
            label2.Text = "Start Time";
            // 
            // Deskripsi
            // 
            Deskripsi.AutoSize = true;
            Deskripsi.Location = new Point(525, 161);
            Deskripsi.Name = "Deskripsi";
            Deskripsi.Size = new Size(138, 41);
            Deskripsi.TabIndex = 39;
            Deskripsi.Text = "Deskripsi";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(159, 301);
            title.Name = "title";
            title.Size = new Size(74, 41);
            title.TabIndex = 38;
            title.Text = "Title";
            // 
            // Event_id
            // 
            Event_id.AutoSize = true;
            Event_id.Location = new Point(159, 161);
            Event_id.Name = "Event_id";
            Event_id.Size = new Size(127, 41);
            Event_id.TabIndex = 37;
            Event_id.Text = "Event_id";
            // 
            // dateTimePickerEndTimeEvent
            // 
            dateTimePickerEndTimeEvent.Location = new Point(1087, 364);
            dateTimePickerEndTimeEvent.Name = "dateTimePickerEndTimeEvent";
            dateTimePickerEndTimeEvent.Size = new Size(500, 47);
            dateTimePickerEndTimeEvent.TabIndex = 36;
            // 
            // dateTimePickerStartTimeEvent
            // 
            dateTimePickerStartTimeEvent.Location = new Point(1087, 220);
            dateTimePickerStartTimeEvent.Name = "dateTimePickerStartTimeEvent";
            dateTimePickerStartTimeEvent.Size = new Size(500, 47);
            dateTimePickerStartTimeEvent.TabIndex = 35;
            // 
            // description
            // 
            description.Location = new Point(525, 220);
            description.Name = "description";
            description.Size = new Size(448, 191);
            description.TabIndex = 34;
            description.Text = "";
            // 
            // txttitle
            // 
            txttitle.Location = new Point(159, 364);
            txttitle.Name = "txttitle";
            txttitle.Size = new Size(250, 47);
            txttitle.TabIndex = 33;
            // 
            // txtEventId
            // 
            txtEventId.Location = new Point(159, 220);
            txtEventId.Name = "txtEventId";
            txtEventId.Size = new Size(250, 47);
            txtEventId.TabIndex = 32;
            // 
            // txtUserIdAttendance
            // 
            txtUserIdAttendance.Location = new Point(201, 1292);
            txtUserIdAttendance.Name = "txtUserIdAttendance";
            txtUserIdAttendance.Size = new Size(250, 47);
            txtUserIdAttendance.TabIndex = 47;
            txtUserIdAttendance.TextChanged += txtUserIdAttendance_TextChanged;
            // 
            // txtAttendanceIdAttendance
            // 
            txtAttendanceIdAttendance.Location = new Point(201, 1137);
            txtAttendanceIdAttendance.Name = "txtAttendanceIdAttendance";
            txtAttendanceIdAttendance.Size = new Size(250, 47);
            txtAttendanceIdAttendance.TabIndex = 48;
            txtAttendanceIdAttendance.TextChanged += txtAttendanceIdAttendance_TextChanged;
            // 
            // txtEventIdAttendance
            // 
            txtEventIdAttendance.Location = new Point(665, 1137);
            txtEventIdAttendance.Name = "txtEventIdAttendance";
            txtEventIdAttendance.Size = new Size(250, 47);
            txtEventIdAttendance.TabIndex = 49;
            txtEventIdAttendance.TextChanged += txtEventIdAttendance_TextChanged;
            // 
            // dateTimePickerAttendanceTime
            // 
            dateTimePickerAttendanceTime.Location = new Point(665, 1292);
            dateTimePickerAttendanceTime.Name = "dateTimePickerAttendanceTime";
            dateTimePickerAttendanceTime.Size = new Size(500, 47);
            dateTimePickerAttendanceTime.TabIndex = 50;
            dateTimePickerAttendanceTime.ValueChanged += dateTimePickerAttendanceTime_ValueChanged;
            // 
            // comboBoxStatusKehadiran
            // 
            comboBoxStatusKehadiran.FormattingEnabled = true;
            comboBoxStatusKehadiran.Location = new Point(1249, 1137);
            comboBoxStatusKehadiran.Name = "comboBoxStatusKehadiran";
            comboBoxStatusKehadiran.Size = new Size(302, 49);
            comboBoxStatusKehadiran.TabIndex = 51;
            comboBoxStatusKehadiran.SelectedIndexChanged += comboBoxStatusKehadiran_SelectedIndexChanged;
            // 
            // userid
            // 
            userid.AutoSize = true;
            userid.Location = new Point(201, 1224);
            userid.Name = "userid";
            userid.Size = new Size(115, 41);
            userid.TabIndex = 52;
            userid.Text = "User_id";
            // 
            // AttendanceId
            // 
            AttendanceId.AutoSize = true;
            AttendanceId.Location = new Point(201, 1069);
            AttendanceId.Name = "AttendanceId";
            AttendanceId.Size = new Size(208, 41);
            AttendanceId.TabIndex = 53;
            AttendanceId.Text = "Attendance_Id";
            AttendanceId.Click += AttendanceId_Click;
            // 
            // Eventid
            // 
            Eventid.AutoSize = true;
            Eventid.Location = new Point(665, 1069);
            Eventid.Name = "Eventid";
            Eventid.Size = new Size(127, 41);
            Eventid.TabIndex = 54;
            Eventid.Text = "Event_id";
            // 
            // AttendanceTime
            // 
            AttendanceTime.AutoSize = true;
            AttendanceTime.Location = new Point(665, 1224);
            AttendanceTime.Name = "AttendanceTime";
            AttendanceTime.Size = new Size(247, 41);
            AttendanceTime.TabIndex = 55;
            AttendanceTime.Text = "Attendance_Time";
            // 
            // StatusKehadiran
            // 
            StatusKehadiran.AutoSize = true;
            StatusKehadiran.Location = new Point(1249, 1069);
            StatusKehadiran.Name = "StatusKehadiran";
            StatusKehadiran.Size = new Size(242, 41);
            StatusKehadiran.TabIndex = 56;
            StatusKehadiran.Text = "Status_Kehadiran";
            // 
            // dataGridViewAttendance
            // 
            dataGridViewAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttendance.Location = new Point(201, 1395);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.RowHeadersWidth = 102;
            dataGridViewAttendance.Size = new Size(1350, 375);
            dataGridViewAttendance.TabIndex = 57;
            dataGridViewAttendance.CellContentClick += dataGridView1_CellContentClick;
            // 
            // OperatorForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1746, 2108);
            Controls.Add(dataGridViewAttendance);
            Controls.Add(StatusKehadiran);
            Controls.Add(AttendanceTime);
            Controls.Add(Eventid);
            Controls.Add(AttendanceId);
            Controls.Add(userid);
            Controls.Add(comboBoxStatusKehadiran);
            Controls.Add(dateTimePickerAttendanceTime);
            Controls.Add(txtEventIdAttendance);
            Controls.Add(txtAttendanceIdAttendance);
            Controls.Add(txtUserIdAttendance);
            Controls.Add(btnClearEvent);
            Controls.Add(btnDeleteEvent);
            Controls.Add(btnEditEvent);
            Controls.Add(btnAddEvent);
            Controls.Add(dataGridViewEvents);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Deskripsi);
            Controls.Add(title);
            Controls.Add(Event_id);
            Controls.Add(dateTimePickerEndTimeEvent);
            Controls.Add(dateTimePickerStartTimeEvent);
            Controls.Add(description);
            Controls.Add(txttitle);
            Controls.Add(txtEventId);
            Name = "OperatorForm";
            Text = "OperatorForm";
            Load += OperatorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClearEvent;
        private Button btnDeleteEvent;
        private Button btnEditEvent;
        private Button btnAddEvent;
        private DataGridView dataGridViewEvents;
        private Label label3;
        private Label label2;
        private Label Deskripsi;
        private Label title;
        private Label Event_id;
        private DateTimePicker dateTimePickerEndTimeEvent;
        private DateTimePicker dateTimePickerStartTimeEvent;
        private RichTextBox description;
        private TextBox txttitle;
        private TextBox txtEventId;
        private TextBox txtUserIdAttendance;
        private TextBox txtAttendanceIdAttendance;
        private TextBox txtEventIdAttendance;
        private DateTimePicker dateTimePickerAttendanceTime;
        private ComboBox comboBoxStatusKehadiran;
        private Label userid;
        private Label AttendanceId;
        private Label Eventid;
        private Label AttendanceTime;
        private Label StatusKehadiran;
        private DataGridView dataGridViewAttendance;
    }
}
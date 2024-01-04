namespace Presensi
{
    partial class AdministratorForm
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
            dataGridViewUsers = new DataGridView();
            btnAddUser = new Button();
            btnEditUser = new Button();
            btnDeleteUser = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            comboBoxRole = new ComboBox();
            Username = new Label();
            Password = new Label();
            Role = new Label();
            txtUserId = new TextBox();
            User_id = new Label();
            btnClearUser = new Button();
            dateTimePickerAttendance = new DateTimePicker();
            btnRecordAttendance = new Button();
            dataGridViewAttendance = new DataGridView();
            txtEventId = new TextBox();
            txttitle = new TextBox();
            description = new RichTextBox();
            dateTimePickerStartTimeEvent = new DateTimePicker();
            dateTimePickerEndTimeEvent = new DateTimePicker();
            Event_id = new Label();
            title = new Label();
            Deskripsi = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridViewEvents = new DataGridView();
            btnAddEvent = new Button();
            btnEditEvent = new Button();
            btnDeleteEvent = new Button();
            btnClearEvent = new Button();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(144, 215);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 102;
            dataGridViewUsers.Size = new Size(1528, 469);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.CellContentClick += dataGridViewUsers_CellContentClick;
            dataGridViewUsers.DoubleClick += AdministratorForm_Load;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(1261, 42);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(188, 58);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(1261, 135);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(188, 58);
            btnEditUser.TabIndex = 2;
            btnEditUser.Text = "Edit";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(1484, 135);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(188, 58);
            btnDeleteUser.TabIndex = 3;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(302, 133);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 47);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(790, 39);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 47);
            txtPassword.TabIndex = 5;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(790, 141);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(300, 49);
            comboBoxRole.TabIndex = 6;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(144, 134);
            Username.Name = "Username";
            Username.Size = new Size(152, 41);
            Username.TabIndex = 7;
            Username.Text = "Username";
            Username.Click += Username_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(632, 42);
            Password.Name = "Password";
            Password.Size = new Size(143, 41);
            Password.TabIndex = 8;
            Password.Text = "Password";
            Password.Click += Password_Click;
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.Location = new Point(632, 148);
            Role.Name = "Role";
            Role.Size = new Size(76, 41);
            Role.TabIndex = 9;
            Role.Text = "Role";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(302, 42);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(300, 47);
            txtUserId.TabIndex = 11;
            // 
            // User_id
            // 
            User_id.AutoSize = true;
            User_id.Location = new Point(144, 42);
            User_id.Name = "User_id";
            User_id.Size = new Size(115, 41);
            User_id.TabIndex = 12;
            User_id.Text = "User_id";
            // 
            // btnClearUser
            // 
            btnClearUser.Location = new Point(1484, 36);
            btnClearUser.Name = "btnClearUser";
            btnClearUser.Size = new Size(188, 58);
            btnClearUser.TabIndex = 13;
            btnClearUser.Text = "Clear";
            btnClearUser.UseVisualStyleBackColor = true;
            btnClearUser.Click += btnClear_Click;
            // 
            // dateTimePickerAttendance
            // 
            dateTimePickerAttendance.Location = new Point(171, 1678);
            dateTimePickerAttendance.Name = "dateTimePickerAttendance";
            dateTimePickerAttendance.Size = new Size(500, 47);
            dateTimePickerAttendance.TabIndex = 14;
            dateTimePickerAttendance.ValueChanged += dateTimePickerAttendance_ValueChanged;
            // 
            // btnRecordAttendance
            // 
            btnRecordAttendance.Location = new Point(750, 1674);
            btnRecordAttendance.Name = "btnRecordAttendance";
            btnRecordAttendance.Size = new Size(255, 51);
            btnRecordAttendance.TabIndex = 15;
            btnRecordAttendance.Text = "Rekam Kehadiran";
            btnRecordAttendance.UseVisualStyleBackColor = true;
            btnRecordAttendance.Click += btnRecordAttendance_Click;
            // 
            // dataGridViewAttendance
            // 
            dataGridViewAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttendance.Location = new Point(171, 1760);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.RowHeadersWidth = 102;
            dataGridViewAttendance.Size = new Size(1417, 197);
            dataGridViewAttendance.TabIndex = 16;
            dataGridViewAttendance.CellContentClick += dataGridViewAttendance_CellContentClick;
            // 
            // txtEventId
            // 
            txtEventId.Location = new Point(164, 881);
            txtEventId.Name = "txtEventId";
            txtEventId.Size = new Size(250, 47);
            txtEventId.TabIndex = 17;
            txtEventId.TextChanged += txtEventId_TextChanged;
            // 
            // txttitle
            // 
            txttitle.Location = new Point(164, 1025);
            txttitle.Name = "txttitle";
            txttitle.Size = new Size(250, 47);
            txttitle.TabIndex = 18;
            txttitle.TextChanged += txtEventName_TextChanged;
            // 
            // description
            // 
            description.Location = new Point(530, 881);
            description.Name = "description";
            description.Size = new Size(448, 191);
            description.TabIndex = 19;
            description.Text = "";
            description.TextChanged += description_TextChanged;
            // 
            // dateTimePickerStartTimeEvent
            // 
            dateTimePickerStartTimeEvent.Location = new Point(1092, 881);
            dateTimePickerStartTimeEvent.Name = "dateTimePickerStartTimeEvent";
            dateTimePickerStartTimeEvent.Size = new Size(500, 47);
            dateTimePickerStartTimeEvent.TabIndex = 20;
            dateTimePickerStartTimeEvent.ValueChanged += dateTimePickerStartTimeEvent_ValueChanged;
            // 
            // dateTimePickerEndTimeEvent
            // 
            dateTimePickerEndTimeEvent.Location = new Point(1092, 1025);
            dateTimePickerEndTimeEvent.Name = "dateTimePickerEndTimeEvent";
            dateTimePickerEndTimeEvent.Size = new Size(500, 47);
            dateTimePickerEndTimeEvent.TabIndex = 21;
            dateTimePickerEndTimeEvent.ValueChanged += dateTimePickerEndTimeEvent_ValueChanged;
            // 
            // Event_id
            // 
            Event_id.AutoSize = true;
            Event_id.Location = new Point(164, 822);
            Event_id.Name = "Event_id";
            Event_id.Size = new Size(127, 41);
            Event_id.TabIndex = 22;
            Event_id.Text = "Event_id";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(164, 962);
            title.Name = "title";
            title.Size = new Size(74, 41);
            title.TabIndex = 23;
            title.Text = "Title";
            // 
            // Deskripsi
            // 
            Deskripsi.AutoSize = true;
            Deskripsi.Location = new Point(530, 822);
            Deskripsi.Name = "Deskripsi";
            Deskripsi.Size = new Size(138, 41);
            Deskripsi.TabIndex = 24;
            Deskripsi.Text = "Deskripsi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1092, 822);
            label2.Name = "label2";
            label2.Size = new Size(151, 41);
            label2.TabIndex = 25;
            label2.Text = "Start Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1092, 962);
            label3.Name = "label3";
            label3.Size = new Size(141, 41);
            label3.TabIndex = 26;
            label3.Text = "End Time";
            // 
            // dataGridViewEvents
            // 
            dataGridViewEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEvents.Location = new Point(171, 1153);
            dataGridViewEvents.Name = "dataGridViewEvents";
            dataGridViewEvents.RowHeadersWidth = 102;
            dataGridViewEvents.Size = new Size(1417, 240);
            dataGridViewEvents.TabIndex = 27;
            dataGridViewEvents.CellContentClick += dataGridViewEvents_CellContentClick;
            // 
            // btnAddEvent
            // 
            btnAddEvent.Location = new Point(314, 1443);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(188, 58);
            btnAddEvent.TabIndex = 28;
            btnAddEvent.Text = "Add";
            btnAddEvent.UseVisualStyleBackColor = true;
            btnAddEvent.Click += btnAddEvent_Click;
            // 
            // btnEditEvent
            // 
            btnEditEvent.Location = new Point(635, 1443);
            btnEditEvent.Name = "btnEditEvent";
            btnEditEvent.Size = new Size(188, 58);
            btnEditEvent.TabIndex = 29;
            btnEditEvent.Text = "Edit";
            btnEditEvent.UseVisualStyleBackColor = true;
            btnEditEvent.Click += btnEditEvent_Click;
            // 
            // btnDeleteEvent
            // 
            btnDeleteEvent.Location = new Point(957, 1443);
            btnDeleteEvent.Name = "btnDeleteEvent";
            btnDeleteEvent.Size = new Size(188, 58);
            btnDeleteEvent.TabIndex = 30;
            btnDeleteEvent.Text = "Delete";
            btnDeleteEvent.UseVisualStyleBackColor = true;
            btnDeleteEvent.Click += btnDeleteEvent_Click;
            // 
            // btnClearEvent
            // 
            btnClearEvent.Location = new Point(1254, 1443);
            btnClearEvent.Name = "btnClearEvent";
            btnClearEvent.Size = new Size(188, 58);
            btnClearEvent.TabIndex = 31;
            btnClearEvent.Text = "Clear";
            btnClearEvent.UseVisualStyleBackColor = true;
            btnClearEvent.Click += btnClearEvent_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(1400, 1674);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(188, 51);
            btnExport.TabIndex = 32;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // AdministratorForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1777, 2108);
            Controls.Add(btnExport);
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
            Controls.Add(dataGridViewAttendance);
            Controls.Add(btnRecordAttendance);
            Controls.Add(dateTimePickerAttendance);
            Controls.Add(btnClearUser);
            Controls.Add(User_id);
            Controls.Add(txtUserId);
            Controls.Add(Role);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(comboBoxRole);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnEditUser);
            Controls.Add(btnAddUser);
            Controls.Add(dataGridViewUsers);
            Name = "AdministratorForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "AdministratorForm";
            Load += AdministratorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private Button btnAddUser;
        private Button btnEditUser;
        private Button btnDeleteUser;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox comboBoxRole;
        private Label Event_id;
        private Label Password;
        private Label Role;
        private TextBox textBox1;
        private TextBox txtUserId;
        private Label User_id;
        private Button btnClearUser;
        private DateTimePicker dateTimePickerAttendance;
        private Button btnRecordAttendance;
        private DataGridView dataGridViewAttendance;
        private TextBox txtEventId;
        private TextBox txttitle;
        private RichTextBox description;
        private DateTimePicker dateTimePickerStartTimeEvent;
        private DateTimePicker dateTimePickerEndTimeEvent;
        private Label title;
        private Label Deskripsi;
        private Label label2;
        private Label label3;
        private DataGridView dataGridViewEvents;
        private Button btnAddEvent;
        private Button btnEditEvent;
        private Button btnDeleteEvent;
        private Button btnClearEvent;
        private Button btnExport;
    }
}
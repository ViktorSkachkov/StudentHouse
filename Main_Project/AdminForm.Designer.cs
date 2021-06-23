namespace Student_House
{
    partial class AdminForm
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
            this.tbRules = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEditRule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbRules = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblRule = new System.Windows.Forms.Label();
            this.tbAddRule = new System.Windows.Forms.TextBox();
            this.tpPendingAccounts = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbBannAccounts = new System.Windows.Forms.TextBox();
            this.btnBann = new System.Windows.Forms.Button();
            this.btnUnbann = new System.Windows.Forms.Button();
            this.lbBanned = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPending = new System.Windows.Forms.ListBox();
            this.btnDeny = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.tpTasks = new System.Windows.Forms.TabPage();
            this.lbSeeTasks = new System.Windows.Forms.ListBox();
            this.btnSeeTasks = new System.Windows.Forms.Button();
            this.cbBuilding = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tpEvents = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEventBuilding = new System.Windows.Forms.ComboBox();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblChooseDay = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.cbEvent = new System.Windows.Forms.ComboBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnRemoveEvent = new System.Windows.Forms.Button();
            this.lbEvents = new System.Windows.Forms.ListBox();
            this.tpComplaints = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btnAnswerAComplaint = new System.Windows.Forms.Button();
            this.btnClearComp = new System.Windows.Forms.Button();
            this.btnRemoveComp = new System.Windows.Forms.Button();
            this.lbComp = new System.Windows.Forms.ListBox();
            this.tpSendMessages = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSendToAllStudentsFromBuilding = new System.Windows.Forms.Button();
            this.tbSendToSelected = new System.Windows.Forms.TextBox();
            this.btnSendMessageToSelected = new System.Windows.Forms.Button();
            this.lbShowStudentsFromSameBuilding = new System.Windows.Forms.ListBox();
            this.btnShowBuildingStudents = new System.Windows.Forms.Button();
            this.lblSelectBuilding = new System.Windows.Forms.Label();
            this.cbMessageToBuilding = new System.Windows.Forms.ComboBox();
            this.tpAddBuilding = new System.Windows.Forms.TabPage();
            this.btnAddBuilding = new System.Windows.Forms.Button();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCapacity = new System.Windows.Forms.TextBox();
            this.tbBuildingName = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblLogOutAdmin = new System.Windows.Forms.Label();
            this.tbRules.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpPendingAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tpTasks.SuspendLayout();
            this.tpEvents.SuspendLayout();
            this.tpComplaints.SuspendLayout();
            this.tpSendMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpAddBuilding.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRules
            // 
            this.tbRules.Controls.Add(this.tabPage1);
            this.tbRules.Controls.Add(this.tpPendingAccounts);
            this.tbRules.Controls.Add(this.tpTasks);
            this.tbRules.Controls.Add(this.tpEvents);
            this.tbRules.Controls.Add(this.tpComplaints);
            this.tbRules.Controls.Add(this.tpSendMessages);
            this.tbRules.Controls.Add(this.tpAddBuilding);
            this.tbRules.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRules.Location = new System.Drawing.Point(16, 52);
            this.tbRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRules.Name = "tbRules";
            this.tbRules.SelectedIndex = 0;
            this.tbRules.Size = new System.Drawing.Size(859, 490);
            this.tbRules.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbEditRule);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.btnRemove);
            this.tabPage1.Controls.Add(this.lbRules);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.lblRule);
            this.tabPage1.Controls.Add(this.tbAddRule);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(851, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rules";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "The Student House rules:";
            // 
            // tbEditRule
            // 
            this.tbEditRule.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEditRule.Location = new System.Drawing.Point(17, 239);
            this.tbEditRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEditRule.Multiline = true;
            this.tbEditRule.Name = "tbEditRule";
            this.tbEditRule.Size = new System.Drawing.Size(337, 77);
            this.tbEditRule.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select a rule from the listbox \r\nto edit:\r\n";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(104, 320);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(165, 59);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(188, 128);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(166, 57);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbRules
            // 
            this.lbRules.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRules.FormattingEnabled = true;
            this.lbRules.HorizontalScrollbar = true;
            this.lbRules.ItemHeight = 21;
            this.lbRules.Location = new System.Drawing.Point(384, 49);
            this.lbRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(456, 382);
            this.lbRules.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(16, 128);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(166, 57);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule.Location = new System.Drawing.Point(13, 24);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(139, 21);
            this.lblRule.TabIndex = 2;
            this.lblRule.Text = "Write a new rule:";
            // 
            // tbAddRule
            // 
            this.tbAddRule.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddRule.Location = new System.Drawing.Point(16, 47);
            this.tbAddRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddRule.Multiline = true;
            this.tbAddRule.Name = "tbAddRule";
            this.tbAddRule.Size = new System.Drawing.Size(338, 77);
            this.tbAddRule.TabIndex = 1;
            // 
            // tpPendingAccounts
            // 
            this.tpPendingAccounts.BackColor = System.Drawing.Color.LightGray;
            this.tpPendingAccounts.Controls.Add(this.btnDelete);
            this.tpPendingAccounts.Controls.Add(this.pictureBox2);
            this.tpPendingAccounts.Controls.Add(this.tbBannAccounts);
            this.tpPendingAccounts.Controls.Add(this.btnBann);
            this.tpPendingAccounts.Controls.Add(this.btnUnbann);
            this.tpPendingAccounts.Controls.Add(this.lbBanned);
            this.tpPendingAccounts.Controls.Add(this.label5);
            this.tpPendingAccounts.Controls.Add(this.label3);
            this.tpPendingAccounts.Controls.Add(this.lbPending);
            this.tpPendingAccounts.Controls.Add(this.btnDeny);
            this.tpPendingAccounts.Controls.Add(this.btnApprove);
            this.tpPendingAccounts.Location = new System.Drawing.Point(4, 25);
            this.tpPendingAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPendingAccounts.Name = "tpPendingAccounts";
            this.tpPendingAccounts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPendingAccounts.Size = new System.Drawing.Size(851, 461);
            this.tpPendingAccounts.TabIndex = 1;
            this.tpPendingAccounts.Text = "Pending Accounts";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(638, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 39);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Student_House.Properties.Resources.Logo2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(320, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 224);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // tbBannAccounts
            // 
            this.tbBannAccounts.Location = new System.Drawing.Point(716, 29);
            this.tbBannAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBannAccounts.Name = "tbBannAccounts";
            this.tbBannAccounts.Size = new System.Drawing.Size(111, 23);
            this.tbBannAccounts.TabIndex = 22;
            // 
            // btnBann
            // 
            this.btnBann.BackColor = System.Drawing.Color.LightGray;
            this.btnBann.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBann.Location = new System.Drawing.Point(550, 77);
            this.btnBann.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBann.Name = "btnBann";
            this.btnBann.Size = new System.Drawing.Size(82, 39);
            this.btnBann.TabIndex = 21;
            this.btnBann.Text = "Ban";
            this.btnBann.UseVisualStyleBackColor = false;
            this.btnBann.Click += new System.EventHandler(this.btnBann_Click);
            // 
            // btnUnbann
            // 
            this.btnUnbann.BackColor = System.Drawing.Color.LightGray;
            this.btnUnbann.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnbann.Location = new System.Drawing.Point(728, 77);
            this.btnUnbann.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUnbann.Name = "btnUnbann";
            this.btnUnbann.Size = new System.Drawing.Size(99, 39);
            this.btnUnbann.TabIndex = 19;
            this.btnUnbann.Text = "Unban";
            this.btnUnbann.UseVisualStyleBackColor = false;
            this.btnUnbann.Click += new System.EventHandler(this.btnUnbann_Click);
            // 
            // lbBanned
            // 
            this.lbBanned.FormattingEnabled = true;
            this.lbBanned.HorizontalScrollbar = true;
            this.lbBanned.ItemHeight = 16;
            this.lbBanned.Location = new System.Drawing.Point(550, 120);
            this.lbBanned.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBanned.Name = "lbBanned";
            this.lbBanned.Size = new System.Drawing.Size(277, 324);
            this.lbBanned.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(546, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Student number:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Accounts waiting approval:";
            // 
            // lbPending
            // 
            this.lbPending.FormattingEnabled = true;
            this.lbPending.HorizontalScrollbar = true;
            this.lbPending.ItemHeight = 16;
            this.lbPending.Location = new System.Drawing.Point(37, 120);
            this.lbPending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbPending.Name = "lbPending";
            this.lbPending.Size = new System.Drawing.Size(277, 324);
            this.lbPending.TabIndex = 13;
            // 
            // btnDeny
            // 
            this.btnDeny.BackColor = System.Drawing.Color.LightGray;
            this.btnDeny.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeny.Location = new System.Drawing.Point(223, 77);
            this.btnDeny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(91, 39);
            this.btnDeny.TabIndex = 16;
            this.btnDeny.Text = "Deny";
            this.btnDeny.UseVisualStyleBackColor = false;
            this.btnDeny.Click += new System.EventHandler(this.btnDenied_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.LightGray;
            this.btnApprove.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(37, 77);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(103, 39);
            this.btnApprove.TabIndex = 15;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // tpTasks
            // 
            this.tpTasks.BackColor = System.Drawing.Color.LightGray;
            this.tpTasks.Controls.Add(this.lbSeeTasks);
            this.tpTasks.Controls.Add(this.btnSeeTasks);
            this.tpTasks.Controls.Add(this.cbBuilding);
            this.tpTasks.Controls.Add(this.label6);
            this.tpTasks.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpTasks.Location = new System.Drawing.Point(4, 25);
            this.tpTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTasks.Name = "tpTasks";
            this.tpTasks.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTasks.Size = new System.Drawing.Size(851, 461);
            this.tpTasks.TabIndex = 2;
            this.tpTasks.Text = "Tasks";
            // 
            // lbSeeTasks
            // 
            this.lbSeeTasks.FormattingEnabled = true;
            this.lbSeeTasks.HorizontalScrollbar = true;
            this.lbSeeTasks.ItemHeight = 16;
            this.lbSeeTasks.Location = new System.Drawing.Point(226, 24);
            this.lbSeeTasks.Name = "lbSeeTasks";
            this.lbSeeTasks.Size = new System.Drawing.Size(596, 276);
            this.lbSeeTasks.TabIndex = 12;
            // 
            // btnSeeTasks
            // 
            this.btnSeeTasks.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeTasks.Location = new System.Drawing.Point(30, 116);
            this.btnSeeTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeeTasks.Name = "btnSeeTasks";
            this.btnSeeTasks.Size = new System.Drawing.Size(161, 78);
            this.btnSeeTasks.TabIndex = 11;
            this.btnSeeTasks.Text = "See tasks";
            this.btnSeeTasks.UseVisualStyleBackColor = true;
            this.btnSeeTasks.Click += new System.EventHandler(this.btnSeeTasks_Click);
            // 
            // cbBuilding
            // 
            this.cbBuilding.FormattingEnabled = true;
            this.cbBuilding.Items.AddRange(new object[] {
            "B1",
            "B2",
            "B3",
            "B4"});
            this.cbBuilding.Location = new System.Drawing.Point(30, 60);
            this.cbBuilding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBuilding.Name = "cbBuilding";
            this.cbBuilding.Size = new System.Drawing.Size(161, 24);
            this.cbBuilding.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Select a building:";
            // 
            // tpEvents
            // 
            this.tpEvents.BackColor = System.Drawing.Color.LightGray;
            this.tpEvents.Controls.Add(this.label8);
            this.tpEvents.Controls.Add(this.cbEventBuilding);
            this.tpEvents.Controls.Add(this.cbTime);
            this.tpEvents.Controls.Add(this.cbDay);
            this.tpEvents.Controls.Add(this.label7);
            this.tpEvents.Controls.Add(this.lblChooseDay);
            this.tpEvents.Controls.Add(this.lblEvent);
            this.tpEvents.Controls.Add(this.cbEvent);
            this.tpEvents.Controls.Add(this.btnAddEvent);
            this.tpEvents.Controls.Add(this.btnRemoveEvent);
            this.tpEvents.Controls.Add(this.lbEvents);
            this.tpEvents.Location = new System.Drawing.Point(4, 25);
            this.tpEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpEvents.Size = new System.Drawing.Size(851, 461);
            this.tpEvents.TabIndex = 3;
            this.tpEvents.Text = "Events";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(561, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Choose a building:";
            // 
            // cbEventBuilding
            // 
            this.cbEventBuilding.FormattingEnabled = true;
            this.cbEventBuilding.Location = new System.Drawing.Point(565, 201);
            this.cbEventBuilding.Name = "cbEventBuilding";
            this.cbEventBuilding.Size = new System.Drawing.Size(121, 24);
            this.cbEventBuilding.TabIndex = 20;
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.cbTime.Location = new System.Drawing.Point(565, 123);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(121, 24);
            this.cbTime.TabIndex = 19;
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(565, 50);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(121, 24);
            this.cbDay.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(561, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Choose a time:";
            // 
            // lblChooseDay
            // 
            this.lblChooseDay.AutoSize = true;
            this.lblChooseDay.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseDay.Location = new System.Drawing.Point(561, 25);
            this.lblChooseDay.Name = "lblChooseDay";
            this.lblChooseDay.Size = new System.Drawing.Size(115, 21);
            this.lblChooseDay.TabIndex = 16;
            this.lblChooseDay.Text = "Choose a day:";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.Location = new System.Drawing.Point(561, 257);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(139, 21);
            this.lblEvent.TabIndex = 15;
            this.lblEvent.Text = "Choose an event:";
            // 
            // cbEvent
            // 
            this.cbEvent.FormattingEnabled = true;
            this.cbEvent.Items.AddRange(new object[] {
            "Small Group Gathering",
            "Small Party",
            "Friend / Parents coming over for a few day"});
            this.cbEvent.Location = new System.Drawing.Point(565, 280);
            this.cbEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(179, 24);
            this.cbEvent.TabIndex = 14;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.Location = new System.Drawing.Point(565, 363);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(124, 66);
            this.btnAddEvent.TabIndex = 2;
            this.btnAddEvent.Text = "Add event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnRemoveEvent
            // 
            this.btnRemoveEvent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEvent.Location = new System.Drawing.Point(695, 363);
            this.btnRemoveEvent.Name = "btnRemoveEvent";
            this.btnRemoveEvent.Size = new System.Drawing.Size(124, 66);
            this.btnRemoveEvent.TabIndex = 1;
            this.btnRemoveEvent.Text = "Remove event";
            this.btnRemoveEvent.UseVisualStyleBackColor = true;
            this.btnRemoveEvent.Click += new System.EventHandler(this.btnRemoveEvent_Click);
            // 
            // lbEvents
            // 
            this.lbEvents.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.HorizontalScrollbar = true;
            this.lbEvents.ItemHeight = 16;
            this.lbEvents.Location = new System.Drawing.Point(19, 25);
            this.lbEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(537, 404);
            this.lbEvents.TabIndex = 0;
            this.lbEvents.SelectedIndexChanged += new System.EventHandler(this.lbEvents_SelectedIndexChanged);
            // 
            // tpComplaints
            // 
            this.tpComplaints.BackColor = System.Drawing.Color.LightGray;
            this.tpComplaints.Controls.Add(this.label4);
            this.tpComplaints.Controls.Add(this.lblAnswer);
            this.tpComplaints.Controls.Add(this.tbMessage);
            this.tpComplaints.Controls.Add(this.btnAnswerAComplaint);
            this.tpComplaints.Controls.Add(this.btnClearComp);
            this.tpComplaints.Controls.Add(this.btnRemoveComp);
            this.tpComplaints.Controls.Add(this.lbComp);
            this.tpComplaints.Location = new System.Drawing.Point(4, 25);
            this.tpComplaints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpComplaints.Name = "tpComplaints";
            this.tpComplaints.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpComplaints.Size = new System.Drawing.Size(851, 461);
            this.tpComplaints.TabIndex = 4;
            this.tpComplaints.Text = "Complaints";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Write an answer to the selected complaint:\r\n";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(22, 25);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(231, 21);
            this.lblAnswer.TabIndex = 6;
            this.lblAnswer.Text = "Select a complaint to answer:\r\n";
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessage.Location = new System.Drawing.Point(488, 48);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(322, 276);
            this.tbMessage.TabIndex = 5;
            // 
            // btnAnswerAComplaint
            // 
            this.btnAnswerAComplaint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerAComplaint.Location = new System.Drawing.Point(488, 339);
            this.btnAnswerAComplaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnswerAComplaint.Name = "btnAnswerAComplaint";
            this.btnAnswerAComplaint.Size = new System.Drawing.Size(181, 59);
            this.btnAnswerAComplaint.TabIndex = 4;
            this.btnAnswerAComplaint.Text = "Answer a complaint";
            this.btnAnswerAComplaint.UseVisualStyleBackColor = true;
            this.btnAnswerAComplaint.Click += new System.EventHandler(this.btnAnswerAComplaint_Click);
            // 
            // btnClearComp
            // 
            this.btnClearComp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearComp.Location = new System.Drawing.Point(288, 339);
            this.btnClearComp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearComp.Name = "btnClearComp";
            this.btnClearComp.Size = new System.Drawing.Size(137, 59);
            this.btnClearComp.TabIndex = 3;
            this.btnClearComp.Text = "Clear";
            this.btnClearComp.UseVisualStyleBackColor = true;
            this.btnClearComp.Click += new System.EventHandler(this.btnClearComp_Click);
            // 
            // btnRemoveComp
            // 
            this.btnRemoveComp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveComp.Location = new System.Drawing.Point(26, 339);
            this.btnRemoveComp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveComp.Name = "btnRemoveComp";
            this.btnRemoveComp.Size = new System.Drawing.Size(137, 59);
            this.btnRemoveComp.TabIndex = 2;
            this.btnRemoveComp.Text = "Remove";
            this.btnRemoveComp.UseVisualStyleBackColor = true;
            this.btnRemoveComp.Click += new System.EventHandler(this.btnRemoveComp_Click);
            // 
            // lbComp
            // 
            this.lbComp.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComp.FormattingEnabled = true;
            this.lbComp.HorizontalScrollbar = true;
            this.lbComp.ItemHeight = 21;
            this.lbComp.Location = new System.Drawing.Point(26, 47);
            this.lbComp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbComp.Name = "lbComp";
            this.lbComp.Size = new System.Drawing.Size(399, 277);
            this.lbComp.TabIndex = 0;
            // 
            // tpSendMessages
            // 
            this.tpSendMessages.BackColor = System.Drawing.Color.LightGray;
            this.tpSendMessages.Controls.Add(this.pictureBox1);
            this.tpSendMessages.Controls.Add(this.btnSendToAllStudentsFromBuilding);
            this.tpSendMessages.Controls.Add(this.tbSendToSelected);
            this.tpSendMessages.Controls.Add(this.btnSendMessageToSelected);
            this.tpSendMessages.Controls.Add(this.lbShowStudentsFromSameBuilding);
            this.tpSendMessages.Controls.Add(this.btnShowBuildingStudents);
            this.tpSendMessages.Controls.Add(this.lblSelectBuilding);
            this.tpSendMessages.Controls.Add(this.cbMessageToBuilding);
            this.tpSendMessages.Location = new System.Drawing.Point(4, 25);
            this.tpSendMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpSendMessages.Name = "tpSendMessages";
            this.tpSendMessages.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpSendMessages.Size = new System.Drawing.Size(851, 461);
            this.tpSendMessages.TabIndex = 5;
            this.tpSendMessages.Text = "Send Messages";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Student_House.Properties.Resources.Logo2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(617, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 224);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnSendToAllStudentsFromBuilding
            // 
            this.btnSendToAllStudentsFromBuilding.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendToAllStudentsFromBuilding.Location = new System.Drawing.Point(368, 339);
            this.btnSendToAllStudentsFromBuilding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendToAllStudentsFromBuilding.Name = "btnSendToAllStudentsFromBuilding";
            this.btnSendToAllStudentsFromBuilding.Size = new System.Drawing.Size(237, 96);
            this.btnSendToAllStudentsFromBuilding.TabIndex = 6;
            this.btnSendToAllStudentsFromBuilding.Text = "Send message to all students from selected building";
            this.btnSendToAllStudentsFromBuilding.UseVisualStyleBackColor = true;
            this.btnSendToAllStudentsFromBuilding.Click += new System.EventHandler(this.btnSendToAllStudentsFromBuilding_Click);
            // 
            // tbSendToSelected
            // 
            this.tbSendToSelected.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSendToSelected.Location = new System.Drawing.Point(368, 95);
            this.tbSendToSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSendToSelected.Multiline = true;
            this.tbSendToSelected.Name = "tbSendToSelected";
            this.tbSendToSelected.Size = new System.Drawing.Size(311, 104);
            this.tbSendToSelected.TabIndex = 5;
            this.tbSendToSelected.Text = "Write a message";
            // 
            // btnSendMessageToSelected
            // 
            this.btnSendMessageToSelected.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMessageToSelected.Location = new System.Drawing.Point(368, 211);
            this.btnSendMessageToSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendMessageToSelected.Name = "btnSendMessageToSelected";
            this.btnSendMessageToSelected.Size = new System.Drawing.Size(237, 96);
            this.btnSendMessageToSelected.TabIndex = 4;
            this.btnSendMessageToSelected.Text = "Send message to selected student";
            this.btnSendMessageToSelected.UseVisualStyleBackColor = true;
            this.btnSendMessageToSelected.Click += new System.EventHandler(this.btnSendMessageToSelected_Click);
            // 
            // lbShowStudentsFromSameBuilding
            // 
            this.lbShowStudentsFromSameBuilding.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowStudentsFromSameBuilding.FormattingEnabled = true;
            this.lbShowStudentsFromSameBuilding.HorizontalScrollbar = true;
            this.lbShowStudentsFromSameBuilding.ItemHeight = 21;
            this.lbShowStudentsFromSameBuilding.Location = new System.Drawing.Point(35, 95);
            this.lbShowStudentsFromSameBuilding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbShowStudentsFromSameBuilding.Name = "lbShowStudentsFromSameBuilding";
            this.lbShowStudentsFromSameBuilding.Size = new System.Drawing.Size(311, 340);
            this.lbShowStudentsFromSameBuilding.TabIndex = 3;
            // 
            // btnShowBuildingStudents
            // 
            this.btnShowBuildingStudents.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBuildingStudents.Location = new System.Drawing.Point(368, 18);
            this.btnShowBuildingStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowBuildingStudents.Name = "btnShowBuildingStudents";
            this.btnShowBuildingStudents.Size = new System.Drawing.Size(237, 69);
            this.btnShowBuildingStudents.TabIndex = 2;
            this.btnShowBuildingStudents.Text = "Show all the students in the building";
            this.btnShowBuildingStudents.UseVisualStyleBackColor = true;
            this.btnShowBuildingStudents.Click += new System.EventHandler(this.btnShowBuildingStudents_Click);
            // 
            // lblSelectBuilding
            // 
            this.lblSelectBuilding.AutoSize = true;
            this.lblSelectBuilding.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectBuilding.Location = new System.Drawing.Point(31, 43);
            this.lblSelectBuilding.Name = "lblSelectBuilding";
            this.lblSelectBuilding.Size = new System.Drawing.Size(137, 21);
            this.lblSelectBuilding.TabIndex = 1;
            this.lblSelectBuilding.Text = "Select a building:";
            // 
            // cbMessageToBuilding
            // 
            this.cbMessageToBuilding.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMessageToBuilding.FormattingEnabled = true;
            this.cbMessageToBuilding.Location = new System.Drawing.Point(267, 44);
            this.cbMessageToBuilding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMessageToBuilding.Name = "cbMessageToBuilding";
            this.cbMessageToBuilding.Size = new System.Drawing.Size(79, 24);
            this.cbMessageToBuilding.TabIndex = 0;
            this.cbMessageToBuilding.SelectedIndexChanged += new System.EventHandler(this.cbMessageToBuilding_SelectedIndexChanged);
            // 
            // tpAddBuilding
            // 
            this.tpAddBuilding.BackColor = System.Drawing.Color.LightGray;
            this.tpAddBuilding.Controls.Add(this.btnAddBuilding);
            this.tpAddBuilding.Controls.Add(this.lblCapacity);
            this.tpAddBuilding.Controls.Add(this.label9);
            this.tpAddBuilding.Controls.Add(this.tbCapacity);
            this.tpAddBuilding.Controls.Add(this.tbBuildingName);
            this.tpAddBuilding.Location = new System.Drawing.Point(4, 25);
            this.tpAddBuilding.Name = "tpAddBuilding";
            this.tpAddBuilding.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddBuilding.Size = new System.Drawing.Size(851, 461);
            this.tpAddBuilding.TabIndex = 6;
            this.tpAddBuilding.Text = "Add Building";
            // 
            // btnAddBuilding
            // 
            this.btnAddBuilding.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBuilding.Location = new System.Drawing.Point(30, 176);
            this.btnAddBuilding.Name = "btnAddBuilding";
            this.btnAddBuilding.Size = new System.Drawing.Size(206, 69);
            this.btnAddBuilding.TabIndex = 4;
            this.btnAddBuilding.Text = "Add Building";
            this.btnAddBuilding.UseVisualStyleBackColor = true;
            this.btnAddBuilding.Click += new System.EventHandler(this.btnAddBuilding_Click);
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(26, 97);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(79, 21);
            this.lblCapacity.TabIndex = 3;
            this.lblCapacity.Text = "Capacity:";
            this.lblCapacity.Click += new System.EventHandler(this.lblCapacity_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Name of the building:";
            // 
            // tbCapacity
            // 
            this.tbCapacity.Location = new System.Drawing.Point(30, 130);
            this.tbCapacity.Name = "tbCapacity";
            this.tbCapacity.Size = new System.Drawing.Size(150, 23);
            this.tbCapacity.TabIndex = 1;
            // 
            // tbBuildingName
            // 
            this.tbBuildingName.Location = new System.Drawing.Point(30, 57);
            this.tbBuildingName.Name = "tbBuildingName";
            this.tbBuildingName.Size = new System.Drawing.Size(150, 23);
            this.tbBuildingName.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(16, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(92, 24);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblLogOutAdmin
            // 
            this.lblLogOutAdmin.AutoSize = true;
            this.lblLogOutAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOutAdmin.ForeColor = System.Drawing.Color.Black;
            this.lblLogOutAdmin.Location = new System.Drawing.Point(764, 21);
            this.lblLogOutAdmin.Name = "lblLogOutAdmin";
            this.lblLogOutAdmin.Size = new System.Drawing.Size(107, 29);
            this.lblLogOutAdmin.TabIndex = 11;
            this.lblLogOutAdmin.Text = "Log out ";
            this.lblLogOutAdmin.Click += new System.EventHandler(this.lblLogOutAdmin_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 553);
            this.Controls.Add(this.lblLogOutAdmin);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.tbRules);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tbRules.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tpPendingAccounts.ResumeLayout(false);
            this.tpPendingAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tpTasks.ResumeLayout(false);
            this.tpTasks.PerformLayout();
            this.tpEvents.ResumeLayout(false);
            this.tpEvents.PerformLayout();
            this.tpComplaints.ResumeLayout(false);
            this.tpComplaints.PerformLayout();
            this.tpSendMessages.ResumeLayout(false);
            this.tpSendMessages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpAddBuilding.ResumeLayout(false);
            this.tpAddBuilding.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tbRules;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpPendingAccounts;
        private System.Windows.Forms.Label lblRule;
        private System.Windows.Forms.TextBox tbAddRule;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbRules;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbEditRule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabPage tpTasks;
        private System.Windows.Forms.TabPage tpEvents;
        private System.Windows.Forms.ListBox lbEvents;
        private System.Windows.Forms.TabPage tpComplaints;
        private System.Windows.Forms.Button btnClearComp;
        private System.Windows.Forms.Button btnRemoveComp;
        private System.Windows.Forms.ListBox lbComp;
        private System.Windows.Forms.ComboBox cbBuilding;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSeeTasks;
        private System.Windows.Forms.Button btnAnswerAComplaint;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TabPage tpSendMessages;
        private System.Windows.Forms.ListBox lbShowStudentsFromSameBuilding;
        private System.Windows.Forms.Button btnShowBuildingStudents;
        private System.Windows.Forms.Label lblSelectBuilding;
        private System.Windows.Forms.ComboBox cbMessageToBuilding;
        private System.Windows.Forms.TextBox tbSendToSelected;
        private System.Windows.Forms.Button btnSendMessageToSelected;
        private System.Windows.Forms.Button btnSendToAllStudentsFromBuilding;
        private System.Windows.Forms.Button btnRemoveEvent;
        private System.Windows.Forms.Label lblLogOutAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbBanned;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.TextBox tbBannAccounts;
        private System.Windows.Forms.Button btnUnbann;
        private System.Windows.Forms.ListBox lbPending;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnBann;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblChooseDay;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.ComboBox cbEvent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbEventBuilding;
        private System.Windows.Forms.TabPage tpAddBuilding;
        private System.Windows.Forms.Button btnAddBuilding;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCapacity;
        private System.Windows.Forms.TextBox tbBuildingName;
        private System.Windows.Forms.ListBox lbSeeTasks;
    }
}
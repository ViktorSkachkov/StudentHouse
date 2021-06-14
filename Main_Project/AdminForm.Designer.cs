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
            this.lblEdit = new System.Windows.Forms.Label();
            this.tbEditRule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbRules = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblRule = new System.Windows.Forms.Label();
            this.tbAddRule = new System.Windows.Forms.TextBox();
            this.tpPendingAccounts = new System.Windows.Forms.TabPage();
            this.gbPending = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeny = new System.Windows.Forms.Button();
            this.lbPending = new System.Windows.Forms.ListBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.gbBann = new System.Windows.Forms.GroupBox();
            this.lbBanned = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUnbann = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tbBannAccounts = new System.Windows.Forms.TextBox();
            this.btnBann = new System.Windows.Forms.Button();
            this.tpTasks = new System.Windows.Forms.TabPage();
            this.btnSeeTasks = new System.Windows.Forms.Button();
            this.cbBuilding = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblThisWeek = new System.Windows.Forms.Label();
            this.lblSunday = new System.Windows.Forms.Label();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.tpEvents = new System.Windows.Forms.TabPage();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.btnUpdateWeeklyEvent = new System.Windows.Forms.Button();
            this.btnUpdateDailyEvent = new System.Windows.Forms.Button();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbEvent = new System.Windows.Forms.ComboBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.lbEvents = new System.Windows.Forms.ListBox();
            this.tpComplaints = new System.Windows.Forms.TabPage();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btnAnswerAComplaint = new System.Windows.Forms.Button();
            this.btnClearComp = new System.Windows.Forms.Button();
            this.btnRemoveComp = new System.Windows.Forms.Button();
            this.lbComp = new System.Windows.Forms.ListBox();
            this.tpSendMessages = new System.Windows.Forms.TabPage();
            this.btnSendToAllStudentsFromBuilding = new System.Windows.Forms.Button();
            this.tbSendToSelected = new System.Windows.Forms.TextBox();
            this.btnSendMessageToSelected = new System.Windows.Forms.Button();
            this.lbShowStudentsFromSameBuilding = new System.Windows.Forms.ListBox();
            this.btnShowBuildingStudents = new System.Windows.Forms.Button();
            this.lblSelectBuilding = new System.Windows.Forms.Label();
            this.cbMessageToBuilding = new System.Windows.Forms.ComboBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tbRules.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpPendingAccounts.SuspendLayout();
            this.gbPending.SuspendLayout();
            this.gbBann.SuspendLayout();
            this.tpTasks.SuspendLayout();
            this.tpEvents.SuspendLayout();
            this.tpComplaints.SuspendLayout();
            this.tpSendMessages.SuspendLayout();
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
            this.tbRules.Location = new System.Drawing.Point(9, 46);
            this.tbRules.Margin = new System.Windows.Forms.Padding(2);
            this.tbRules.Name = "tbRules";
            this.tbRules.SelectedIndex = 0;
            this.tbRules.Size = new System.Drawing.Size(899, 444);
            this.tbRules.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblEdit);
            this.tabPage1.Controls.Add(this.tbEditRule);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.btnRemove);
            this.tabPage1.Controls.Add(this.lbRules);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.lblRule);
            this.tabPage1.Controls.Add(this.tbAddRule);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(891, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rules";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "The student house rules:";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(4, 247);
            this.lblEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(87, 13);
            this.lblEdit.TabIndex = 9;
            this.lblEdit.Text = "Write a new rule:";
            // 
            // tbEditRule
            // 
            this.tbEditRule.Location = new System.Drawing.Point(7, 272);
            this.tbEditRule.Margin = new System.Windows.Forms.Padding(2);
            this.tbEditRule.Name = "tbEditRule";
            this.tbEditRule.Size = new System.Drawing.Size(320, 20);
            this.tbEditRule.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select a rule from the listbox \r\nto edit or remove";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(7, 295);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(166, 58);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(7, 168);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(166, 58);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbRules
            // 
            this.lbRules.FormattingEnabled = true;
            this.lbRules.Location = new System.Drawing.Point(331, 37);
            this.lbRules.Margin = new System.Windows.Forms.Padding(2);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(548, 316);
            this.lbRules.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(7, 61);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(166, 46);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.Location = new System.Drawing.Point(4, 11);
            this.lblRule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(87, 13);
            this.lblRule.TabIndex = 2;
            this.lblRule.Text = "Write a new rule:";
            // 
            // tbAddRule
            // 
            this.tbAddRule.Location = new System.Drawing.Point(7, 38);
            this.tbAddRule.Margin = new System.Windows.Forms.Padding(2);
            this.tbAddRule.Name = "tbAddRule";
            this.tbAddRule.Size = new System.Drawing.Size(320, 20);
            this.tbAddRule.TabIndex = 1;
            // 
            // tpPendingAccounts
            // 
            this.tpPendingAccounts.BackColor = System.Drawing.Color.Gainsboro;
            this.tpPendingAccounts.Controls.Add(this.gbPending);
            this.tpPendingAccounts.Controls.Add(this.gbBann);
            this.tpPendingAccounts.Location = new System.Drawing.Point(4, 22);
            this.tpPendingAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.tpPendingAccounts.Name = "tpPendingAccounts";
            this.tpPendingAccounts.Padding = new System.Windows.Forms.Padding(2);
            this.tpPendingAccounts.Size = new System.Drawing.Size(891, 418);
            this.tpPendingAccounts.TabIndex = 1;
            this.tpPendingAccounts.Text = "Pending Accounts";
            // 
            // gbPending
            // 
            this.gbPending.BackColor = System.Drawing.Color.Lime;
            this.gbPending.Controls.Add(this.label3);
            this.gbPending.Controls.Add(this.btnDeny);
            this.gbPending.Controls.Add(this.lbPending);
            this.gbPending.Controls.Add(this.btnApprove);
            this.gbPending.Location = new System.Drawing.Point(2, 0);
            this.gbPending.Margin = new System.Windows.Forms.Padding(2);
            this.gbPending.Name = "gbPending";
            this.gbPending.Padding = new System.Windows.Forms.Padding(2);
            this.gbPending.Size = new System.Drawing.Size(459, 418);
            this.gbPending.TabIndex = 26;
            this.gbPending.TabStop = false;
            this.gbPending.Text = "Pending";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Waiting approval";
            // 
            // btnDeny
            // 
            this.btnDeny.Location = new System.Drawing.Point(160, 387);
            this.btnDeny.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(56, 26);
            this.btnDeny.TabIndex = 16;
            this.btnDeny.Text = "Deny";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDenied_Click);
            // 
            // lbPending
            // 
            this.lbPending.FormattingEnabled = true;
            this.lbPending.Location = new System.Drawing.Point(8, 124);
            this.lbPending.Margin = new System.Windows.Forms.Padding(2);
            this.lbPending.Name = "lbPending";
            this.lbPending.Size = new System.Drawing.Size(209, 251);
            this.lbPending.TabIndex = 13;
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(8, 387);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(2);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(56, 26);
            this.btnApprove.TabIndex = 15;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // gbBann
            // 
            this.gbBann.BackColor = System.Drawing.Color.Red;
            this.gbBann.Controls.Add(this.lbBanned);
            this.gbBann.Controls.Add(this.label4);
            this.gbBann.Controls.Add(this.btnUnbann);
            this.gbBann.Controls.Add(this.label5);
            this.gbBann.Controls.Add(this.button3);
            this.gbBann.Controls.Add(this.tbBannAccounts);
            this.gbBann.Controls.Add(this.btnBann);
            this.gbBann.Location = new System.Drawing.Point(466, 0);
            this.gbBann.Margin = new System.Windows.Forms.Padding(2);
            this.gbBann.Name = "gbBann";
            this.gbBann.Padding = new System.Windows.Forms.Padding(2);
            this.gbBann.Size = new System.Drawing.Size(423, 413);
            this.gbBann.TabIndex = 0;
            this.gbBann.TabStop = false;
            this.gbBann.Text = "Bann";
            // 
            // lbBanned
            // 
            this.lbBanned.FormattingEnabled = true;
            this.lbBanned.Location = new System.Drawing.Point(201, 108);
            this.lbBanned.Margin = new System.Windows.Forms.Padding(2);
            this.lbBanned.Name = "lbBanned";
            this.lbBanned.Size = new System.Drawing.Size(209, 264);
            this.lbBanned.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, -17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Banned accounts";
            // 
            // btnUnbann
            // 
            this.btnUnbann.Location = new System.Drawing.Point(201, 384);
            this.btnUnbann.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnbann.Name = "btnUnbann";
            this.btnUnbann.Size = new System.Drawing.Size(56, 19);
            this.btnUnbann.TabIndex = 19;
            this.btnUnbann.Text = "Unbann";
            this.btnUnbann.UseVisualStyleBackColor = true;
            this.btnUnbann.Click += new System.EventHandler(this.btnUnbann_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Student number ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(352, 384);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 20;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbBannAccounts
            // 
            this.tbBannAccounts.Location = new System.Drawing.Point(113, 108);
            this.tbBannAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.tbBannAccounts.Name = "tbBannAccounts";
            this.tbBannAccounts.Size = new System.Drawing.Size(84, 20);
            this.tbBannAccounts.TabIndex = 22;
            // 
            // btnBann
            // 
            this.btnBann.Location = new System.Drawing.Point(113, 138);
            this.btnBann.Margin = new System.Windows.Forms.Padding(2);
            this.btnBann.Name = "btnBann";
            this.btnBann.Size = new System.Drawing.Size(83, 19);
            this.btnBann.TabIndex = 21;
            this.btnBann.Text = "Bann";
            this.btnBann.UseVisualStyleBackColor = true;
            this.btnBann.Click += new System.EventHandler(this.btnBann_Click);
            // 
            // tpTasks
            // 
            this.tpTasks.BackColor = System.Drawing.Color.Gainsboro;
            this.tpTasks.Controls.Add(this.btnSeeTasks);
            this.tpTasks.Controls.Add(this.cbBuilding);
            this.tpTasks.Controls.Add(this.label6);
            this.tpTasks.Controls.Add(this.lblThisWeek);
            this.tpTasks.Controls.Add(this.lblSunday);
            this.tpTasks.Controls.Add(this.lblSaturday);
            this.tpTasks.Controls.Add(this.lblFriday);
            this.tpTasks.Controls.Add(this.lblThursday);
            this.tpTasks.Controls.Add(this.lblWednesday);
            this.tpTasks.Controls.Add(this.lblTuesday);
            this.tpTasks.Controls.Add(this.lblMonday);
            this.tpTasks.Controls.Add(this.btnAssign);
            this.tpTasks.Location = new System.Drawing.Point(4, 22);
            this.tpTasks.Margin = new System.Windows.Forms.Padding(2);
            this.tpTasks.Name = "tpTasks";
            this.tpTasks.Padding = new System.Windows.Forms.Padding(2);
            this.tpTasks.Size = new System.Drawing.Size(891, 418);
            this.tpTasks.TabIndex = 2;
            this.tpTasks.Text = "Tasks";
            // 
            // btnSeeTasks
            // 
            this.btnSeeTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeTasks.Location = new System.Drawing.Point(4, 184);
            this.btnSeeTasks.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeeTasks.Name = "btnSeeTasks";
            this.btnSeeTasks.Size = new System.Drawing.Size(156, 63);
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
            this.cbBuilding.Location = new System.Drawing.Point(22, 54);
            this.cbBuilding.Margin = new System.Windows.Forms.Padding(2);
            this.cbBuilding.Name = "cbBuilding";
            this.cbBuilding.Size = new System.Drawing.Size(122, 21);
            this.cbBuilding.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Select a building:";
            // 
            // lblThisWeek
            // 
            this.lblThisWeek.AutoSize = true;
            this.lblThisWeek.Location = new System.Drawing.Point(178, 384);
            this.lblThisWeek.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThisWeek.Name = "lblThisWeek";
            this.lblThisWeek.Size = new System.Drawing.Size(16, 13);
            this.lblThisWeek.TabIndex = 8;
            this.lblThisWeek.Text = "8)";
            // 
            // lblSunday
            // 
            this.lblSunday.AutoSize = true;
            this.lblSunday.Location = new System.Drawing.Point(178, 340);
            this.lblSunday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(16, 13);
            this.lblSunday.TabIndex = 7;
            this.lblSunday.Text = "7)";
            // 
            // lblSaturday
            // 
            this.lblSaturday.AutoSize = true;
            this.lblSaturday.Location = new System.Drawing.Point(178, 286);
            this.lblSaturday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(16, 13);
            this.lblSaturday.TabIndex = 6;
            this.lblSaturday.Text = "6)";
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Location = new System.Drawing.Point(178, 232);
            this.lblFriday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(16, 13);
            this.lblFriday.TabIndex = 5;
            this.lblFriday.Text = "5)";
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Location = new System.Drawing.Point(178, 184);
            this.lblThursday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(16, 13);
            this.lblThursday.TabIndex = 4;
            this.lblThursday.Text = "4)";
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Location = new System.Drawing.Point(178, 130);
            this.lblWednesday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(16, 13);
            this.lblWednesday.TabIndex = 3;
            this.lblWednesday.Text = "3)";
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Location = new System.Drawing.Point(178, 78);
            this.lblTuesday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(16, 13);
            this.lblTuesday.TabIndex = 2;
            this.lblTuesday.Text = "2)";
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Location = new System.Drawing.Point(178, 24);
            this.lblMonday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(16, 13);
            this.lblMonday.TabIndex = 1;
            this.lblMonday.Text = "1)";
            // 
            // btnAssign
            // 
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.Location = new System.Drawing.Point(4, 104);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(156, 61);
            this.btnAssign.TabIndex = 0;
            this.btnAssign.Text = "Assign randomly";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // tpEvents
            // 
            this.tpEvents.BackColor = System.Drawing.Color.Gainsboro;
            this.tpEvents.Controls.Add(this.lblTime);
            this.tpEvents.Controls.Add(this.lblDay);
            this.tpEvents.Controls.Add(this.lblEvent);
            this.tpEvents.Controls.Add(this.btnUpdateWeeklyEvent);
            this.tpEvents.Controls.Add(this.btnUpdateDailyEvent);
            this.tpEvents.Controls.Add(this.cbTime);
            this.tpEvents.Controls.Add(this.cbDay);
            this.tpEvents.Controls.Add(this.cbEvent);
            this.tpEvents.Controls.Add(this.btnAddEvent);
            this.tpEvents.Controls.Add(this.lbEvents);
            this.tpEvents.Location = new System.Drawing.Point(4, 22);
            this.tpEvents.Margin = new System.Windows.Forms.Padding(2);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Padding = new System.Windows.Forms.Padding(2);
            this.tpEvents.Size = new System.Drawing.Size(891, 418);
            this.tpEvents.TabIndex = 3;
            this.tpEvents.Text = "Events";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(280, 19);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(77, 13);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Choose a time:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(176, 19);
            this.lblDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(75, 13);
            this.lblDay.TabIndex = 8;
            this.lblDay.Text = "Choose a day:";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(13, 19);
            this.lblEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(91, 13);
            this.lblEvent.TabIndex = 7;
            this.lblEvent.Text = "Choose an event:";
            // 
            // btnUpdateWeeklyEvent
            // 
            this.btnUpdateWeeklyEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateWeeklyEvent.Location = new System.Drawing.Point(689, 28);
            this.btnUpdateWeeklyEvent.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateWeeklyEvent.Name = "btnUpdateWeeklyEvent";
            this.btnUpdateWeeklyEvent.Size = new System.Drawing.Size(178, 46);
            this.btnUpdateWeeklyEvent.TabIndex = 6;
            this.btnUpdateWeeklyEvent.Text = "Update Weekly Event";
            this.btnUpdateWeeklyEvent.UseVisualStyleBackColor = true;
            this.btnUpdateWeeklyEvent.Click += new System.EventHandler(this.btnUpdateWeeklyEvent_Click);
            // 
            // btnUpdateDailyEvent
            // 
            this.btnUpdateDailyEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDailyEvent.Location = new System.Drawing.Point(519, 28);
            this.btnUpdateDailyEvent.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateDailyEvent.Name = "btnUpdateDailyEvent";
            this.btnUpdateDailyEvent.Size = new System.Drawing.Size(158, 46);
            this.btnUpdateDailyEvent.TabIndex = 5;
            this.btnUpdateDailyEvent.Text = "Update Daily Event";
            this.btnUpdateDailyEvent.UseVisualStyleBackColor = true;
            this.btnUpdateDailyEvent.Click += new System.EventHandler(this.btnUpdateDailyEvent_Click);
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
            this.cbTime.Location = new System.Drawing.Point(283, 44);
            this.cbTime.Margin = new System.Windows.Forms.Padding(2);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(74, 21);
            this.cbTime.TabIndex = 4;
            this.cbTime.SelectedIndexChanged += new System.EventHandler(this.cbTime_SelectedIndexChanged);
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(178, 44);
            this.cbDay.Margin = new System.Windows.Forms.Padding(2);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(80, 21);
            this.cbDay.TabIndex = 3;
            this.cbDay.SelectedIndexChanged += new System.EventHandler(this.cbDay_SelectedIndexChanged);
            // 
            // cbEvent
            // 
            this.cbEvent.FormattingEnabled = true;
            this.cbEvent.Items.AddRange(new object[] {
            "Small Group Gathering",
            "Small Party",
            "Friend / Parents coming over for a few day"});
            this.cbEvent.Location = new System.Drawing.Point(15, 44);
            this.cbEvent.Margin = new System.Windows.Forms.Padding(2);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(134, 21);
            this.cbEvent.TabIndex = 2;
            this.cbEvent.SelectedIndexChanged += new System.EventHandler(this.cbEvent_SelectedIndexChanged);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.Location = new System.Drawing.Point(386, 28);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(118, 46);
            this.btnAddEvent.TabIndex = 1;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // lbEvents
            // 
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.Location = new System.Drawing.Point(15, 105);
            this.lbEvents.Margin = new System.Windows.Forms.Padding(2);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(853, 303);
            this.lbEvents.TabIndex = 0;
            // 
            // tpComplaints
            // 
            this.tpComplaints.BackColor = System.Drawing.Color.Gainsboro;
            this.tpComplaints.Controls.Add(this.lblAnswer);
            this.tpComplaints.Controls.Add(this.tbMessage);
            this.tpComplaints.Controls.Add(this.btnAnswerAComplaint);
            this.tpComplaints.Controls.Add(this.btnClearComp);
            this.tpComplaints.Controls.Add(this.btnRemoveComp);
            this.tpComplaints.Controls.Add(this.lbComp);
            this.tpComplaints.Location = new System.Drawing.Point(4, 22);
            this.tpComplaints.Margin = new System.Windows.Forms.Padding(2);
            this.tpComplaints.Name = "tpComplaints";
            this.tpComplaints.Padding = new System.Windows.Forms.Padding(2);
            this.tpComplaints.Size = new System.Drawing.Size(891, 418);
            this.tpComplaints.TabIndex = 4;
            this.tpComplaints.Text = "Complaints";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(32, 379);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(215, 13);
            this.lblAnswer.TabIndex = 6;
            this.lblAnswer.Text = "Select a complaint and write an answer to it:";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(34, 395);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(2);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(849, 20);
            this.tbMessage.TabIndex = 5;
            // 
            // btnAnswerAComplaint
            // 
            this.btnAnswerAComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerAComplaint.Location = new System.Drawing.Point(34, 290);
            this.btnAnswerAComplaint.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnswerAComplaint.Name = "btnAnswerAComplaint";
            this.btnAnswerAComplaint.Size = new System.Drawing.Size(178, 78);
            this.btnAnswerAComplaint.TabIndex = 4;
            this.btnAnswerAComplaint.Text = "Answer a complaint";
            this.btnAnswerAComplaint.UseVisualStyleBackColor = true;
            this.btnAnswerAComplaint.Click += new System.EventHandler(this.btnAnswerAComplaint_Click);
            // 
            // btnClearComp
            // 
            this.btnClearComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearComp.Location = new System.Drawing.Point(706, 297);
            this.btnClearComp.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearComp.Name = "btnClearComp";
            this.btnClearComp.Size = new System.Drawing.Size(176, 78);
            this.btnClearComp.TabIndex = 3;
            this.btnClearComp.Text = "Clear";
            this.btnClearComp.UseVisualStyleBackColor = true;
            this.btnClearComp.Click += new System.EventHandler(this.btnClearComp_Click);
            // 
            // btnRemoveComp
            // 
            this.btnRemoveComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveComp.Location = new System.Drawing.Point(526, 297);
            this.btnRemoveComp.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveComp.Name = "btnRemoveComp";
            this.btnRemoveComp.Size = new System.Drawing.Size(170, 78);
            this.btnRemoveComp.TabIndex = 2;
            this.btnRemoveComp.Text = "Remove";
            this.btnRemoveComp.UseVisualStyleBackColor = true;
            this.btnRemoveComp.Click += new System.EventHandler(this.btnRemoveComp_Click);
            // 
            // lbComp
            // 
            this.lbComp.FormattingEnabled = true;
            this.lbComp.Location = new System.Drawing.Point(34, 22);
            this.lbComp.Margin = new System.Windows.Forms.Padding(2);
            this.lbComp.Name = "lbComp";
            this.lbComp.Size = new System.Drawing.Size(805, 264);
            this.lbComp.TabIndex = 0;
            // 
            // tpSendMessages
            // 
            this.tpSendMessages.BackColor = System.Drawing.Color.Gainsboro;
            this.tpSendMessages.Controls.Add(this.btnSendToAllStudentsFromBuilding);
            this.tpSendMessages.Controls.Add(this.tbSendToSelected);
            this.tpSendMessages.Controls.Add(this.btnSendMessageToSelected);
            this.tpSendMessages.Controls.Add(this.lbShowStudentsFromSameBuilding);
            this.tpSendMessages.Controls.Add(this.btnShowBuildingStudents);
            this.tpSendMessages.Controls.Add(this.lblSelectBuilding);
            this.tpSendMessages.Controls.Add(this.cbMessageToBuilding);
            this.tpSendMessages.Location = new System.Drawing.Point(4, 22);
            this.tpSendMessages.Margin = new System.Windows.Forms.Padding(2);
            this.tpSendMessages.Name = "tpSendMessages";
            this.tpSendMessages.Padding = new System.Windows.Forms.Padding(2);
            this.tpSendMessages.Size = new System.Drawing.Size(891, 418);
            this.tpSendMessages.TabIndex = 5;
            this.tpSendMessages.Text = "Send messages";
            // 
            // btnSendToAllStudentsFromBuilding
            // 
            this.btnSendToAllStudentsFromBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendToAllStudentsFromBuilding.Location = new System.Drawing.Point(103, 198);
            this.btnSendToAllStudentsFromBuilding.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendToAllStudentsFromBuilding.Name = "btnSendToAllStudentsFromBuilding";
            this.btnSendToAllStudentsFromBuilding.Size = new System.Drawing.Size(230, 77);
            this.btnSendToAllStudentsFromBuilding.TabIndex = 6;
            this.btnSendToAllStudentsFromBuilding.Text = "Send message to all students from selected building";
            this.btnSendToAllStudentsFromBuilding.UseVisualStyleBackColor = true;
            this.btnSendToAllStudentsFromBuilding.Click += new System.EventHandler(this.btnSendToAllStudentsFromBuilding_Click);
            // 
            // tbSendToSelected
            // 
            this.tbSendToSelected.Location = new System.Drawing.Point(4, 292);
            this.tbSendToSelected.Margin = new System.Windows.Forms.Padding(2);
            this.tbSendToSelected.Name = "tbSendToSelected";
            this.tbSendToSelected.Size = new System.Drawing.Size(885, 20);
            this.tbSendToSelected.TabIndex = 5;
            // 
            // btnSendMessageToSelected
            // 
            this.btnSendMessageToSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMessageToSelected.Location = new System.Drawing.Point(388, 209);
            this.btnSendMessageToSelected.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendMessageToSelected.Name = "btnSendMessageToSelected";
            this.btnSendMessageToSelected.Size = new System.Drawing.Size(158, 67);
            this.btnSendMessageToSelected.TabIndex = 4;
            this.btnSendMessageToSelected.Text = "Send message to selected student";
            this.btnSendMessageToSelected.UseVisualStyleBackColor = true;
            this.btnSendMessageToSelected.Click += new System.EventHandler(this.btnSendMessageToSelected_Click);
            // 
            // lbShowStudentsFromSameBuilding
            // 
            this.lbShowStudentsFromSameBuilding.FormattingEnabled = true;
            this.lbShowStudentsFromSameBuilding.Location = new System.Drawing.Point(568, 25);
            this.lbShowStudentsFromSameBuilding.Margin = new System.Windows.Forms.Padding(2);
            this.lbShowStudentsFromSameBuilding.Name = "lbShowStudentsFromSameBuilding";
            this.lbShowStudentsFromSameBuilding.Size = new System.Drawing.Size(321, 251);
            this.lbShowStudentsFromSameBuilding.TabIndex = 3;
            // 
            // btnShowBuildingStudents
            // 
            this.btnShowBuildingStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBuildingStudents.Location = new System.Drawing.Point(379, 25);
            this.btnShowBuildingStudents.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowBuildingStudents.Name = "btnShowBuildingStudents";
            this.btnShowBuildingStudents.Size = new System.Drawing.Size(175, 60);
            this.btnShowBuildingStudents.TabIndex = 2;
            this.btnShowBuildingStudents.Text = "Show all the students in the building";
            this.btnShowBuildingStudents.UseVisualStyleBackColor = true;
            this.btnShowBuildingStudents.Click += new System.EventHandler(this.btnShowBuildingStudents_Click);
            // 
            // lblSelectBuilding
            // 
            this.lblSelectBuilding.AutoSize = true;
            this.lblSelectBuilding.Location = new System.Drawing.Point(134, 25);
            this.lblSelectBuilding.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectBuilding.Name = "lblSelectBuilding";
            this.lblSelectBuilding.Size = new System.Drawing.Size(88, 13);
            this.lblSelectBuilding.TabIndex = 1;
            this.lblSelectBuilding.Text = "Select a building:";
            // 
            // cbMessageToBuilding
            // 
            this.cbMessageToBuilding.FormattingEnabled = true;
            this.cbMessageToBuilding.Items.AddRange(new object[] {
            "B1",
            "B2",
            "B3",
            "B4"});
            this.cbMessageToBuilding.Location = new System.Drawing.Point(136, 54);
            this.cbMessageToBuilding.Margin = new System.Windows.Forms.Padding(2);
            this.cbMessageToBuilding.Name = "cbMessageToBuilding";
            this.cbMessageToBuilding.Size = new System.Drawing.Size(121, 21);
            this.cbMessageToBuilding.TabIndex = 0;
            this.cbMessageToBuilding.SelectedIndexChanged += new System.EventHandler(this.cbMessageToBuilding_SelectedIndexChanged);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblBack.Location = new System.Drawing.Point(831, 7);
            this.lblBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(45, 20);
            this.lblBack.TabIndex = 10;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(10, 7);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(52, 13);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 489);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.tbRules);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.tbRules.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tpPendingAccounts.ResumeLayout(false);
            this.gbPending.ResumeLayout(false);
            this.gbPending.PerformLayout();
            this.gbBann.ResumeLayout(false);
            this.gbBann.PerformLayout();
            this.tpTasks.ResumeLayout(false);
            this.tpTasks.PerformLayout();
            this.tpEvents.ResumeLayout(false);
            this.tpEvents.PerformLayout();
            this.tpComplaints.ResumeLayout(false);
            this.tpComplaints.PerformLayout();
            this.tpSendMessages.ResumeLayout(false);
            this.tpSendMessages.PerformLayout();
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
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabPage tpTasks;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lblSunday;
        private System.Windows.Forms.Label lblSaturday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Label lblThisWeek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBannAccounts;
        private System.Windows.Forms.Button btnBann;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUnbann;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbBanned;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbPending;
        private System.Windows.Forms.TabPage tpEvents;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbEvent;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.ListBox lbEvents;
        private System.Windows.Forms.Button btnUpdateWeeklyEvent;
        private System.Windows.Forms.Button btnUpdateDailyEvent;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.TabPage tpComplaints;
        private System.Windows.Forms.Button btnClearComp;
        private System.Windows.Forms.Button btnRemoveComp;
        private System.Windows.Forms.ListBox lbComp;
        private System.Windows.Forms.GroupBox gbPending;
        private System.Windows.Forms.GroupBox gbBann;
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
    }
}
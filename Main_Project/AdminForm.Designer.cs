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
            this.label5 = new System.Windows.Forms.Label();
            this.tbBannAccounts = new System.Windows.Forms.TextBox();
            this.btnBann = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbBanned = new System.Windows.Forms.ListBox();
            this.btnDeny = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPending = new System.Windows.Forms.ListBox();
            this.tpTasks = new System.Windows.Forms.TabPage();
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
            this.btnClearComp = new System.Windows.Forms.Button();
            this.btnRemoveComp = new System.Windows.Forms.Button();
            this.lbComp = new System.Windows.Forms.ListBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnShowPending = new System.Windows.Forms.Button();
            this.gbBann = new System.Windows.Forms.GroupBox();
            this.gbPending = new System.Windows.Forms.GroupBox();
            this.btnShowBanned = new System.Windows.Forms.Button();
            this.tbRules.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpPendingAccounts.SuspendLayout();
            this.tpTasks.SuspendLayout();
            this.tpEvents.SuspendLayout();
            this.tpComplaints.SuspendLayout();
            this.gbBann.SuspendLayout();
            this.gbPending.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRules
            // 
            this.tbRules.Controls.Add(this.tabPage1);
            this.tbRules.Controls.Add(this.tpPendingAccounts);
            this.tbRules.Controls.Add(this.tpTasks);
            this.tbRules.Controls.Add(this.tpEvents);
            this.tbRules.Controls.Add(this.tpComplaints);
            this.tbRules.Location = new System.Drawing.Point(12, 57);
            this.tbRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRules.Name = "tbRules";
            this.tbRules.SelectedIndex = 0;
            this.tbRules.Size = new System.Drawing.Size(1199, 546);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1191, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rules";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "The student house rules:";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(5, 304);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(114, 17);
            this.lblEdit.TabIndex = 9;
            this.lblEdit.Text = "Write a new rule:";
            // 
            // tbEditRule
            // 
            this.tbEditRule.Location = new System.Drawing.Point(9, 335);
            this.tbEditRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEditRule.Name = "tbEditRule";
            this.tbEditRule.Size = new System.Drawing.Size(425, 22);
            this.tbEditRule.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select a rule from the listbox \r\nto edit or remove";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(9, 363);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(221, 71);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(9, 207);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(221, 71);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbRules
            // 
            this.lbRules.FormattingEnabled = true;
            this.lbRules.ItemHeight = 16;
            this.lbRules.Location = new System.Drawing.Point(441, 46);
            this.lbRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(729, 388);
            this.lbRules.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(9, 75);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(221, 57);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblRule
            // 
            this.lblRule.AutoSize = true;
            this.lblRule.Location = new System.Drawing.Point(5, 14);
            this.lblRule.Name = "lblRule";
            this.lblRule.Size = new System.Drawing.Size(114, 17);
            this.lblRule.TabIndex = 2;
            this.lblRule.Text = "Write a new rule:";
            // 
            // tbAddRule
            // 
            this.tbAddRule.Location = new System.Drawing.Point(9, 47);
            this.tbAddRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddRule.Name = "tbAddRule";
            this.tbAddRule.Size = new System.Drawing.Size(425, 22);
            this.tbAddRule.TabIndex = 1;
            // 
            // tpPendingAccounts
            // 
            this.tpPendingAccounts.BackColor = System.Drawing.Color.Gainsboro;
            this.tpPendingAccounts.Controls.Add(this.gbPending);
            this.tpPendingAccounts.Controls.Add(this.gbBann);
            this.tpPendingAccounts.Location = new System.Drawing.Point(4, 25);
            this.tpPendingAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPendingAccounts.Name = "tpPendingAccounts";
            this.tpPendingAccounts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPendingAccounts.Size = new System.Drawing.Size(1191, 517);
            this.tpPendingAccounts.TabIndex = 1;
            this.tpPendingAccounts.Text = "Pending Accounts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Student number ";
            // 
            // tbBannAccounts
            // 
            this.tbBannAccounts.Location = new System.Drawing.Point(151, 133);
            this.tbBannAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBannAccounts.Name = "tbBannAccounts";
            this.tbBannAccounts.Size = new System.Drawing.Size(111, 22);
            this.tbBannAccounts.TabIndex = 22;
            // 
            // btnBann
            // 
            this.btnBann.Location = new System.Drawing.Point(151, 170);
            this.btnBann.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBann.Name = "btnBann";
            this.btnBann.Size = new System.Drawing.Size(111, 23);
            this.btnBann.TabIndex = 21;
            this.btnBann.Text = "Bann";
            this.btnBann.UseVisualStyleBackColor = true;
            this.btnBann.Click += new System.EventHandler(this.btnBann_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(470, 472);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(268, 472);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Unbann";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, -21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Banned accounts";
            // 
            // lbBanned
            // 
            this.lbBanned.FormattingEnabled = true;
            this.lbBanned.ItemHeight = 16;
            this.lbBanned.Location = new System.Drawing.Point(268, 133);
            this.lbBanned.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbBanned.Name = "lbBanned";
            this.lbBanned.Size = new System.Drawing.Size(277, 324);
            this.lbBanned.TabIndex = 17;
            // 
            // btnDeny
            // 
            this.btnDeny.Location = new System.Drawing.Point(213, 476);
            this.btnDeny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(75, 32);
            this.btnDeny.TabIndex = 16;
            this.btnDeny.Text = "Deny";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDenied_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(11, 476);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 32);
            this.btnApprove.TabIndex = 15;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Waiting approval";
            // 
            // lbPending
            // 
            this.lbPending.FormattingEnabled = true;
            this.lbPending.ItemHeight = 16;
            this.lbPending.Location = new System.Drawing.Point(11, 153);
            this.lbPending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbPending.Name = "lbPending";
            this.lbPending.Size = new System.Drawing.Size(277, 308);
            this.lbPending.TabIndex = 13;
            // 
            // tpTasks
            // 
            this.tpTasks.BackColor = System.Drawing.Color.Gainsboro;
            this.tpTasks.Controls.Add(this.lblThisWeek);
            this.tpTasks.Controls.Add(this.lblSunday);
            this.tpTasks.Controls.Add(this.lblSaturday);
            this.tpTasks.Controls.Add(this.lblFriday);
            this.tpTasks.Controls.Add(this.lblThursday);
            this.tpTasks.Controls.Add(this.lblWednesday);
            this.tpTasks.Controls.Add(this.lblTuesday);
            this.tpTasks.Controls.Add(this.lblMonday);
            this.tpTasks.Controls.Add(this.btnAssign);
            this.tpTasks.Location = new System.Drawing.Point(4, 25);
            this.tpTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTasks.Name = "tpTasks";
            this.tpTasks.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTasks.Size = new System.Drawing.Size(1191, 517);
            this.tpTasks.TabIndex = 2;
            this.tpTasks.Text = "Tasks";
            // 
            // lblThisWeek
            // 
            this.lblThisWeek.AutoSize = true;
            this.lblThisWeek.Location = new System.Drawing.Point(237, 473);
            this.lblThisWeek.Name = "lblThisWeek";
            this.lblThisWeek.Size = new System.Drawing.Size(21, 17);
            this.lblThisWeek.TabIndex = 8;
            this.lblThisWeek.Text = "8)";
            // 
            // lblSunday
            // 
            this.lblSunday.AutoSize = true;
            this.lblSunday.Location = new System.Drawing.Point(237, 418);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(21, 17);
            this.lblSunday.TabIndex = 7;
            this.lblSunday.Text = "7)";
            // 
            // lblSaturday
            // 
            this.lblSaturday.AutoSize = true;
            this.lblSaturday.Location = new System.Drawing.Point(237, 352);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(21, 17);
            this.lblSaturday.TabIndex = 6;
            this.lblSaturday.Text = "6)";
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Location = new System.Drawing.Point(237, 286);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(21, 17);
            this.lblFriday.TabIndex = 5;
            this.lblFriday.Text = "5)";
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Location = new System.Drawing.Point(237, 226);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(21, 17);
            this.lblThursday.TabIndex = 4;
            this.lblThursday.Text = "4)";
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Location = new System.Drawing.Point(237, 160);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(21, 17);
            this.lblWednesday.TabIndex = 3;
            this.lblWednesday.Text = "3)";
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Location = new System.Drawing.Point(237, 96);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(21, 17);
            this.lblTuesday.TabIndex = 2;
            this.lblTuesday.Text = "2)";
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Location = new System.Drawing.Point(237, 30);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(21, 17);
            this.lblMonday.TabIndex = 1;
            this.lblMonday.Text = "1)";
            // 
            // btnAssign
            // 
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.Location = new System.Drawing.Point(5, 194);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(208, 75);
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
            this.tpEvents.Location = new System.Drawing.Point(4, 25);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tpEvents.Size = new System.Drawing.Size(1191, 517);
            this.tpEvents.TabIndex = 3;
            this.tpEvents.Text = "Events";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(374, 23);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(102, 17);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Choose a time:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(234, 23);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(99, 17);
            this.lblDay.TabIndex = 8;
            this.lblDay.Text = "Choose a day:";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(17, 23);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(119, 17);
            this.lblEvent.TabIndex = 7;
            this.lblEvent.Text = "Choose an event:";
            // 
            // btnUpdateWeeklyEvent
            // 
            this.btnUpdateWeeklyEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateWeeklyEvent.Location = new System.Drawing.Point(919, 34);
            this.btnUpdateWeeklyEvent.Name = "btnUpdateWeeklyEvent";
            this.btnUpdateWeeklyEvent.Size = new System.Drawing.Size(238, 57);
            this.btnUpdateWeeklyEvent.TabIndex = 6;
            this.btnUpdateWeeklyEvent.Text = "Update Weekly Event";
            this.btnUpdateWeeklyEvent.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDailyEvent
            // 
            this.btnUpdateDailyEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDailyEvent.Location = new System.Drawing.Point(692, 34);
            this.btnUpdateDailyEvent.Name = "btnUpdateDailyEvent";
            this.btnUpdateDailyEvent.Size = new System.Drawing.Size(210, 57);
            this.btnUpdateDailyEvent.TabIndex = 5;
            this.btnUpdateDailyEvent.Text = "Update Daily Event";
            this.btnUpdateDailyEvent.UseVisualStyleBackColor = true;
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
            this.cbTime.Location = new System.Drawing.Point(377, 54);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(98, 24);
            this.cbTime.TabIndex = 4;
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(237, 54);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(105, 24);
            this.cbDay.TabIndex = 3;
            // 
            // cbEvent
            // 
            this.cbEvent.FormattingEnabled = true;
            this.cbEvent.Items.AddRange(new object[] {
            "Small Group Gathering",
            "Small Party",
            "Friend / Parents coming over for a few day"});
            this.cbEvent.Location = new System.Drawing.Point(20, 54);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(177, 24);
            this.cbEvent.TabIndex = 2;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.Location = new System.Drawing.Point(515, 34);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(158, 57);
            this.btnAddEvent.TabIndex = 1;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // lbEvents
            // 
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.ItemHeight = 16;
            this.lbEvents.Location = new System.Drawing.Point(20, 129);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(1136, 372);
            this.lbEvents.TabIndex = 0;
            // 
            // tpComplaints
            // 
            this.tpComplaints.BackColor = System.Drawing.Color.Gainsboro;
            this.tpComplaints.Controls.Add(this.btnClearComp);
            this.tpComplaints.Controls.Add(this.btnRemoveComp);
            this.tpComplaints.Controls.Add(this.lbComp);
            this.tpComplaints.Location = new System.Drawing.Point(4, 25);
            this.tpComplaints.Name = "tpComplaints";
            this.tpComplaints.Padding = new System.Windows.Forms.Padding(3);
            this.tpComplaints.Size = new System.Drawing.Size(1191, 517);
            this.tpComplaints.TabIndex = 4;
            this.tpComplaints.Text = "Complaints";
            // 
            // btnClearComp
            // 
            this.btnClearComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearComp.Location = new System.Drawing.Point(820, 379);
            this.btnClearComp.Name = "btnClearComp";
            this.btnClearComp.Size = new System.Drawing.Size(234, 96);
            this.btnClearComp.TabIndex = 3;
            this.btnClearComp.Text = "Clear";
            this.btnClearComp.UseVisualStyleBackColor = true;
            this.btnClearComp.Click += new System.EventHandler(this.btnClearComp_Click);
            // 
            // btnRemoveComp
            // 
            this.btnRemoveComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveComp.Location = new System.Drawing.Point(469, 379);
            this.btnRemoveComp.Name = "btnRemoveComp";
            this.btnRemoveComp.Size = new System.Drawing.Size(226, 96);
            this.btnRemoveComp.TabIndex = 2;
            this.btnRemoveComp.Text = "Remove";
            this.btnRemoveComp.UseVisualStyleBackColor = true;
            this.btnRemoveComp.Click += new System.EventHandler(this.btnRemoveComp_Click);
            // 
            // lbComp
            // 
            this.lbComp.FormattingEnabled = true;
            this.lbComp.ItemHeight = 16;
            this.lbComp.Location = new System.Drawing.Point(45, 27);
            this.lbComp.Name = "lbComp";
            this.lbComp.Size = new System.Drawing.Size(1072, 324);
            this.lbComp.TabIndex = 0;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblBack.Location = new System.Drawing.Point(1108, 9);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(56, 25);
            this.lblBack.TabIndex = 10;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(13, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(66, 17);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnShowPending
            // 
            this.btnShowPending.Location = new System.Drawing.Point(351, 21);
            this.btnShowPending.Name = "btnShowPending";
            this.btnShowPending.Size = new System.Drawing.Size(210, 62);
            this.btnShowPending.TabIndex = 24;
            this.btnShowPending.Text = "Show information about a pending account";
            this.btnShowPending.UseVisualStyleBackColor = true;
            this.btnShowPending.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbBann
            // 
            this.gbBann.BackColor = System.Drawing.Color.Red;
            this.gbBann.Controls.Add(this.btnShowBanned);
            this.gbBann.Controls.Add(this.lbBanned);
            this.gbBann.Controls.Add(this.label4);
            this.gbBann.Controls.Add(this.button4);
            this.gbBann.Controls.Add(this.label5);
            this.gbBann.Controls.Add(this.button3);
            this.gbBann.Controls.Add(this.tbBannAccounts);
            this.gbBann.Controls.Add(this.btnBann);
            this.gbBann.Location = new System.Drawing.Point(621, 0);
            this.gbBann.Name = "gbBann";
            this.gbBann.Size = new System.Drawing.Size(564, 508);
            this.gbBann.TabIndex = 0;
            this.gbBann.TabStop = false;
            this.gbBann.Text = "Bann";
            // 
            // gbPending
            // 
            this.gbPending.BackColor = System.Drawing.Color.Lime;
            this.gbPending.Controls.Add(this.btnShowPending);
            this.gbPending.Controls.Add(this.label3);
            this.gbPending.Controls.Add(this.btnDeny);
            this.gbPending.Controls.Add(this.lbPending);
            this.gbPending.Controls.Add(this.btnApprove);
            this.gbPending.Location = new System.Drawing.Point(3, 0);
            this.gbPending.Name = "gbPending";
            this.gbPending.Size = new System.Drawing.Size(612, 514);
            this.gbPending.TabIndex = 26;
            this.gbPending.TabStop = false;
            this.gbPending.Text = "Pending";
            // 
            // btnShowBanned
            // 
            this.btnShowBanned.Location = new System.Drawing.Point(151, 21);
            this.btnShowBanned.Name = "btnShowBanned";
            this.btnShowBanned.Size = new System.Drawing.Size(226, 73);
            this.btnShowBanned.TabIndex = 24;
            this.btnShowBanned.Text = "Show information about a banned account";
            this.btnShowBanned.UseVisualStyleBackColor = true;
            this.btnShowBanned.Click += new System.EventHandler(this.btnShowBanned_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 602);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.tbRules);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.tbRules.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tpPendingAccounts.ResumeLayout(false);
            this.tpTasks.ResumeLayout(false);
            this.tpTasks.PerformLayout();
            this.tpEvents.ResumeLayout(false);
            this.tpEvents.PerformLayout();
            this.tpComplaints.ResumeLayout(false);
            this.gbBann.ResumeLayout(false);
            this.gbBann.PerformLayout();
            this.gbPending.ResumeLayout(false);
            this.gbPending.PerformLayout();
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
        private System.Windows.Forms.Button button4;
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
        private System.Windows.Forms.Button btnShowPending;
        private System.Windows.Forms.GroupBox gbBann;
        private System.Windows.Forms.Button btnShowBanned;
    }
}
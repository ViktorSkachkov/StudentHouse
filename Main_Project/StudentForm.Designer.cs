namespace Student_House
{
    partial class StudentForm
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
            this.lblBack = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpRules = new System.Windows.Forms.TabPage();
            this.lblRules = new System.Windows.Forms.Label();
            this.lbRules = new System.Windows.Forms.ListBox();
            this.tpTasks = new System.Windows.Forms.TabPage();
            this.lbDaily = new System.Windows.Forms.ListBox();
            this.tpEvents = new System.Windows.Forms.TabPage();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbEvent = new System.Windows.Forms.ComboBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.lbEvents = new System.Windows.Forms.ListBox();
            this.tpComplaints = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveMessage = new System.Windows.Forms.Button();
            this.lbAnswers = new System.Windows.Forms.ListBox();
            this.btnSendComplaint = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbComp = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblComplaint = new System.Windows.Forms.Label();
            this.tpSendMessages = new System.Windows.Forms.TabPage();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.cbStudentsFromThisBuilding = new System.Windows.Forms.ComboBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lblWriteMessage = new System.Windows.Forms.Label();
            this.tbSendMessage = new System.Windows.Forms.TextBox();
            this.lblChooseStudentFromThisBuilding = new System.Windows.Forms.Label();
            this.tpSharedItems = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbItemQuantity = new System.Windows.Forms.TextBox();
            this.tbItemPrice = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbAddedItem = new System.Windows.Forms.TextBox();
            this.btnAddSharedItem = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tpRules.SuspendLayout();
            this.tpTasks.SuspendLayout();
            this.tpEvents.SuspendLayout();
            this.tpComplaints.SuspendLayout();
            this.tpSendMessages.SuspendLayout();
            this.tpSharedItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblBack.Location = new System.Drawing.Point(521, 7);
            this.lblBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(45, 20);
            this.lblBack.TabIndex = 1;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpRules);
            this.tabControl.Controls.Add(this.tpTasks);
            this.tabControl.Controls.Add(this.tpEvents);
            this.tabControl.Controls.Add(this.tpComplaints);
            this.tabControl.Controls.Add(this.tpSendMessages);
            this.tabControl.Controls.Add(this.tpSharedItems);
            this.tabControl.Location = new System.Drawing.Point(0, 75);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(591, 365);
            this.tabControl.TabIndex = 2;
            // 
            // tpRules
            // 
            this.tpRules.BackColor = System.Drawing.Color.Gainsboro;
            this.tpRules.Controls.Add(this.lblRules);
            this.tpRules.Controls.Add(this.lbRules);
            this.tpRules.Location = new System.Drawing.Point(4, 22);
            this.tpRules.Margin = new System.Windows.Forms.Padding(2);
            this.tpRules.Name = "tpRules";
            this.tpRules.Padding = new System.Windows.Forms.Padding(2);
            this.tpRules.Size = new System.Drawing.Size(583, 339);
            this.tpRules.TabIndex = 0;
            this.tpRules.Text = "Rules";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Location = new System.Drawing.Point(250, 28);
            this.lblRules.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(124, 13);
            this.lblRules.TabIndex = 3;
            this.lblRules.Text = "The student house rules:";
            // 
            // lbRules
            // 
            this.lbRules.FormattingEnabled = true;
            this.lbRules.Location = new System.Drawing.Point(253, 44);
            this.lbRules.Margin = new System.Windows.Forms.Padding(2);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(308, 277);
            this.lbRules.TabIndex = 2;
            // 
            // tpTasks
            // 
            this.tpTasks.BackColor = System.Drawing.Color.Gainsboro;
            this.tpTasks.Controls.Add(this.lbDaily);
            this.tpTasks.Location = new System.Drawing.Point(4, 22);
            this.tpTasks.Margin = new System.Windows.Forms.Padding(2);
            this.tpTasks.Name = "tpTasks";
            this.tpTasks.Padding = new System.Windows.Forms.Padding(2);
            this.tpTasks.Size = new System.Drawing.Size(583, 339);
            this.tpTasks.TabIndex = 1;
            this.tpTasks.Text = "Tasks";
            // 
            // lbDaily
            // 
            this.lbDaily.FormattingEnabled = true;
            this.lbDaily.Location = new System.Drawing.Point(6, 19);
            this.lbDaily.Margin = new System.Windows.Forms.Padding(2);
            this.lbDaily.Name = "lbDaily";
            this.lbDaily.Size = new System.Drawing.Size(563, 316);
            this.lbDaily.TabIndex = 0;
            // 
            // tpEvents
            // 
            this.tpEvents.BackColor = System.Drawing.Color.Gainsboro;
            this.tpEvents.Controls.Add(this.lblTime);
            this.tpEvents.Controls.Add(this.lblDay);
            this.tpEvents.Controls.Add(this.lblEvent);
            this.tpEvents.Controls.Add(this.cbTime);
            this.tpEvents.Controls.Add(this.cbDay);
            this.tpEvents.Controls.Add(this.cbEvent);
            this.tpEvents.Controls.Add(this.btnAddEvent);
            this.tpEvents.Controls.Add(this.lbEvents);
            this.tpEvents.Location = new System.Drawing.Point(4, 22);
            this.tpEvents.Margin = new System.Windows.Forms.Padding(2);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Padding = new System.Windows.Forms.Padding(2);
            this.tpEvents.Size = new System.Drawing.Size(583, 339);
            this.tpEvents.TabIndex = 2;
            this.tpEvents.Text = "Events";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(496, 14);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(77, 13);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Choose a time:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(371, 14);
            this.lblDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(75, 13);
            this.lblDay.TabIndex = 6;
            this.lblDay.Text = "Choose a day:";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(218, 14);
            this.lblEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(91, 13);
            this.lblEvent.TabIndex = 5;
            this.lblEvent.Text = "Choose an event:";
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
            this.cbTime.Location = new System.Drawing.Point(498, 43);
            this.cbTime.Margin = new System.Windows.Forms.Padding(2);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(72, 21);
            this.cbTime.TabIndex = 4;
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(374, 43);
            this.cbDay.Margin = new System.Windows.Forms.Padding(2);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(92, 21);
            this.cbDay.TabIndex = 3;
            // 
            // cbEvent
            // 
            this.cbEvent.FormattingEnabled = true;
            this.cbEvent.Items.AddRange(new object[] {
            "Small Group Gathering",
            "Small Party",
            "Friend / Parents coming over for a few day"});
            this.cbEvent.Location = new System.Drawing.Point(220, 43);
            this.cbEvent.Margin = new System.Windows.Forms.Padding(2);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(120, 21);
            this.cbEvent.TabIndex = 2;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.Location = new System.Drawing.Point(6, 5);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(92, 58);
            this.btnAddEvent.TabIndex = 1;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // lbEvents
            // 
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.Location = new System.Drawing.Point(8, 77);
            this.lbEvents.Margin = new System.Windows.Forms.Padding(2);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(557, 251);
            this.lbEvents.TabIndex = 0;
            // 
            // tpComplaints
            // 
            this.tpComplaints.BackColor = System.Drawing.Color.Gainsboro;
            this.tpComplaints.Controls.Add(this.label1);
            this.tpComplaints.Controls.Add(this.btnRemoveMessage);
            this.tpComplaints.Controls.Add(this.lbAnswers);
            this.tpComplaints.Controls.Add(this.btnSendComplaint);
            this.tpComplaints.Controls.Add(this.dtpDate);
            this.tpComplaints.Controls.Add(this.tbComp);
            this.tpComplaints.Controls.Add(this.lblDate);
            this.tpComplaints.Controls.Add(this.lblComplaint);
            this.tpComplaints.Location = new System.Drawing.Point(4, 22);
            this.tpComplaints.Margin = new System.Windows.Forms.Padding(2);
            this.tpComplaints.Name = "tpComplaints";
            this.tpComplaints.Padding = new System.Windows.Forms.Padding(2);
            this.tpComplaints.Size = new System.Drawing.Size(583, 339);
            this.tpComplaints.TabIndex = 3;
            this.tpComplaints.Text = "Complaints";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Answers to complaints:";
            // 
            // btnRemoveMessage
            // 
            this.btnRemoveMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMessage.Location = new System.Drawing.Point(482, 122);
            this.btnRemoveMessage.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveMessage.Name = "btnRemoveMessage";
            this.btnRemoveMessage.Size = new System.Drawing.Size(98, 73);
            this.btnRemoveMessage.TabIndex = 6;
            this.btnRemoveMessage.Text = "Remove Message";
            this.btnRemoveMessage.UseVisualStyleBackColor = true;
            this.btnRemoveMessage.Click += new System.EventHandler(this.btnRemoveMessage_Click);
            // 
            // lbAnswers
            // 
            this.lbAnswers.FormattingEnabled = true;
            this.lbAnswers.Location = new System.Drawing.Point(23, 122);
            this.lbAnswers.Margin = new System.Windows.Forms.Padding(2);
            this.lbAnswers.Name = "lbAnswers";
            this.lbAnswers.Size = new System.Drawing.Size(456, 212);
            this.lbAnswers.TabIndex = 5;
            // 
            // btnSendComplaint
            // 
            this.btnSendComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendComplaint.Location = new System.Drawing.Point(356, 37);
            this.btnSendComplaint.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendComplaint.Name = "btnSendComplaint";
            this.btnSendComplaint.Size = new System.Drawing.Size(138, 48);
            this.btnSendComplaint.TabIndex = 4;
            this.btnSendComplaint.Text = "Send Complaint";
            this.btnSendComplaint.UseVisualStyleBackColor = true;
            this.btnSendComplaint.Click += new System.EventHandler(this.btnSendComplaint_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(133, 57);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(204, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // tbComp
            // 
            this.tbComp.Location = new System.Drawing.Point(133, 15);
            this.tbComp.Margin = new System.Windows.Forms.Padding(2);
            this.tbComp.Name = "tbComp";
            this.tbComp.Size = new System.Drawing.Size(362, 20);
            this.tbComp.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(21, 57);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(93, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date of complaint:";
            // 
            // lblComplaint
            // 
            this.lblComplaint.AutoSize = true;
            this.lblComplaint.Location = new System.Drawing.Point(21, 15);
            this.lblComplaint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComplaint.Name = "lblComplaint";
            this.lblComplaint.Size = new System.Drawing.Size(56, 13);
            this.lblComplaint.TabIndex = 0;
            this.lblComplaint.Text = "Complaint:";
            // 
            // tpSendMessages
            // 
            this.tpSendMessages.BackColor = System.Drawing.Color.Gainsboro;
            this.tpSendMessages.Controls.Add(this.lbMessages);
            this.tpSendMessages.Controls.Add(this.cbStudentsFromThisBuilding);
            this.tpSendMessages.Controls.Add(this.btnSendMessage);
            this.tpSendMessages.Controls.Add(this.lblWriteMessage);
            this.tpSendMessages.Controls.Add(this.tbSendMessage);
            this.tpSendMessages.Controls.Add(this.lblChooseStudentFromThisBuilding);
            this.tpSendMessages.Location = new System.Drawing.Point(4, 22);
            this.tpSendMessages.Margin = new System.Windows.Forms.Padding(2);
            this.tpSendMessages.Name = "tpSendMessages";
            this.tpSendMessages.Padding = new System.Windows.Forms.Padding(2);
            this.tpSendMessages.Size = new System.Drawing.Size(583, 339);
            this.tpSendMessages.TabIndex = 4;
            this.tpSendMessages.Text = "Send messages";
            // 
            // lbMessages
            // 
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.Location = new System.Drawing.Point(325, 29);
            this.lbMessages.Margin = new System.Windows.Forms.Padding(2);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(247, 290);
            this.lbMessages.TabIndex = 7;
            // 
            // cbStudentsFromThisBuilding
            // 
            this.cbStudentsFromThisBuilding.FormattingEnabled = true;
            this.cbStudentsFromThisBuilding.Location = new System.Drawing.Point(24, 57);
            this.cbStudentsFromThisBuilding.Margin = new System.Windows.Forms.Padding(2);
            this.cbStudentsFromThisBuilding.Name = "cbStudentsFromThisBuilding";
            this.cbStudentsFromThisBuilding.Size = new System.Drawing.Size(162, 21);
            this.cbStudentsFromThisBuilding.TabIndex = 6;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMessage.Location = new System.Drawing.Point(24, 136);
            this.btnSendMessage.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(160, 59);
            this.btnSendMessage.TabIndex = 5;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // lblWriteMessage
            // 
            this.lblWriteMessage.AutoSize = true;
            this.lblWriteMessage.Location = new System.Drawing.Point(22, 87);
            this.lblWriteMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWriteMessage.Name = "lblWriteMessage";
            this.lblWriteMessage.Size = new System.Drawing.Size(89, 13);
            this.lblWriteMessage.TabIndex = 4;
            this.lblWriteMessage.Text = "Write a message:";
            // 
            // tbSendMessage
            // 
            this.tbSendMessage.Location = new System.Drawing.Point(6, 113);
            this.tbSendMessage.Margin = new System.Windows.Forms.Padding(2);
            this.tbSendMessage.Name = "tbSendMessage";
            this.tbSendMessage.Size = new System.Drawing.Size(278, 20);
            this.tbSendMessage.TabIndex = 3;
            // 
            // lblChooseStudentFromThisBuilding
            // 
            this.lblChooseStudentFromThisBuilding.AutoSize = true;
            this.lblChooseStudentFromThisBuilding.Location = new System.Drawing.Point(22, 22);
            this.lblChooseStudentFromThisBuilding.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChooseStudentFromThisBuilding.Name = "lblChooseStudentFromThisBuilding";
            this.lblChooseStudentFromThisBuilding.Size = new System.Drawing.Size(93, 13);
            this.lblChooseStudentFromThisBuilding.TabIndex = 1;
            this.lblChooseStudentFromThisBuilding.Text = "Choose a student:";
            // 
            // tpSharedItems
            // 
            this.tpSharedItems.Controls.Add(this.button1);
            this.tpSharedItems.Controls.Add(this.label4);
            this.tpSharedItems.Controls.Add(this.label3);
            this.tpSharedItems.Controls.Add(this.label2);
            this.tpSharedItems.Controls.Add(this.tbItemQuantity);
            this.tpSharedItems.Controls.Add(this.tbItemPrice);
            this.tpSharedItems.Controls.Add(this.listBox1);
            this.tpSharedItems.Controls.Add(this.tbAddedItem);
            this.tpSharedItems.Controls.Add(this.btnAddSharedItem);
            this.tpSharedItems.Location = new System.Drawing.Point(4, 22);
            this.tpSharedItems.Name = "tpSharedItems";
            this.tpSharedItems.Size = new System.Drawing.Size(583, 339);
            this.tpSharedItems.TabIndex = 5;
            this.tpSharedItems.Text = "Shared items";
            this.tpSharedItems.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "price per piece";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item ";
            // 
            // tbItemQuantity
            // 
            this.tbItemQuantity.Location = new System.Drawing.Point(96, 66);
            this.tbItemQuantity.Name = "tbItemQuantity";
            this.tbItemQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbItemQuantity.TabIndex = 4;
            // 
            // tbItemPrice
            // 
            this.tbItemPrice.Location = new System.Drawing.Point(96, 40);
            this.tbItemPrice.Name = "tbItemPrice";
            this.tbItemPrice.Size = new System.Drawing.Size(100, 20);
            this.tbItemPrice.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(328, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(234, 173);
            this.listBox1.TabIndex = 2;
            // 
            // tbAddedItem
            // 
            this.tbAddedItem.Location = new System.Drawing.Point(96, 14);
            this.tbAddedItem.Name = "tbAddedItem";
            this.tbAddedItem.Size = new System.Drawing.Size(100, 20);
            this.tbAddedItem.TabIndex = 1;
            // 
            // btnAddSharedItem
            // 
            this.btnAddSharedItem.Location = new System.Drawing.Point(96, 92);
            this.btnAddSharedItem.Name = "btnAddSharedItem";
            this.btnAddSharedItem.Size = new System.Drawing.Size(100, 23);
            this.btnAddSharedItem.TabIndex = 0;
            this.btnAddSharedItem.Text = "Share item";
            this.btnAddSharedItem.UseVisualStyleBackColor = true;
            this.btnAddSharedItem.Click += new System.EventHandler(this.btnAddSharedItem_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(9, 7);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(52, 13);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Share item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 439);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.tabControl.ResumeLayout(false);
            this.tpRules.ResumeLayout(false);
            this.tpRules.PerformLayout();
            this.tpTasks.ResumeLayout(false);
            this.tpEvents.ResumeLayout(false);
            this.tpEvents.PerformLayout();
            this.tpComplaints.ResumeLayout(false);
            this.tpComplaints.PerformLayout();
            this.tpSendMessages.ResumeLayout(false);
            this.tpSendMessages.PerformLayout();
            this.tpSharedItems.ResumeLayout(false);
            this.tpSharedItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpRules;
        private System.Windows.Forms.TabPage tpTasks;
        private System.Windows.Forms.ListBox lbRules;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ListBox lbDaily;
        private System.Windows.Forms.TabPage tpEvents;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbEvent;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.ListBox lbEvents;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.TabPage tpComplaints;
        private System.Windows.Forms.Button btnSendComplaint;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbComp;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblComplaint;
        private System.Windows.Forms.ListBox lbAnswers;
        private System.Windows.Forms.Button btnRemoveMessage;
        private System.Windows.Forms.TabPage tpSendMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChooseStudentFromThisBuilding;
        private System.Windows.Forms.TextBox tbSendMessage;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Label lblWriteMessage;
        private System.Windows.Forms.ComboBox cbStudentsFromThisBuilding;
        private System.Windows.Forms.ListBox lbMessages;
        private System.Windows.Forms.TabPage tpSharedItems;
        private System.Windows.Forms.TextBox tbItemQuantity;
        private System.Windows.Forms.TextBox tbItemPrice;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbAddedItem;
        private System.Windows.Forms.Button btnAddSharedItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
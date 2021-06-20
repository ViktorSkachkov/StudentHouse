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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRules = new System.Windows.Forms.Label();
            this.lbRules = new System.Windows.Forms.ListBox();
            this.tpTasks = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbDaily = new System.Windows.Forms.ListBox();
            this.tpEvents = new System.Windows.Forms.TabPage();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblChooseDay = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnRemoveEvent = new System.Windows.Forms.Button();
            this.lblEvent = new System.Windows.Forms.Label();
            this.cbEvent = new System.Windows.Forms.ComboBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.lbEvents = new System.Windows.Forms.ListBox();
            this.tpComplaints = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveMessage = new System.Windows.Forms.Button();
            this.lbAnswers = new System.Windows.Forms.ListBox();
            this.btnSendComplaint = new System.Windows.Forms.Button();
            this.tbComp = new System.Windows.Forms.TextBox();
            this.lblComplaint = new System.Windows.Forms.Label();
            this.tpSendMessages = new System.Windows.Forms.TabPage();
            this.btnDel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.cbStudentsFromThisBuilding = new System.Windows.Forms.ComboBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lblWriteMessage = new System.Windows.Forms.Label();
            this.tbSendMessage = new System.Windows.Forms.TextBox();
            this.lblChooseStudentFromThisBuilding = new System.Windows.Forms.Label();
            this.tpSharedItems = new System.Windows.Forms.TabPage();
            this.tbDeleteItem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbItemQuantity = new System.Windows.Forms.TextBox();
            this.tbItemPrice = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbAddedItem = new System.Windows.Forms.TextBox();
            this.btnAddSharedItem = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tpRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tpEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tpComplaints.SuspendLayout();
            this.tpSendMessages.SuspendLayout();
            this.tpSharedItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.Black;
            this.lblBack.Location = new System.Drawing.Point(683, 16);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(107, 29);
            this.lblBack.TabIndex = 1;
            this.lblBack.Text = "Log out ";
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
            this.tabControl.Location = new System.Drawing.Point(12, 56);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(787, 449);
            this.tabControl.TabIndex = 2;
            // 
            // tpRules
            // 
            this.tpRules.BackColor = System.Drawing.Color.LightGray;
            this.tpRules.Controls.Add(this.pictureBox1);
            this.tpRules.Controls.Add(this.lblRules);
            this.tpRules.Controls.Add(this.lbRules);
            this.tpRules.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpRules.Location = new System.Drawing.Point(4, 25);
            this.tpRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRules.Name = "tpRules";
            this.tpRules.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRules.Size = new System.Drawing.Size(779, 420);
            this.tpRules.TabIndex = 0;
            this.tpRules.Text = "Rules";
            this.tpRules.Click += new System.EventHandler(this.tpRules_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Student_House.Properties.Resources.Logo2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(560, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 217);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.Location = new System.Drawing.Point(12, 21);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(261, 21);
            this.lblRules.TabIndex = 3;
            this.lblRules.Text = "Mandatory Student Housing rules:";
            // 
            // lbRules
            // 
            this.lbRules.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRules.FormattingEnabled = true;
            this.lbRules.HorizontalScrollbar = true;
            this.lbRules.ItemHeight = 16;
            this.lbRules.Location = new System.Drawing.Point(16, 53);
            this.lbRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(535, 340);
            this.lbRules.TabIndex = 2;
            // 
            // tpTasks
            // 
            this.tpTasks.BackColor = System.Drawing.Color.LightGray;
            this.tpTasks.Controls.Add(this.label5);
            this.tpTasks.Controls.Add(this.pictureBox2);
            this.tpTasks.Controls.Add(this.lbDaily);
            this.tpTasks.Location = new System.Drawing.Point(4, 25);
            this.tpTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTasks.Name = "tpTasks";
            this.tpTasks.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTasks.Size = new System.Drawing.Size(779, 420);
            this.tpTasks.TabIndex = 1;
            this.tpTasks.Text = "Tasks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mandatory daily tasks:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Student_House.Properties.Resources.Logo2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(560, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 217);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lbDaily
            // 
            this.lbDaily.FormattingEnabled = true;
            this.lbDaily.HorizontalScrollbar = true;
            this.lbDaily.ItemHeight = 16;
            this.lbDaily.Location = new System.Drawing.Point(15, 54);
            this.lbDaily.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbDaily.Name = "lbDaily";
            this.lbDaily.Size = new System.Drawing.Size(536, 340);
            this.lbDaily.TabIndex = 0;
            // 
            // tpEvents
            // 
            this.tpEvents.BackColor = System.Drawing.Color.LightGray;
            this.tpEvents.Controls.Add(this.cbTime);
            this.tpEvents.Controls.Add(this.cbDay);
            this.tpEvents.Controls.Add(this.label7);
            this.tpEvents.Controls.Add(this.lblChooseDay);
            this.tpEvents.Controls.Add(this.pictureBox3);
            this.tpEvents.Controls.Add(this.btnRemoveEvent);
            this.tpEvents.Controls.Add(this.lblEvent);
            this.tpEvents.Controls.Add(this.cbEvent);
            this.tpEvents.Controls.Add(this.btnAddEvent);
            this.tpEvents.Controls.Add(this.lbEvents);
            this.tpEvents.Location = new System.Drawing.Point(4, 25);
            this.tpEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpEvents.Size = new System.Drawing.Size(779, 420);
            this.tpEvents.TabIndex = 2;
            this.tpEvents.Text = "Events";
            this.tpEvents.Click += new System.EventHandler(this.tpEvents_Click);
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
            this.cbTime.Location = new System.Drawing.Point(615, 50);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(121, 24);
            this.cbTime.TabIndex = 13;
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(471, 50);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(121, 24);
            this.cbDay.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(611, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Choose a time:";
            // 
            // lblChooseDay
            // 
            this.lblChooseDay.AutoSize = true;
            this.lblChooseDay.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseDay.Location = new System.Drawing.Point(467, 25);
            this.lblChooseDay.Name = "lblChooseDay";
            this.lblChooseDay.Size = new System.Drawing.Size(115, 21);
            this.lblChooseDay.TabIndex = 10;
            this.lblChooseDay.Text = "Choose a day:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Student_House.Properties.Resources.Logo2;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(563, 130);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(208, 217);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // btnRemoveEvent
            // 
            this.btnRemoveEvent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEvent.Location = new System.Drawing.Point(147, 15);
            this.btnRemoveEvent.Name = "btnRemoveEvent";
            this.btnRemoveEvent.Size = new System.Drawing.Size(136, 61);
            this.btnRemoveEvent.TabIndex = 8;
            this.btnRemoveEvent.Text = "Remove Event";
            this.btnRemoveEvent.UseVisualStyleBackColor = true;
            this.btnRemoveEvent.Click += new System.EventHandler(this.btnRemoveEvent_Click);
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.Location = new System.Drawing.Point(289, 25);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(139, 21);
            this.lblEvent.TabIndex = 5;
            this.lblEvent.Text = "Choose an event:";
            // 
            // cbEvent
            // 
            this.cbEvent.FormattingEnabled = true;
            this.cbEvent.Items.AddRange(new object[] {
            "Small Group Gathering",
            "Small Party",
            "Friend / Parents coming over for a few day"});
            this.cbEvent.Location = new System.Drawing.Point(293, 50);
            this.cbEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(159, 24);
            this.cbEvent.TabIndex = 2;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.Location = new System.Drawing.Point(11, 15);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(120, 62);
            this.btnAddEvent.TabIndex = 1;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // lbEvents
            // 
            this.lbEvents.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.HorizontalScrollbar = true;
            this.lbEvents.ItemHeight = 16;
            this.lbEvents.Location = new System.Drawing.Point(11, 95);
            this.lbEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(543, 308);
            this.lbEvents.TabIndex = 0;
            // 
            // tpComplaints
            // 
            this.tpComplaints.BackColor = System.Drawing.Color.LightGray;
            this.tpComplaints.Controls.Add(this.label1);
            this.tpComplaints.Controls.Add(this.btnRemoveMessage);
            this.tpComplaints.Controls.Add(this.lbAnswers);
            this.tpComplaints.Controls.Add(this.btnSendComplaint);
            this.tpComplaints.Controls.Add(this.tbComp);
            this.tpComplaints.Controls.Add(this.lblComplaint);
            this.tpComplaints.Location = new System.Drawing.Point(4, 25);
            this.tpComplaints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpComplaints.Name = "tpComplaints";
            this.tpComplaints.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpComplaints.Size = new System.Drawing.Size(779, 420);
            this.tpComplaints.TabIndex = 3;
            this.tpComplaints.Text = "Complaints";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Answers to complaints:";
            // 
            // btnRemoveMessage
            // 
            this.btnRemoveMessage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMessage.Location = new System.Drawing.Point(610, 82);
            this.btnRemoveMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveMessage.Name = "btnRemoveMessage";
            this.btnRemoveMessage.Size = new System.Drawing.Size(135, 65);
            this.btnRemoveMessage.TabIndex = 6;
            this.btnRemoveMessage.Text = "Remove Message";
            this.btnRemoveMessage.UseVisualStyleBackColor = true;
            this.btnRemoveMessage.Click += new System.EventHandler(this.btnRemoveMessage_Click);
            // 
            // lbAnswers
            // 
            this.lbAnswers.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnswers.FormattingEnabled = true;
            this.lbAnswers.HorizontalScrollbar = true;
            this.lbAnswers.ItemHeight = 21;
            this.lbAnswers.Location = new System.Drawing.Point(21, 163);
            this.lbAnswers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAnswers.Name = "lbAnswers";
            this.lbAnswers.Size = new System.Drawing.Size(724, 235);
            this.lbAnswers.TabIndex = 5;
            // 
            // btnSendComplaint
            // 
            this.btnSendComplaint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendComplaint.Location = new System.Drawing.Point(469, 82);
            this.btnSendComplaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendComplaint.Name = "btnSendComplaint";
            this.btnSendComplaint.Size = new System.Drawing.Size(135, 65);
            this.btnSendComplaint.TabIndex = 4;
            this.btnSendComplaint.Text = "Send Complaint";
            this.btnSendComplaint.UseVisualStyleBackColor = true;
            this.btnSendComplaint.Click += new System.EventHandler(this.btnSendComplaint_Click);
            // 
            // tbComp
            // 
            this.tbComp.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComp.Location = new System.Drawing.Point(122, 15);
            this.tbComp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbComp.Multiline = true;
            this.tbComp.Name = "tbComp";
            this.tbComp.Size = new System.Drawing.Size(623, 51);
            this.tbComp.TabIndex = 2;
            // 
            // lblComplaint
            // 
            this.lblComplaint.AutoSize = true;
            this.lblComplaint.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplaint.Location = new System.Drawing.Point(26, 14);
            this.lblComplaint.Name = "lblComplaint";
            this.lblComplaint.Size = new System.Drawing.Size(90, 21);
            this.lblComplaint.TabIndex = 0;
            this.lblComplaint.Text = "Complaint:";
            // 
            // tpSendMessages
            // 
            this.tpSendMessages.BackColor = System.Drawing.Color.LightGray;
            this.tpSendMessages.Controls.Add(this.btnDel);
            this.tpSendMessages.Controls.Add(this.label6);
            this.tpSendMessages.Controls.Add(this.lbMessages);
            this.tpSendMessages.Controls.Add(this.cbStudentsFromThisBuilding);
            this.tpSendMessages.Controls.Add(this.btnSendMessage);
            this.tpSendMessages.Controls.Add(this.lblWriteMessage);
            this.tpSendMessages.Controls.Add(this.tbSendMessage);
            this.tpSendMessages.Controls.Add(this.lblChooseStudentFromThisBuilding);
            this.tpSendMessages.Location = new System.Drawing.Point(4, 25);
            this.tpSendMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpSendMessages.Name = "tpSendMessages";
            this.tpSendMessages.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpSendMessages.Size = new System.Drawing.Size(779, 420);
            this.tpSendMessages.TabIndex = 4;
            this.tpSendMessages.Text = "Send messages";
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(222, 253);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(155, 64);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Recent messages:";
            // 
            // lbMessages
            // 
            this.lbMessages.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.HorizontalScrollbar = true;
            this.lbMessages.ItemHeight = 16;
            this.lbMessages.Location = new System.Drawing.Point(408, 68);
            this.lbMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(353, 308);
            this.lbMessages.TabIndex = 7;
            // 
            // cbStudentsFromThisBuilding
            // 
            this.cbStudentsFromThisBuilding.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStudentsFromThisBuilding.FormattingEnabled = true;
            this.cbStudentsFromThisBuilding.Location = new System.Drawing.Point(33, 68);
            this.cbStudentsFromThisBuilding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStudentsFromThisBuilding.Name = "cbStudentsFromThisBuilding";
            this.cbStudentsFromThisBuilding.Size = new System.Drawing.Size(227, 24);
            this.cbStudentsFromThisBuilding.TabIndex = 6;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMessage.Location = new System.Drawing.Point(32, 253);
            this.btnSendMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(161, 64);
            this.btnSendMessage.TabIndex = 5;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // lblWriteMessage
            // 
            this.lblWriteMessage.AutoSize = true;
            this.lblWriteMessage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteMessage.Location = new System.Drawing.Point(28, 112);
            this.lblWriteMessage.Name = "lblWriteMessage";
            this.lblWriteMessage.Size = new System.Drawing.Size(167, 24);
            this.lblWriteMessage.TabIndex = 4;
            this.lblWriteMessage.Text = "Write a message:";
            // 
            // tbSendMessage
            // 
            this.tbSendMessage.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSendMessage.Location = new System.Drawing.Point(32, 139);
            this.tbSendMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSendMessage.Multiline = true;
            this.tbSendMessage.Name = "tbSendMessage";
            this.tbSendMessage.Size = new System.Drawing.Size(345, 101);
            this.tbSendMessage.TabIndex = 3;
            // 
            // lblChooseStudentFromThisBuilding
            // 
            this.lblChooseStudentFromThisBuilding.AutoSize = true;
            this.lblChooseStudentFromThisBuilding.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseStudentFromThisBuilding.Location = new System.Drawing.Point(28, 38);
            this.lblChooseStudentFromThisBuilding.Name = "lblChooseStudentFromThisBuilding";
            this.lblChooseStudentFromThisBuilding.Size = new System.Drawing.Size(172, 24);
            this.lblChooseStudentFromThisBuilding.TabIndex = 1;
            this.lblChooseStudentFromThisBuilding.Text = "Choose a student:";
            // 
            // tpSharedItems
            // 
            this.tpSharedItems.BackColor = System.Drawing.Color.LightGray;
            this.tpSharedItems.Controls.Add(this.tbDeleteItem);
            this.tpSharedItems.Controls.Add(this.label8);
            this.tpSharedItems.Controls.Add(this.btnDeleteItem);
            this.tpSharedItems.Controls.Add(this.label4);
            this.tpSharedItems.Controls.Add(this.label3);
            this.tpSharedItems.Controls.Add(this.label2);
            this.tpSharedItems.Controls.Add(this.tbItemQuantity);
            this.tpSharedItems.Controls.Add(this.tbItemPrice);
            this.tpSharedItems.Controls.Add(this.listBox1);
            this.tpSharedItems.Controls.Add(this.tbAddedItem);
            this.tpSharedItems.Controls.Add(this.btnAddSharedItem);
            this.tpSharedItems.Location = new System.Drawing.Point(4, 25);
            this.tpSharedItems.Margin = new System.Windows.Forms.Padding(4);
            this.tpSharedItems.Name = "tpSharedItems";
            this.tpSharedItems.Size = new System.Drawing.Size(779, 420);
            this.tpSharedItems.TabIndex = 5;
            this.tpSharedItems.Text = "Shared items";
            // 
            // tbDeleteItem
            // 
            this.tbDeleteItem.Location = new System.Drawing.Point(534, 243);
            this.tbDeleteItem.Name = "tbDeleteItem";
            this.tbDeleteItem.Size = new System.Drawing.Size(219, 22);
            this.tbDeleteItem.TabIndex = 13;
            this.tbDeleteItem.TextChanged += new System.EventHandler(this.tbDeleteItem_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(531, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 42);
            this.label8.TabIndex = 12;
            this.label8.Text = "Write the name of \r\nthe item you want to delete:";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Location = new System.Drawing.Point(534, 271);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(219, 58);
            this.btnDeleteItem.TabIndex = 11;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price per Unit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item:";
            // 
            // tbItemQuantity
            // 
            this.tbItemQuantity.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemQuantity.Location = new System.Drawing.Point(139, 103);
            this.tbItemQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.tbItemQuantity.Name = "tbItemQuantity";
            this.tbItemQuantity.Size = new System.Drawing.Size(169, 23);
            this.tbItemQuantity.TabIndex = 4;
            // 
            // tbItemPrice
            // 
            this.tbItemPrice.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemPrice.Location = new System.Drawing.Point(139, 62);
            this.tbItemPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbItemPrice.Name = "tbItemPrice";
            this.tbItemPrice.Size = new System.Drawing.Size(169, 23);
            this.tbItemPrice.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(18, 144);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(490, 256);
            this.listBox1.TabIndex = 2;
            // 
            // tbAddedItem
            // 
            this.tbAddedItem.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddedItem.Location = new System.Drawing.Point(139, 21);
            this.tbAddedItem.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddedItem.Name = "tbAddedItem";
            this.tbAddedItem.Size = new System.Drawing.Size(169, 23);
            this.tbAddedItem.TabIndex = 1;
            // 
            // btnAddSharedItem
            // 
            this.btnAddSharedItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSharedItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddSharedItem.Location = new System.Drawing.Point(349, 41);
            this.btnAddSharedItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSharedItem.Name = "btnAddSharedItem";
            this.btnAddSharedItem.Size = new System.Drawing.Size(159, 58);
            this.btnAddSharedItem.TabIndex = 0;
            this.btnAddSharedItem.Text = "Share item";
            this.btnAddSharedItem.UseVisualStyleBackColor = true;
            this.btnAddSharedItem.Click += new System.EventHandler(this.btnAddSharedItem_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 16);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(92, 24);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(822, 517);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.tabControl.ResumeLayout(false);
            this.tpRules.ResumeLayout(false);
            this.tpRules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpTasks.ResumeLayout(false);
            this.tpTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tpEvents.ResumeLayout(false);
            this.tpEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.ComboBox cbEvent;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.ListBox lbEvents;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.TabPage tpComplaints;
        private System.Windows.Forms.Button btnSendComplaint;
        private System.Windows.Forms.TextBox tbComp;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveEvent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddSharedItem;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblChooseDay;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.TextBox tbDeleteItem;
        private System.Windows.Forms.Label label8;
    }
}
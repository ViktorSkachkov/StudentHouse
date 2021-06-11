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
            this.tbComp = new System.Windows.Forms.TextBox();
            this.lblComplaint = new System.Windows.Forms.Label();
            this.tpSendMessages = new System.Windows.Forms.TabPage();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.cbStudentsFromThisBuilding = new System.Windows.Forms.ComboBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lblWriteMessage = new System.Windows.Forms.Label();
            this.tbSendMessage = new System.Windows.Forms.TextBox();
            this.lblChooseStudentFromThisBuilding = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tpRules.SuspendLayout();
            this.tpTasks.SuspendLayout();
            this.tpEvents.SuspendLayout();
            this.tpComplaints.SuspendLayout();
            this.tpSendMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblBack.Location = new System.Drawing.Point(695, 9);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(56, 25);
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
            this.tabControl.Location = new System.Drawing.Point(0, 92);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(788, 449);
            this.tabControl.TabIndex = 2;
            // 
            // tpRules
            // 
            this.tpRules.BackColor = System.Drawing.Color.Gainsboro;
            this.tpRules.Controls.Add(this.lblRules);
            this.tpRules.Controls.Add(this.lbRules);
            this.tpRules.Location = new System.Drawing.Point(4, 25);
            this.tpRules.Name = "tpRules";
            this.tpRules.Padding = new System.Windows.Forms.Padding(3);
            this.tpRules.Size = new System.Drawing.Size(780, 420);
            this.tpRules.TabIndex = 0;
            this.tpRules.Text = "Rules";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Location = new System.Drawing.Point(334, 34);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(166, 17);
            this.lblRules.TabIndex = 3;
            this.lblRules.Text = "The student house rules:";
            // 
            // lbRules
            // 
            this.lbRules.FormattingEnabled = true;
            this.lbRules.ItemHeight = 16;
            this.lbRules.Location = new System.Drawing.Point(337, 54);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(410, 340);
            this.lbRules.TabIndex = 2;
            // 
            // tpTasks
            // 
            this.tpTasks.BackColor = System.Drawing.Color.Gainsboro;
            this.tpTasks.Controls.Add(this.lbDaily);
            this.tpTasks.Location = new System.Drawing.Point(4, 25);
            this.tpTasks.Name = "tpTasks";
            this.tpTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tpTasks.Size = new System.Drawing.Size(780, 420);
            this.tpTasks.TabIndex = 1;
            this.tpTasks.Text = "Tasks";
            // 
            // lbDaily
            // 
            this.lbDaily.FormattingEnabled = true;
            this.lbDaily.ItemHeight = 16;
            this.lbDaily.Location = new System.Drawing.Point(8, 23);
            this.lbDaily.Name = "lbDaily";
            this.lbDaily.Size = new System.Drawing.Size(749, 388);
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
            this.tpEvents.Location = new System.Drawing.Point(4, 25);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tpEvents.Size = new System.Drawing.Size(780, 420);
            this.tpEvents.TabIndex = 2;
            this.tpEvents.Text = "Events";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(661, 17);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(102, 17);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Choose a time:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(495, 17);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(99, 17);
            this.lblDay.TabIndex = 6;
            this.lblDay.Text = "Choose a day:";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(291, 17);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(119, 17);
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
            this.cbTime.Location = new System.Drawing.Point(664, 53);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(94, 24);
            this.cbTime.TabIndex = 4;
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(498, 53);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(121, 24);
            this.cbDay.TabIndex = 3;
            // 
            // cbEvent
            // 
            this.cbEvent.FormattingEnabled = true;
            this.cbEvent.Items.AddRange(new object[] {
            "Small Group Gathering",
            "Small Party",
            "Friend / Parents coming over for a few day"});
            this.cbEvent.Location = new System.Drawing.Point(294, 53);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(159, 24);
            this.cbEvent.TabIndex = 2;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.Location = new System.Drawing.Point(8, 6);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(123, 71);
            this.btnAddEvent.TabIndex = 1;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // lbEvents
            // 
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.ItemHeight = 16;
            this.lbEvents.Location = new System.Drawing.Point(11, 95);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(741, 308);
            this.lbEvents.TabIndex = 0;
            // 
            // tpComplaints
            // 
            this.tpComplaints.BackColor = System.Drawing.Color.Gainsboro;
            this.tpComplaints.Controls.Add(this.label1);
            this.tpComplaints.Controls.Add(this.btnRemoveMessage);
            this.tpComplaints.Controls.Add(this.lbAnswers);
            this.tpComplaints.Controls.Add(this.btnSendComplaint);
            this.tpComplaints.Controls.Add(this.tbComp);
            this.tpComplaints.Controls.Add(this.lblComplaint);
            this.tpComplaints.Location = new System.Drawing.Point(4, 25);
            this.tpComplaints.Name = "tpComplaints";
            this.tpComplaints.Padding = new System.Windows.Forms.Padding(3);
            this.tpComplaints.Size = new System.Drawing.Size(780, 420);
            this.tpComplaints.TabIndex = 3;
            this.tpComplaints.Text = "Complaints";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Answers to complaints:";
            // 
            // btnRemoveMessage
            // 
            this.btnRemoveMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMessage.Location = new System.Drawing.Point(643, 150);
            this.btnRemoveMessage.Name = "btnRemoveMessage";
            this.btnRemoveMessage.Size = new System.Drawing.Size(131, 90);
            this.btnRemoveMessage.TabIndex = 6;
            this.btnRemoveMessage.Text = "Remove Message";
            this.btnRemoveMessage.UseVisualStyleBackColor = true;
            this.btnRemoveMessage.Click += new System.EventHandler(this.btnRemoveMessage_Click);
            // 
            // lbAnswers
            // 
            this.lbAnswers.FormattingEnabled = true;
            this.lbAnswers.ItemHeight = 16;
            this.lbAnswers.Location = new System.Drawing.Point(31, 150);
            this.lbAnswers.Name = "lbAnswers";
            this.lbAnswers.Size = new System.Drawing.Size(606, 260);
            this.lbAnswers.TabIndex = 5;
            // 
            // btnSendComplaint
            // 
            this.btnSendComplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendComplaint.Location = new System.Drawing.Point(474, 46);
            this.btnSendComplaint.Name = "btnSendComplaint";
            this.btnSendComplaint.Size = new System.Drawing.Size(184, 59);
            this.btnSendComplaint.TabIndex = 4;
            this.btnSendComplaint.Text = "Send Complaint";
            this.btnSendComplaint.UseVisualStyleBackColor = true;
            this.btnSendComplaint.Click += new System.EventHandler(this.btnSendComplaint_Click);
            // 
            // tbComp
            // 
            this.tbComp.Location = new System.Drawing.Point(177, 18);
            this.tbComp.Name = "tbComp";
            this.tbComp.Size = new System.Drawing.Size(481, 22);
            this.tbComp.TabIndex = 2;
            // 
            // lblComplaint
            // 
            this.lblComplaint.AutoSize = true;
            this.lblComplaint.Location = new System.Drawing.Point(28, 18);
            this.lblComplaint.Name = "lblComplaint";
            this.lblComplaint.Size = new System.Drawing.Size(74, 17);
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
            this.tpSendMessages.Location = new System.Drawing.Point(4, 25);
            this.tpSendMessages.Name = "tpSendMessages";
            this.tpSendMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tpSendMessages.Size = new System.Drawing.Size(780, 420);
            this.tpSendMessages.TabIndex = 4;
            this.tpSendMessages.Text = "Send messages";
            // 
            // lbMessages
            // 
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.ItemHeight = 16;
            this.lbMessages.Location = new System.Drawing.Point(433, 36);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(328, 356);
            this.lbMessages.TabIndex = 7;
            // 
            // cbStudentsFromThisBuilding
            // 
            this.cbStudentsFromThisBuilding.FormattingEnabled = true;
            this.cbStudentsFromThisBuilding.Location = new System.Drawing.Point(32, 70);
            this.cbStudentsFromThisBuilding.Name = "cbStudentsFromThisBuilding";
            this.cbStudentsFromThisBuilding.Size = new System.Drawing.Size(214, 24);
            this.cbStudentsFromThisBuilding.TabIndex = 6;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMessage.Location = new System.Drawing.Point(32, 167);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(214, 73);
            this.btnSendMessage.TabIndex = 5;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // lblWriteMessage
            // 
            this.lblWriteMessage.AutoSize = true;
            this.lblWriteMessage.Location = new System.Drawing.Point(29, 107);
            this.lblWriteMessage.Name = "lblWriteMessage";
            this.lblWriteMessage.Size = new System.Drawing.Size(118, 17);
            this.lblWriteMessage.TabIndex = 4;
            this.lblWriteMessage.Text = "Write a message:";
            // 
            // tbSendMessage
            // 
            this.tbSendMessage.Location = new System.Drawing.Point(8, 139);
            this.tbSendMessage.Name = "tbSendMessage";
            this.tbSendMessage.Size = new System.Drawing.Size(370, 22);
            this.tbSendMessage.TabIndex = 3;
            // 
            // lblChooseStudentFromThisBuilding
            // 
            this.lblChooseStudentFromThisBuilding.AutoSize = true;
            this.lblChooseStudentFromThisBuilding.Location = new System.Drawing.Point(29, 27);
            this.lblChooseStudentFromThisBuilding.Name = "lblChooseStudentFromThisBuilding";
            this.lblChooseStudentFromThisBuilding.Size = new System.Drawing.Size(123, 17);
            this.lblChooseStudentFromThisBuilding.TabIndex = 1;
            this.lblChooseStudentFromThisBuilding.Text = "Choose a student:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(66, 17);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblBack);
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
    }
}
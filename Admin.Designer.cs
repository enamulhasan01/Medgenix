namespace Medgenix
{
    partial class Admin
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
            this.HomePage = new System.Windows.Forms.Button();
            this.Notifications = new System.Windows.Forms.Button();
            this.MngDssData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MngDssDtaPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.ReviewData = new System.Windows.Forms.Button();
            this.MngModSup = new System.Windows.Forms.Panel();
            this.MngModSupClose = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.ManageUserStatus = new System.Windows.Forms.Button();
            this.ManageUserStatusPan = new System.Windows.Forms.Panel();
            this.ManageIC = new System.Windows.Forms.Button();
            this.ManageResearcher = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ManagePatient = new System.Windows.Forms.Button();
            this.ManageContributor = new System.Windows.Forms.Button();
            this.MngDssDtaPanel.SuspendLayout();
            this.MngModSup.SuspendLayout();
            this.ManageUserStatusPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePage
            // 
            this.HomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePage.Location = new System.Drawing.Point(13, 28);
            this.HomePage.Margin = new System.Windows.Forms.Padding(4);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(187, 52);
            this.HomePage.TabIndex = 1;
            this.HomePage.Text = "Home Page";
            this.HomePage.UseVisualStyleBackColor = true;
            this.HomePage.Click += new System.EventHandler(this.HomePage_Click);
            // 
            // Notifications
            // 
            this.Notifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notifications.Location = new System.Drawing.Point(1019, 57);
            this.Notifications.Margin = new System.Windows.Forms.Padding(4);
            this.Notifications.Name = "Notifications";
            this.Notifications.Size = new System.Drawing.Size(427, 52);
            this.Notifications.TabIndex = 4;
            this.Notifications.Text = "Data From Contributor and Moderator";
            this.Notifications.UseVisualStyleBackColor = true;
            this.Notifications.Click += new System.EventHandler(this.Notifications_Click);
            // 
            // MngDssData
            // 
            this.MngDssData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngDssData.Location = new System.Drawing.Point(37, 190);
            this.MngDssData.Margin = new System.Windows.Forms.Padding(4);
            this.MngDssData.Name = "MngDssData";
            this.MngDssData.Size = new System.Drawing.Size(349, 79);
            this.MngDssData.TabIndex = 5;
            this.MngDssData.Text = "Manage Disease Data";
            this.MngDssData.UseVisualStyleBackColor = true;
            this.MngDssData.Click += new System.EventHandler(this.MngDssData_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(532, 190);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 79);
            this.button1.TabIndex = 6;
            this.button1.Text = "Manage Moderators and Supervisors";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MngDssDtaPanel
            // 
            this.MngDssDtaPanel.Controls.Add(this.button2);
            this.MngDssDtaPanel.Controls.Add(this.Close);
            this.MngDssDtaPanel.Controls.Add(this.ReviewData);
            this.MngDssDtaPanel.Location = new System.Drawing.Point(37, 314);
            this.MngDssDtaPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MngDssDtaPanel.Name = "MngDssDtaPanel";
            this.MngDssDtaPanel.Size = new System.Drawing.Size(349, 217);
            this.MngDssDtaPanel.TabIndex = 7;
            this.MngDssDtaPanel.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(16, 36);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "View\r\n Available Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(112, 142);
            this.Close.Margin = new System.Windows.Forms.Padding(4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(123, 46);
            this.Close.TabIndex = 2;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ReviewData
            // 
            this.ReviewData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewData.Location = new System.Drawing.Point(203, 36);
            this.ReviewData.Margin = new System.Windows.Forms.Padding(4);
            this.ReviewData.Name = "ReviewData";
            this.ReviewData.Size = new System.Drawing.Size(131, 50);
            this.ReviewData.TabIndex = 1;
            this.ReviewData.Text = "Review Data";
            this.ReviewData.UseVisualStyleBackColor = true;
            this.ReviewData.Click += new System.EventHandler(this.ReviewData_Click);
            // 
            // MngModSup
            // 
            this.MngModSup.Controls.Add(this.MngModSupClose);
            this.MngModSup.Controls.Add(this.button3);
            this.MngModSup.Controls.Add(this.button4);
            this.MngModSup.Location = new System.Drawing.Point(532, 302);
            this.MngModSup.Margin = new System.Windows.Forms.Padding(4);
            this.MngModSup.Name = "MngModSup";
            this.MngModSup.Size = new System.Drawing.Size(363, 217);
            this.MngModSup.TabIndex = 8;
            this.MngModSup.Visible = false;
            // 
            // MngModSupClose
            // 
            this.MngModSupClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngModSupClose.Location = new System.Drawing.Point(117, 149);
            this.MngModSupClose.Margin = new System.Windows.Forms.Padding(4);
            this.MngModSupClose.Name = "MngModSupClose";
            this.MngModSupClose.Size = new System.Drawing.Size(128, 37);
            this.MngModSupClose.TabIndex = 2;
            this.MngModSupClose.Text = "Close";
            this.MngModSupClose.UseVisualStyleBackColor = true;
            this.MngModSupClose.Click += new System.EventHandler(this.MngModSupClose_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(205, 36);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 66);
            this.button3.TabIndex = 1;
            this.button3.Text = "Manage Supervisor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(15, 36);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 66);
            this.button4.TabIndex = 0;
            this.button4.Text = "Manage Moderator";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // LogOut
            // 
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.Location = new System.Drawing.Point(1259, 685);
            this.LogOut.Margin = new System.Windows.Forms.Padding(4);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(187, 52);
            this.LogOut.TabIndex = 9;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // ManageUserStatus
            // 
            this.ManageUserStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageUserStatus.Location = new System.Drawing.Point(1036, 190);
            this.ManageUserStatus.Margin = new System.Windows.Forms.Padding(4);
            this.ManageUserStatus.Name = "ManageUserStatus";
            this.ManageUserStatus.Size = new System.Drawing.Size(349, 79);
            this.ManageUserStatus.TabIndex = 10;
            this.ManageUserStatus.Text = "Manage User Status\r\n";
            this.ManageUserStatus.UseVisualStyleBackColor = true;
            this.ManageUserStatus.Click += new System.EventHandler(this.ManageStatus_Click);
            // 
            // ManageUserStatusPan
            // 
            this.ManageUserStatusPan.Controls.Add(this.ManageIC);
            this.ManageUserStatusPan.Controls.Add(this.ManageResearcher);
            this.ManageUserStatusPan.Controls.Add(this.button5);
            this.ManageUserStatusPan.Controls.Add(this.ManagePatient);
            this.ManageUserStatusPan.Controls.Add(this.ManageContributor);
            this.ManageUserStatusPan.Location = new System.Drawing.Point(967, 290);
            this.ManageUserStatusPan.Margin = new System.Windows.Forms.Padding(4);
            this.ManageUserStatusPan.Name = "ManageUserStatusPan";
            this.ManageUserStatusPan.Size = new System.Drawing.Size(463, 298);
            this.ManageUserStatusPan.TabIndex = 11;
            this.ManageUserStatusPan.Visible = false;
            // 
            // ManageIC
            // 
            this.ManageIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageIC.Location = new System.Drawing.Point(251, 137);
            this.ManageIC.Margin = new System.Windows.Forms.Padding(4);
            this.ManageIC.Name = "ManageIC";
            this.ManageIC.Size = new System.Drawing.Size(173, 66);
            this.ManageIC.TabIndex = 4;
            this.ManageIC.Text = "Manage Institutional Clint\r\n\r\n";
            this.ManageIC.UseVisualStyleBackColor = true;
            this.ManageIC.Click += new System.EventHandler(this.ManageIC_Click);
            // 
            // ManageResearcher
            // 
            this.ManageResearcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageResearcher.Location = new System.Drawing.Point(15, 137);
            this.ManageResearcher.Margin = new System.Windows.Forms.Padding(4);
            this.ManageResearcher.Name = "ManageResearcher";
            this.ManageResearcher.Size = new System.Drawing.Size(173, 66);
            this.ManageResearcher.TabIndex = 3;
            this.ManageResearcher.Text = "Manage Reasearcher\r\n\r\n";
            this.ManageResearcher.UseVisualStyleBackColor = true;
            this.ManageResearcher.Click += new System.EventHandler(this.ManageResearcher_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(169, 240);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 37);
            this.button5.TabIndex = 2;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ManagePatient
            // 
            this.ManagePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagePatient.Location = new System.Drawing.Point(251, 44);
            this.ManagePatient.Margin = new System.Windows.Forms.Padding(4);
            this.ManagePatient.Name = "ManagePatient";
            this.ManagePatient.Size = new System.Drawing.Size(168, 58);
            this.ManagePatient.TabIndex = 1;
            this.ManagePatient.Text = "Manage Patient";
            this.ManagePatient.UseVisualStyleBackColor = true;
            this.ManagePatient.Click += new System.EventHandler(this.ManagePatient_Click);
            // 
            // ManageContributor
            // 
            this.ManageContributor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageContributor.Location = new System.Drawing.Point(15, 36);
            this.ManageContributor.Margin = new System.Windows.Forms.Padding(4);
            this.ManageContributor.Name = "ManageContributor";
            this.ManageContributor.Size = new System.Drawing.Size(173, 66);
            this.ManageContributor.TabIndex = 0;
            this.ManageContributor.Text = "Manage Contributor\r\n";
            this.ManageContributor.UseVisualStyleBackColor = true;
            this.ManageContributor.Click += new System.EventHandler(this.ManageContributor_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 750);
            this.Controls.Add(this.ManageUserStatusPan);
            this.Controls.Add(this.ManageUserStatus);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.MngModSup);
            this.Controls.Add(this.MngDssDtaPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MngDssData);
            this.Controls.Add(this.Notifications);
            this.Controls.Add(this.HomePage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.MngDssDtaPanel.ResumeLayout(false);
            this.MngModSup.ResumeLayout(false);
            this.ManageUserStatusPan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomePage;
        private System.Windows.Forms.Button Notifications;
        private System.Windows.Forms.Button MngDssData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel MngDssDtaPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button ReviewData;
        private System.Windows.Forms.Panel MngModSup;
        private System.Windows.Forms.Button MngModSupClose;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button ManageUserStatus;
        private System.Windows.Forms.Panel ManageUserStatusPan;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button ManagePatient;
        private System.Windows.Forms.Button ManageContributor;
        private System.Windows.Forms.Button ManageResearcher;
        private System.Windows.Forms.Button ManageIC;
    }
}
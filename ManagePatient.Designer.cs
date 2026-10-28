namespace Medgenix
{
    partial class ManagePatient
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
            this.SearchPai = new System.Windows.Forms.Label();
            this.TextSearchPatient = new System.Windows.Forms.TextBox();
            this.MangePatientGoback = new System.Windows.Forms.Button();
            this.PatientMakeInAct = new System.Windows.Forms.Button();
            this.PatientMakeAct = new System.Windows.Forms.Button();
            this.ShowPatientStatus = new System.Windows.Forms.Button();
            this.PatientStatusDtaGrid = new System.Windows.Forms.DataGridView();
            this.ListOfPatientLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PatientStatusDtaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchPai
            // 
            this.SearchPai.AutoSize = true;
            this.SearchPai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPai.Location = new System.Drawing.Point(61, 138);
            this.SearchPai.Name = "SearchPai";
            this.SearchPai.Size = new System.Drawing.Size(331, 25);
            this.SearchPai.TabIndex = 18;
            this.SearchPai.Text = "Search Patient By User Name:";
            // 
            // TextSearchPatient
            // 
            this.TextSearchPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearchPatient.Location = new System.Drawing.Point(398, 137);
            this.TextSearchPatient.Name = "TextSearchPatient";
            this.TextSearchPatient.Size = new System.Drawing.Size(121, 26);
            this.TextSearchPatient.TabIndex = 17;
            this.TextSearchPatient.TextChanged += new System.EventHandler(this.TextSearchPatient_TextChanged);
            // 
            // MangePatientGoback
            // 
            this.MangePatientGoback.Font = new System.Drawing.Font("Gotham Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MangePatientGoback.Location = new System.Drawing.Point(665, 393);
            this.MangePatientGoback.Name = "MangePatientGoback";
            this.MangePatientGoback.Size = new System.Drawing.Size(97, 39);
            this.MangePatientGoback.TabIndex = 16;
            this.MangePatientGoback.Text = "Go Back";
            this.MangePatientGoback.UseVisualStyleBackColor = true;
            this.MangePatientGoback.Click += new System.EventHandler(this.MangePatientGoback_Click);
            // 
            // PatientMakeInAct
            // 
            this.PatientMakeInAct.Font = new System.Drawing.Font("Gotham Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientMakeInAct.Location = new System.Drawing.Point(619, 259);
            this.PatientMakeInAct.Name = "PatientMakeInAct";
            this.PatientMakeInAct.Size = new System.Drawing.Size(143, 41);
            this.PatientMakeInAct.TabIndex = 15;
            this.PatientMakeInAct.Text = "Make Inactive";
            this.PatientMakeInAct.UseVisualStyleBackColor = true;
            this.PatientMakeInAct.Click += new System.EventHandler(this.PatientMakeInAct_Click);
            // 
            // PatientMakeAct
            // 
            this.PatientMakeAct.Font = new System.Drawing.Font("Gotham Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientMakeAct.Location = new System.Drawing.Point(619, 195);
            this.PatientMakeAct.Name = "PatientMakeAct";
            this.PatientMakeAct.Size = new System.Drawing.Size(143, 41);
            this.PatientMakeAct.TabIndex = 14;
            this.PatientMakeAct.Text = "Make Active";
            this.PatientMakeAct.UseVisualStyleBackColor = true;
            this.PatientMakeAct.Click += new System.EventHandler(this.PatientMakeAct_Click);
            // 
            // ShowPatientStatus
            // 
            this.ShowPatientStatus.Font = new System.Drawing.Font("Gotham Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPatientStatus.Location = new System.Drawing.Point(101, 382);
            this.ShowPatientStatus.Name = "ShowPatientStatus";
            this.ShowPatientStatus.Size = new System.Drawing.Size(97, 39);
            this.ShowPatientStatus.TabIndex = 13;
            this.ShowPatientStatus.Text = "Show";
            this.ShowPatientStatus.UseVisualStyleBackColor = true;
            this.ShowPatientStatus.Click += new System.EventHandler(this.ShowPatientStatus_Click);
            // 
            // PatientStatusDtaGrid
            // 
            this.PatientStatusDtaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientStatusDtaGrid.Location = new System.Drawing.Point(101, 169);
            this.PatientStatusDtaGrid.MultiSelect = false;
            this.PatientStatusDtaGrid.Name = "PatientStatusDtaGrid";
            this.PatientStatusDtaGrid.RowHeadersWidth = 51;
            this.PatientStatusDtaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientStatusDtaGrid.Size = new System.Drawing.Size(460, 176);
            this.PatientStatusDtaGrid.TabIndex = 12;
            // 
            // ListOfPatientLevel
            // 
            this.ListOfPatientLevel.AutoSize = true;
            this.ListOfPatientLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfPatientLevel.Location = new System.Drawing.Point(140, 87);
            this.ListOfPatientLevel.Name = "ListOfPatientLevel";
            this.ListOfPatientLevel.Size = new System.Drawing.Size(285, 25);
            this.ListOfPatientLevel.TabIndex = 11;
            this.ListOfPatientLevel.Text = "List Of Patient with Status";
            // 
            // ManagePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 525);
            this.Controls.Add(this.SearchPai);
            this.Controls.Add(this.TextSearchPatient);
            this.Controls.Add(this.MangePatientGoback);
            this.Controls.Add(this.PatientMakeInAct);
            this.Controls.Add(this.PatientMakeAct);
            this.Controls.Add(this.ShowPatientStatus);
            this.Controls.Add(this.PatientStatusDtaGrid);
            this.Controls.Add(this.ListOfPatientLevel);
            this.Name = "ManagePatient";
            this.Text = "Manage Patient Account";
            this.Load += new System.EventHandler(this.ManagePatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientStatusDtaGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchPai;
        private System.Windows.Forms.TextBox TextSearchPatient;
        private System.Windows.Forms.Button MangePatientGoback;
        private System.Windows.Forms.Button PatientMakeInAct;
        private System.Windows.Forms.Button PatientMakeAct;
        private System.Windows.Forms.Button ShowPatientStatus;
        private System.Windows.Forms.DataGridView PatientStatusDtaGrid;
        private System.Windows.Forms.Label ListOfPatientLevel;
    }
}
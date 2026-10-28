namespace Medgenix
{
    partial class ManageResearcher
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
            this.SearchRese = new System.Windows.Forms.Label();
            this.TextSearchRese = new System.Windows.Forms.TextBox();
            this.MangeReseGoback = new System.Windows.Forms.Button();
            this.ReseMakeInAct = new System.Windows.Forms.Button();
            this.ReseMakeAct = new System.Windows.Forms.Button();
            this.ShowReseStatus = new System.Windows.Forms.Button();
            this.ReseStatusDtaGrid = new System.Windows.Forms.DataGridView();
            this.ListOfResearcherLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReseStatusDtaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchRese
            // 
            this.SearchRese.AutoSize = true;
            this.SearchRese.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchRese.Location = new System.Drawing.Point(12, 102);
            this.SearchRese.Name = "SearchRese";
            this.SearchRese.Size = new System.Drawing.Size(378, 25);
            this.SearchRese.TabIndex = 26;
            this.SearchRese.Text = "Search Researcher By User Name:";
            // 
            // TextSearchRese
            // 
            this.TextSearchRese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearchRese.Location = new System.Drawing.Point(418, 103);
            this.TextSearchRese.Name = "TextSearchRese";
            this.TextSearchRese.Size = new System.Drawing.Size(121, 26);
            this.TextSearchRese.TabIndex = 25;
            this.TextSearchRese.TextChanged += new System.EventHandler(this.TextSearchPatient_TextChanged);
            // 
            // MangeReseGoback
            // 
            this.MangeReseGoback.Font = new System.Drawing.Font("Gotham Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MangeReseGoback.Location = new System.Drawing.Point(654, 359);
            this.MangeReseGoback.Name = "MangeReseGoback";
            this.MangeReseGoback.Size = new System.Drawing.Size(97, 39);
            this.MangeReseGoback.TabIndex = 24;
            this.MangeReseGoback.Text = "Go Back";
            this.MangeReseGoback.UseVisualStyleBackColor = true;
            this.MangeReseGoback.Click += new System.EventHandler(this.MangeReseGoback_Click);
            // 
            // ReseMakeInAct
            // 
            this.ReseMakeInAct.Font = new System.Drawing.Font("Gotham Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReseMakeInAct.Location = new System.Drawing.Point(608, 225);
            this.ReseMakeInAct.Name = "ReseMakeInAct";
            this.ReseMakeInAct.Size = new System.Drawing.Size(143, 41);
            this.ReseMakeInAct.TabIndex = 23;
            this.ReseMakeInAct.Text = "Make Inactive";
            this.ReseMakeInAct.UseVisualStyleBackColor = true;
            this.ReseMakeInAct.Click += new System.EventHandler(this.ReseMakeInAct_Click);
            // 
            // ReseMakeAct
            // 
            this.ReseMakeAct.Font = new System.Drawing.Font("Gotham Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReseMakeAct.Location = new System.Drawing.Point(608, 161);
            this.ReseMakeAct.Name = "ReseMakeAct";
            this.ReseMakeAct.Size = new System.Drawing.Size(143, 41);
            this.ReseMakeAct.TabIndex = 22;
            this.ReseMakeAct.Text = "Make Active";
            this.ReseMakeAct.UseVisualStyleBackColor = true;
            this.ReseMakeAct.Click += new System.EventHandler(this.ReseMakeAct_Click);
            // 
            // ShowReseStatus
            // 
            this.ShowReseStatus.Font = new System.Drawing.Font("Gotham Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowReseStatus.Location = new System.Drawing.Point(90, 348);
            this.ShowReseStatus.Name = "ShowReseStatus";
            this.ShowReseStatus.Size = new System.Drawing.Size(97, 39);
            this.ShowReseStatus.TabIndex = 21;
            this.ShowReseStatus.Text = "Show";
            this.ShowReseStatus.UseVisualStyleBackColor = true;
            this.ShowReseStatus.Click += new System.EventHandler(this.ShowReseStatus_Click);
            // 
            // ReseStatusDtaGrid
            // 
            this.ReseStatusDtaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReseStatusDtaGrid.Location = new System.Drawing.Point(60, 135);
            this.ReseStatusDtaGrid.MultiSelect = false;
            this.ReseStatusDtaGrid.Name = "ReseStatusDtaGrid";
            this.ReseStatusDtaGrid.RowHeadersWidth = 51;
            this.ReseStatusDtaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReseStatusDtaGrid.Size = new System.Drawing.Size(479, 188);
            this.ReseStatusDtaGrid.TabIndex = 20;
            // 
            // ListOfResearcherLevel
            // 
            this.ListOfResearcherLevel.AutoSize = true;
            this.ListOfResearcherLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfResearcherLevel.Location = new System.Drawing.Point(129, 53);
            this.ListOfResearcherLevel.Name = "ListOfResearcherLevel";
            this.ListOfResearcherLevel.Size = new System.Drawing.Size(332, 25);
            this.ListOfResearcherLevel.TabIndex = 19;
            this.ListOfResearcherLevel.Text = "List Of Researcher with Status";
            // 
            // ManageResearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 510);
            this.Controls.Add(this.SearchRese);
            this.Controls.Add(this.TextSearchRese);
            this.Controls.Add(this.MangeReseGoback);
            this.Controls.Add(this.ReseMakeInAct);
            this.Controls.Add(this.ReseMakeAct);
            this.Controls.Add(this.ShowReseStatus);
            this.Controls.Add(this.ReseStatusDtaGrid);
            this.Controls.Add(this.ListOfResearcherLevel);
            this.Name = "ManageResearcher";
            this.Text = "ManageResearcher";
            this.Load += new System.EventHandler(this.ManageResearcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReseStatusDtaGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchRese;
        private System.Windows.Forms.TextBox TextSearchRese;
        private System.Windows.Forms.Button MangeReseGoback;
        private System.Windows.Forms.Button ReseMakeInAct;
        private System.Windows.Forms.Button ReseMakeAct;
        private System.Windows.Forms.Button ShowReseStatus;
        private System.Windows.Forms.DataGridView ReseStatusDtaGrid;
        private System.Windows.Forms.Label ListOfResearcherLevel;
    }
}
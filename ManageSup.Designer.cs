namespace Medgenix
{
    partial class ManageSup
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
            this.ListOfMod = new System.Windows.Forms.Label();
            this.SUPdataView = new System.Windows.Forms.DataGridView();
            this.SearchSup = new System.Windows.Forms.Label();
            this.TextSearchSup = new System.Windows.Forms.TextBox();
            this.SupMakeAct = new System.Windows.Forms.Button();
            this.SupMakeInAct = new System.Windows.Forms.Button();
            this.ShowSupStatus = new System.Windows.Forms.Button();
            this.MangeSupGoback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SUPdataView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListOfMod
            // 
            this.ListOfMod.AutoSize = true;
            this.ListOfMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfMod.Location = new System.Drawing.Point(84, 37);
            this.ListOfMod.Name = "ListOfMod";
            this.ListOfMod.Size = new System.Drawing.Size(336, 25);
            this.ListOfMod.TabIndex = 2;
            this.ListOfMod.Text = "List Of Supervisors with Status";
            // 
            // SUPdataView
            // 
            this.SUPdataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SUPdataView.Location = new System.Drawing.Point(70, 168);
            this.SUPdataView.MultiSelect = false;
            this.SUPdataView.Name = "SUPdataView";
            this.SUPdataView.RowHeadersWidth = 51;
            this.SUPdataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SUPdataView.Size = new System.Drawing.Size(460, 176);
            this.SUPdataView.TabIndex = 3;
            this.SUPdataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SUPdataView_CellContentClick);
            // 
            // SearchSup
            // 
            this.SearchSup.AutoSize = true;
            this.SearchSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSup.Location = new System.Drawing.Point(55, 121);
            this.SearchSup.Name = "SearchSup";
            this.SearchSup.Size = new System.Drawing.Size(250, 25);
            this.SearchSup.TabIndex = 11;
            this.SearchSup.Text = "Search By User Name:";
            // 
            // TextSearchSup
            // 
            this.TextSearchSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearchSup.Location = new System.Drawing.Point(324, 121);
            this.TextSearchSup.Name = "TextSearchSup";
            this.TextSearchSup.Size = new System.Drawing.Size(121, 26);
            this.TextSearchSup.TabIndex = 12;
            this.TextSearchSup.TextChanged += new System.EventHandler(this.TextSearchSup_TextChanged);
            // 
            // SupMakeAct
            // 
            this.SupMakeAct.Font = new System.Drawing.Font("Gotham Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupMakeAct.Location = new System.Drawing.Point(639, 168);
            this.SupMakeAct.Name = "SupMakeAct";
            this.SupMakeAct.Size = new System.Drawing.Size(143, 41);
            this.SupMakeAct.TabIndex = 13;
            this.SupMakeAct.Text = "Make Active";
            this.SupMakeAct.UseVisualStyleBackColor = true;
            this.SupMakeAct.Click += new System.EventHandler(this.SupMakeAct_Click);
            // 
            // SupMakeInAct
            // 
            this.SupMakeInAct.Font = new System.Drawing.Font("Gotham Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupMakeInAct.Location = new System.Drawing.Point(639, 251);
            this.SupMakeInAct.Name = "SupMakeInAct";
            this.SupMakeInAct.Size = new System.Drawing.Size(143, 41);
            this.SupMakeInAct.TabIndex = 14;
            this.SupMakeInAct.Text = "Make Inactive";
            this.SupMakeInAct.UseVisualStyleBackColor = true;
            this.SupMakeInAct.Click += new System.EventHandler(this.SupMakeInAct_Click);
            // 
            // ShowSupStatus
            // 
            this.ShowSupStatus.Font = new System.Drawing.Font("Gotham Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowSupStatus.Location = new System.Drawing.Point(70, 368);
            this.ShowSupStatus.Name = "ShowSupStatus";
            this.ShowSupStatus.Size = new System.Drawing.Size(97, 39);
            this.ShowSupStatus.TabIndex = 15;
            this.ShowSupStatus.Text = "Show";
            this.ShowSupStatus.UseVisualStyleBackColor = true;
            this.ShowSupStatus.Click += new System.EventHandler(this.ShowSupStatus_Click);
            // 
            // MangeSupGoback
            // 
            this.MangeSupGoback.Font = new System.Drawing.Font("Gotham Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MangeSupGoback.Location = new System.Drawing.Point(671, 368);
            this.MangeSupGoback.Name = "MangeSupGoback";
            this.MangeSupGoback.Size = new System.Drawing.Size(97, 39);
            this.MangeSupGoback.TabIndex = 16;
            this.MangeSupGoback.Text = "Go Back";
            this.MangeSupGoback.UseVisualStyleBackColor = true;
            this.MangeSupGoback.Click += new System.EventHandler(this.MangeSupGoback_Click);
            // 
            // ManageSup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 467);
            this.Controls.Add(this.MangeSupGoback);
            this.Controls.Add(this.ShowSupStatus);
            this.Controls.Add(this.SupMakeInAct);
            this.Controls.Add(this.SupMakeAct);
            this.Controls.Add(this.TextSearchSup);
            this.Controls.Add(this.SearchSup);
            this.Controls.Add(this.SUPdataView);
            this.Controls.Add(this.ListOfMod);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageSup";
            this.Text = "ManageSup";
            this.Load += new System.EventHandler(this.ManageSup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SUPdataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ListOfMod;
        private System.Windows.Forms.DataGridView SUPdataView;
        private System.Windows.Forms.Label SearchSup;
        private System.Windows.Forms.TextBox TextSearchSup;
        private System.Windows.Forms.Button SupMakeAct;
        private System.Windows.Forms.Button SupMakeInAct;
        private System.Windows.Forms.Button ShowSupStatus;
        private System.Windows.Forms.Button MangeSupGoback;
    }
}
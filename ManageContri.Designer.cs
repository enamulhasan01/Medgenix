namespace Medgenix
{
    partial class ManageContri
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
            this.ListOfContriLevel = new System.Windows.Forms.Label();
            this.ContriStatusDtaGrid = new System.Windows.Forms.DataGridView();
            this.ShowContriStatus = new System.Windows.Forms.Button();
            this.ContriMakeAct = new System.Windows.Forms.Button();
            this.ContriMakeInAct = new System.Windows.Forms.Button();
            this.MangeContriGoback = new System.Windows.Forms.Button();
            this.TextSearchUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ContriStatusDtaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ListOfContriLevel
            // 
            this.ListOfContriLevel.AutoSize = true;
            this.ListOfContriLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfContriLevel.Location = new System.Drawing.Point(126, 57);
            this.ListOfContriLevel.Name = "ListOfContriLevel";
            this.ListOfContriLevel.Size = new System.Drawing.Size(328, 25);
            this.ListOfContriLevel.TabIndex = 3;
            this.ListOfContriLevel.Text = "List Of Contributor with Status";
            // 
            // ContriStatusDtaGrid
            // 
            this.ContriStatusDtaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContriStatusDtaGrid.Location = new System.Drawing.Point(87, 139);
            this.ContriStatusDtaGrid.MultiSelect = false;
            this.ContriStatusDtaGrid.Name = "ContriStatusDtaGrid";
            this.ContriStatusDtaGrid.RowHeadersWidth = 51;
            this.ContriStatusDtaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ContriStatusDtaGrid.Size = new System.Drawing.Size(460, 176);
            this.ContriStatusDtaGrid.TabIndex = 4;
            this.ContriStatusDtaGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContriStatusDtaGrid_CellContentClick);
            // 
            // ShowContriStatus
            // 
            this.ShowContriStatus.Font = new System.Drawing.Font("Gotham Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowContriStatus.Location = new System.Drawing.Point(87, 352);
            this.ShowContriStatus.Name = "ShowContriStatus";
            this.ShowContriStatus.Size = new System.Drawing.Size(97, 39);
            this.ShowContriStatus.TabIndex = 5;
            this.ShowContriStatus.Text = "Show";
            this.ShowContriStatus.UseVisualStyleBackColor = true;
            this.ShowContriStatus.Click += new System.EventHandler(this.ShowContriStatus_Click);
            // 
            // ContriMakeAct
            // 
            this.ContriMakeAct.Font = new System.Drawing.Font("Gotham Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContriMakeAct.Location = new System.Drawing.Point(605, 165);
            this.ContriMakeAct.Name = "ContriMakeAct";
            this.ContriMakeAct.Size = new System.Drawing.Size(143, 41);
            this.ContriMakeAct.TabIndex = 6;
            this.ContriMakeAct.Text = "Make Active";
            this.ContriMakeAct.UseVisualStyleBackColor = true;
            this.ContriMakeAct.Click += new System.EventHandler(this.ContriMakeAct_Click);
            // 
            // ContriMakeInAct
            // 
            this.ContriMakeInAct.Font = new System.Drawing.Font("Gotham Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContriMakeInAct.Location = new System.Drawing.Point(605, 229);
            this.ContriMakeInAct.Name = "ContriMakeInAct";
            this.ContriMakeInAct.Size = new System.Drawing.Size(143, 41);
            this.ContriMakeInAct.TabIndex = 7;
            this.ContriMakeInAct.Text = "Make Inactive";
            this.ContriMakeInAct.UseVisualStyleBackColor = true;
            this.ContriMakeInAct.Click += new System.EventHandler(this.ContriMakeInAct_Click);
            // 
            // MangeContriGoback
            // 
            this.MangeContriGoback.Font = new System.Drawing.Font("Gotham Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MangeContriGoback.Location = new System.Drawing.Point(636, 368);
            this.MangeContriGoback.Name = "MangeContriGoback";
            this.MangeContriGoback.Size = new System.Drawing.Size(97, 39);
            this.MangeContriGoback.TabIndex = 8;
            this.MangeContriGoback.Text = "Go Back";
            this.MangeContriGoback.UseVisualStyleBackColor = true;
            this.MangeContriGoback.Click += new System.EventHandler(this.MangeContriGoback_Click);
            // 
            // TextSearchUser
            // 
            this.TextSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearchUser.Location = new System.Drawing.Point(384, 107);
            this.TextSearchUser.Name = "TextSearchUser";
            this.TextSearchUser.Size = new System.Drawing.Size(121, 26);
            this.TextSearchUser.TabIndex = 9;
            this.TextSearchUser.TextChanged += new System.EventHandler(this.TextSearchUser_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search By User Name:";
            // 
            // ManageContri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextSearchUser);
            this.Controls.Add(this.MangeContriGoback);
            this.Controls.Add(this.ContriMakeInAct);
            this.Controls.Add(this.ContriMakeAct);
            this.Controls.Add(this.ShowContriStatus);
            this.Controls.Add(this.ContriStatusDtaGrid);
            this.Controls.Add(this.ListOfContriLevel);
            this.Name = "ManageContri";
            this.Text = "Manage Contributor";
            this.Load += new System.EventHandler(this.ManageContri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContriStatusDtaGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ListOfContriLevel;
        private System.Windows.Forms.DataGridView ContriStatusDtaGrid;
        private System.Windows.Forms.Button ShowContriStatus;
        private System.Windows.Forms.Button ContriMakeAct;
        private System.Windows.Forms.Button ContriMakeInAct;
        private System.Windows.Forms.Button MangeContriGoback;
        private System.Windows.Forms.TextBox TextSearchUser;
        private System.Windows.Forms.Label label1;
    }
}
namespace Medgenix
{
    partial class ManageMod
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
            this.ModdataGridView = new System.Windows.Forms.DataGridView();
            this.ListOfMod = new System.Windows.Forms.Label();
            this.SearchMod = new System.Windows.Forms.Label();
            this.TextSearchMod = new System.Windows.Forms.TextBox();
            this.ShowModStatus = new System.Windows.Forms.Button();
            this.ModMakeAct = new System.Windows.Forms.Button();
            this.ModMakeInAct = new System.Windows.Forms.Button();
            this.MangeModGoback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ModdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ModdataGridView
            // 
            this.ModdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModdataGridView.Location = new System.Drawing.Point(52, 187);
            this.ModdataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModdataGridView.MultiSelect = false;
            this.ModdataGridView.Name = "ModdataGridView";
            this.ModdataGridView.RowHeadersWidth = 51;
            this.ModdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ModdataGridView.Size = new System.Drawing.Size(689, 267);
            this.ModdataGridView.TabIndex = 2;
            // 
            // ListOfMod
            // 
            this.ListOfMod.AutoSize = true;
            this.ListOfMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfMod.Location = new System.Drawing.Point(45, 57);
            this.ListOfMod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ListOfMod.Name = "ListOfMod";
            this.ListOfMod.Size = new System.Drawing.Size(408, 31);
            this.ListOfMod.TabIndex = 3;
            this.ListOfMod.Text = "List Of Moderators with Status";
            // 
            // SearchMod
            // 
            this.SearchMod.AutoSize = true;
            this.SearchMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMod.Location = new System.Drawing.Point(45, 123);
            this.SearchMod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchMod.Name = "SearchMod";
            this.SearchMod.Size = new System.Drawing.Size(311, 31);
            this.SearchMod.TabIndex = 12;
            this.SearchMod.Text = "Search By User Name:";
            // 
            // TextSearchMod
            // 
            this.TextSearchMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearchMod.Location = new System.Drawing.Point(387, 124);
            this.TextSearchMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextSearchMod.Name = "TextSearchMod";
            this.TextSearchMod.Size = new System.Drawing.Size(160, 30);
            this.TextSearchMod.TabIndex = 13;
            this.TextSearchMod.TextChanged += new System.EventHandler(this.TextSearchMod_TextChanged);
            // 
            // ShowModStatus
            // 
            this.ShowModStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowModStatus.Location = new System.Drawing.Point(52, 492);
            this.ShowModStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowModStatus.Name = "ShowModStatus";
            this.ShowModStatus.Size = new System.Drawing.Size(129, 48);
            this.ShowModStatus.TabIndex = 16;
            this.ShowModStatus.Text = "Show";
            this.ShowModStatus.UseVisualStyleBackColor = true;
            this.ShowModStatus.Click += new System.EventHandler(this.ShowModStatus_Click);
            // 
            // ModMakeAct
            // 
            this.ModMakeAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModMakeAct.Location = new System.Drawing.Point(941, 219);
            this.ModMakeAct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModMakeAct.Name = "ModMakeAct";
            this.ModMakeAct.Size = new System.Drawing.Size(191, 50);
            this.ModMakeAct.TabIndex = 17;
            this.ModMakeAct.Text = "Make Active";
            this.ModMakeAct.UseVisualStyleBackColor = true;
            this.ModMakeAct.Click += new System.EventHandler(this.ModMakeAct_Click);
            // 
            // ModMakeInAct
            // 
            this.ModMakeInAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModMakeInAct.Location = new System.Drawing.Point(941, 309);
            this.ModMakeInAct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModMakeInAct.Name = "ModMakeInAct";
            this.ModMakeInAct.Size = new System.Drawing.Size(191, 50);
            this.ModMakeInAct.TabIndex = 18;
            this.ModMakeInAct.Text = "Make Inactive";
            this.ModMakeInAct.UseVisualStyleBackColor = true;
            this.ModMakeInAct.Click += new System.EventHandler(this.ModMakeInAct_Click);
            // 
            // MangeModGoback
            // 
            this.MangeModGoback.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MangeModGoback.Location = new System.Drawing.Point(1003, 425);
            this.MangeModGoback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MangeModGoback.Name = "MangeModGoback";
            this.MangeModGoback.Size = new System.Drawing.Size(129, 48);
            this.MangeModGoback.TabIndex = 19;
            this.MangeModGoback.Text = "Go Back";
            this.MangeModGoback.UseVisualStyleBackColor = true;
            this.MangeModGoback.Click += new System.EventHandler(this.MangeModGoback_Click);
            // 
            // ManageMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 582);
            this.Controls.Add(this.MangeModGoback);
            this.Controls.Add(this.ModMakeInAct);
            this.Controls.Add(this.ModMakeAct);
            this.Controls.Add(this.ShowModStatus);
            this.Controls.Add(this.TextSearchMod);
            this.Controls.Add(this.SearchMod);
            this.Controls.Add(this.ListOfMod);
            this.Controls.Add(this.ModdataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageMod";
            this.Text = "ManageMod";
            this.Load += new System.EventHandler(this.ManageMod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ModdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ModdataGridView;
        private System.Windows.Forms.Label ListOfMod;
        private System.Windows.Forms.Label SearchMod;
        private System.Windows.Forms.TextBox TextSearchMod;
        private System.Windows.Forms.Button ShowModStatus;
        private System.Windows.Forms.Button ModMakeAct;
        private System.Windows.Forms.Button ModMakeInAct;
        private System.Windows.Forms.Button MangeModGoback;
    }
}
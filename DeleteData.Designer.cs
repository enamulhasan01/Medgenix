namespace Medgenix
{
    partial class DeleteData
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
            this.SearchDssDelete = new System.Windows.Forms.Label();
            this.DLTdataGridView = new System.Windows.Forms.DataGridView();
            this.Show = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.GoBack = new System.Windows.Forms.Button();
            this.SearchForDLTDss = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DLTdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchDssDelete
            // 
            this.SearchDssDelete.AutoSize = true;
            this.SearchDssDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDssDelete.Location = new System.Drawing.Point(23, 42);
            this.SearchDssDelete.Name = "SearchDssDelete";
            this.SearchDssDelete.Size = new System.Drawing.Size(277, 24);
            this.SearchDssDelete.TabIndex = 3;
            this.SearchDssDelete.Text = "Search Disease For Deletion";
            // 
            // DLTdataGridView
            // 
            this.DLTdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DLTdataGridView.Location = new System.Drawing.Point(27, 93);
            this.DLTdataGridView.Name = "DLTdataGridView";
            this.DLTdataGridView.RowHeadersWidth = 51;
            this.DLTdataGridView.Size = new System.Drawing.Size(411, 154);
            this.DLTdataGridView.TabIndex = 4;
            // 
            // Show
            // 
            this.Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.Location = new System.Drawing.Point(27, 283);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(135, 44);
            this.Show.TabIndex = 10;
            this.Show.Text = "Show All";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(565, 112);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(120, 44);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // GoBack
            // 
            this.GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBack.Location = new System.Drawing.Point(565, 200);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(120, 48);
            this.GoBack.TabIndex = 12;
            this.GoBack.Text = "Go Back";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // SearchForDLTDss
            // 
            this.SearchForDLTDss.Location = new System.Drawing.Point(306, 47);
            this.SearchForDLTDss.Name = "SearchForDLTDss";
            this.SearchForDLTDss.Size = new System.Drawing.Size(100, 20);
            this.SearchForDLTDss.TabIndex = 14;
            this.SearchForDLTDss.TextChanged += new System.EventHandler(this.SearchForDLTDss_TextChanged);
            // 
            // DeleteData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 353);
            this.Controls.Add(this.SearchForDLTDss);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.DLTdataGridView);
            this.Controls.Add(this.SearchDssDelete);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DeleteData";
            this.Text = "DeleteData";
            this.Load += new System.EventHandler(this.DeleteData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DLTdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchDssDelete;
        private System.Windows.Forms.DataGridView DLTdataGridView;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.TextBox SearchForDLTDss;
    }
}
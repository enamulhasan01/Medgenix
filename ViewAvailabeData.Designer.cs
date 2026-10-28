namespace Medgenix
{
    partial class ViewAvailabeData
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
            this.AvailableDtatlvl = new System.Windows.Forms.Label();
            this.SearchDss = new System.Windows.Forms.Label();
            this.AVdataGridView = new System.Windows.Forms.DataGridView();
            this.Show = new System.Windows.Forms.Button();
            this.AddData = new System.Windows.Forms.Button();
            this.DeleteData = new System.Windows.Forms.Button();
            this.SearchForDss = new System.Windows.Forms.TextBox();
            this.ViewAvaiDtaGOBACK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AVdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AvailableDtatlvl
            // 
            this.AvailableDtatlvl.AutoSize = true;
            this.AvailableDtatlvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableDtatlvl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AvailableDtatlvl.Location = new System.Drawing.Point(25, 30);
            this.AvailableDtatlvl.Name = "AvailableDtatlvl";
            this.AvailableDtatlvl.Size = new System.Drawing.Size(237, 37);
            this.AvailableDtatlvl.TabIndex = 1;
            this.AvailableDtatlvl.Text = "Available Data";
            // 
            // SearchDss
            // 
            this.SearchDss.AutoSize = true;
            this.SearchDss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDss.Location = new System.Drawing.Point(27, 113);
            this.SearchDss.Name = "SearchDss";
            this.SearchDss.Size = new System.Drawing.Size(194, 24);
            this.SearchDss.TabIndex = 2;
            this.SearchDss.Text = "Search For Disease";
            // 
            // AVdataGridView
            // 
            this.AVdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AVdataGridView.Location = new System.Drawing.Point(31, 176);
            this.AVdataGridView.Name = "AVdataGridView";
            this.AVdataGridView.RowHeadersWidth = 51;
            this.AVdataGridView.Size = new System.Drawing.Size(362, 205);
            this.AVdataGridView.TabIndex = 9;
            // 
            // Show
            // 
            this.Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.Location = new System.Drawing.Point(31, 413);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(117, 41);
            this.Show.TabIndex = 10;
            this.Show.Text = "Show All";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // AddData
            // 
            this.AddData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddData.Location = new System.Drawing.Point(547, 193);
            this.AddData.Name = "AddData";
            this.AddData.Size = new System.Drawing.Size(150, 55);
            this.AddData.TabIndex = 11;
            this.AddData.Text = "Add Data";
            this.AddData.UseVisualStyleBackColor = true;
            this.AddData.Click += new System.EventHandler(this.AddData_Click);
            // 
            // DeleteData
            // 
            this.DeleteData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteData.Location = new System.Drawing.Point(547, 287);
            this.DeleteData.Name = "DeleteData";
            this.DeleteData.Size = new System.Drawing.Size(150, 55);
            this.DeleteData.TabIndex = 12;
            this.DeleteData.Text = "Delete Data";
            this.DeleteData.UseVisualStyleBackColor = true;
            this.DeleteData.Click += new System.EventHandler(this.DeleteData_Click);
            // 
            // SearchForDss
            // 
            this.SearchForDss.Location = new System.Drawing.Point(250, 118);
            this.SearchForDss.Name = "SearchForDss";
            this.SearchForDss.Size = new System.Drawing.Size(100, 20);
            this.SearchForDss.TabIndex = 13;
            this.SearchForDss.TextChanged += new System.EventHandler(this.SearchForDss_TextChanged);
            // 
            // ViewAvaiDtaGOBACK
            // 
            this.ViewAvaiDtaGOBACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAvaiDtaGOBACK.Location = new System.Drawing.Point(620, 501);
            this.ViewAvaiDtaGOBACK.Name = "ViewAvaiDtaGOBACK";
            this.ViewAvaiDtaGOBACK.Size = new System.Drawing.Size(117, 41);
            this.ViewAvaiDtaGOBACK.TabIndex = 14;
            this.ViewAvaiDtaGOBACK.Text = "Go Back";
            this.ViewAvaiDtaGOBACK.UseVisualStyleBackColor = true;
            this.ViewAvaiDtaGOBACK.Click += new System.EventHandler(this.ViewAvaiDtaGOBACK_Click);
            // 
            // ViewAvailabeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 554);
            this.Controls.Add(this.ViewAvaiDtaGOBACK);
            this.Controls.Add(this.SearchForDss);
            this.Controls.Add(this.DeleteData);
            this.Controls.Add(this.AddData);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.AVdataGridView);
            this.Controls.Add(this.SearchDss);
            this.Controls.Add(this.AvailableDtatlvl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewAvailabeData";
            this.Text = "ViewAvailabeData";
            this.Load += new System.EventHandler(this.ViewAvailabeData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AVdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AvailableDtatlvl;
        private System.Windows.Forms.Label SearchDss;
        private System.Windows.Forms.DataGridView AVdataGridView;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button AddData;
        private System.Windows.Forms.Button DeleteData;
        private System.Windows.Forms.TextBox SearchForDss;
        private System.Windows.Forms.Button ViewAvaiDtaGOBACK;
    }
}
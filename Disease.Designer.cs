namespace Medgenix
{
    partial class Disease
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
            this.DiseaseName = new System.Windows.Forms.Label();
            this.DiseaseNamae = new System.Windows.Forms.Label();
            this.DssInfo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Accept = new System.Windows.Forms.Button();
            this.Reject = new System.Windows.Forms.Button();
            this.GoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DiseaseName
            // 
            this.DiseaseName.AutoSize = true;
            this.DiseaseName.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiseaseName.Location = new System.Drawing.Point(24, 37);
            this.DiseaseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiseaseName.Name = "DiseaseName";
            this.DiseaseName.Size = new System.Drawing.Size(192, 31);
            this.DiseaseName.TabIndex = 1;
            this.DiseaseName.Text = "Disease Name:";
            // 
            // DiseaseNamae
            // 
            this.DiseaseNamae.AutoSize = true;
            this.DiseaseNamae.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiseaseNamae.Location = new System.Drawing.Point(237, 46);
            this.DiseaseNamae.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiseaseNamae.Name = "DiseaseNamae";
            this.DiseaseNamae.Size = new System.Drawing.Size(29, 20);
            this.DiseaseNamae.TabIndex = 7;
            this.DiseaseNamae.Text = "\" \"";
            // 
            // DssInfo
            // 
            this.DssInfo.AutoSize = true;
            this.DssInfo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DssInfo.Location = new System.Drawing.Point(24, 100);
            this.DssInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DssInfo.Name = "DssInfo";
            this.DssInfo.Size = new System.Drawing.Size(267, 31);
            this.DssInfo.TabIndex = 8;
            this.DssInfo.Text = "Disease Information:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 162);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(678, 322);
            this.dataGridView1.TabIndex = 9;
            // 
            // Accept
            // 
            this.Accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accept.Location = new System.Drawing.Point(776, 180);
            this.Accept.Margin = new System.Windows.Forms.Padding(4);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(151, 57);
            this.Accept.TabIndex = 10;
            this.Accept.Text = "Accept";
            this.Accept.UseVisualStyleBackColor = true;
            // 
            // Reject
            // 
            this.Reject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reject.Location = new System.Drawing.Point(776, 285);
            this.Reject.Margin = new System.Windows.Forms.Padding(4);
            this.Reject.Name = "Reject";
            this.Reject.Size = new System.Drawing.Size(151, 57);
            this.Reject.TabIndex = 11;
            this.Reject.Text = "Reject";
            this.Reject.UseVisualStyleBackColor = true;
            // 
            // GoBack
            // 
            this.GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBack.Location = new System.Drawing.Point(793, 396);
            this.GoBack.Margin = new System.Windows.Forms.Padding(4);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(134, 45);
            this.GoBack.TabIndex = 12;
            this.GoBack.Text = "Go Back";
            this.GoBack.UseVisualStyleBackColor = true;
            // 
            // Disease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 611);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.Reject);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DssInfo);
            this.Controls.Add(this.DiseaseNamae);
            this.Controls.Add(this.DiseaseName);
            this.Name = "Disease";
            this.Text = "Disease";
            this.Load += new System.EventHandler(this.Disease_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DiseaseName;
        private System.Windows.Forms.Label DiseaseNamae;
        private System.Windows.Forms.Label DssInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Reject;
        private System.Windows.Forms.Button GoBack;
    }
}
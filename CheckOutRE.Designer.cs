namespace Medgenix
{
    partial class CheckOutRE
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
            this.ShowDetails = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckOutREGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CheckOutREGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowDetails
            // 
            this.ShowDetails.Location = new System.Drawing.Point(156, 370);
            this.ShowDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowDetails.Name = "ShowDetails";
            this.ShowDetails.Size = new System.Drawing.Size(151, 62);
            this.ShowDetails.TabIndex = 27;
            this.ShowDetails.Text = "Show Details";
            this.ShowDetails.UseVisualStyleBackColor = true;
            this.ShowDetails.Click += new System.EventHandler(this.ShowDetails_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Checkout Details:";
            // 
            // CheckOutREGridView
            // 
            this.CheckOutREGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CheckOutREGridView.Location = new System.Drawing.Point(60, 118);
            this.CheckOutREGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckOutREGridView.Name = "CheckOutREGridView";
            this.CheckOutREGridView.RowHeadersWidth = 51;
            this.CheckOutREGridView.Size = new System.Drawing.Size(627, 206);
            this.CheckOutREGridView.TabIndex = 25;
            // 
            // CheckOutRE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ShowDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckOutREGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CheckOutRE";
            this.Text = "CheckOutRE";
            this.Load += new System.EventHandler(this.CheckOutRE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckOutREGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView CheckOutREGridView;
    }
}
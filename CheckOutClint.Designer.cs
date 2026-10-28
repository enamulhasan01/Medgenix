namespace Medgenix
{
    partial class CheckOutClint
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
            this.CheckOutClintGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CheckOutClintGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowDetails
            // 
            this.ShowDetails.Location = new System.Drawing.Point(145, 404);
            this.ShowDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowDetails.Name = "ShowDetails";
            this.ShowDetails.Size = new System.Drawing.Size(151, 62);
            this.ShowDetails.TabIndex = 24;
            this.ShowDetails.Text = "Show Details";
            this.ShowDetails.UseVisualStyleBackColor = true;
            this.ShowDetails.Click += new System.EventHandler(this.ShowDetails_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Checkout Details:";
            // 
            // CheckOutClintGridView
            // 
            this.CheckOutClintGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CheckOutClintGridView.Location = new System.Drawing.Point(49, 151);
            this.CheckOutClintGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckOutClintGridView.Name = "CheckOutClintGridView";
            this.CheckOutClintGridView.RowHeadersWidth = 51;
            this.CheckOutClintGridView.Size = new System.Drawing.Size(627, 206);
            this.CheckOutClintGridView.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(903, 479);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 62);
            this.button1.TabIndex = 25;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(903, 24);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 62);
            this.button2.TabIndex = 26;
            this.button2.Text = "Home Page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CheckOutClint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckOutClintGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CheckOutClint";
            this.Text = "CheckOutClint";
            this.Load += new System.EventHandler(this.CheckOutClint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckOutClintGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView CheckOutClintGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
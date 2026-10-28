namespace Medgenix
{
    partial class DataSELLClint
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
            this.ICPayCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchAreaIC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchYrIC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewAvaiDtaGOBACK = new System.Windows.Forms.Button();
            this.SearchDssIC = new System.Windows.Forms.TextBox();
            this.ProceedToPaymentIC = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.AVdataGridViewIC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AvailableDtatlvl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AVdataGridViewIC)).BeginInit();
            this.SuspendLayout();
            // 
            // ICPayCombo
            // 
            this.ICPayCombo.FormattingEnabled = true;
            this.ICPayCombo.Items.AddRange(new object[] {
            "Card",
            "Bkash"});
            this.ICPayCombo.Location = new System.Drawing.Point(731, 134);
            this.ICPayCombo.Name = "ICPayCombo";
            this.ICPayCombo.Size = new System.Drawing.Size(121, 21);
            this.ICPayCombo.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(503, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "Enter Payment Method";
            // 
            // SearchAreaIC
            // 
            this.SearchAreaIC.Location = new System.Drawing.Point(258, 213);
            this.SearchAreaIC.Name = "SearchAreaIC";
            this.SearchAreaIC.Size = new System.Drawing.Size(100, 20);
            this.SearchAreaIC.TabIndex = 39;
            this.SearchAreaIC.TextChanged += new System.EventHandler(this.SearchAreaIC_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Area: ";
            // 
            // SearchYrIC
            // 
            this.SearchYrIC.Location = new System.Drawing.Point(258, 162);
            this.SearchYrIC.Name = "SearchYrIC";
            this.SearchYrIC.Size = new System.Drawing.Size(100, 20);
            this.SearchYrIC.TabIndex = 37;
            this.SearchYrIC.TextChanged += new System.EventHandler(this.SearchYrIC_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Enter Year:";
            // 
            // ViewAvaiDtaGOBACK
            // 
            this.ViewAvaiDtaGOBACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAvaiDtaGOBACK.Location = new System.Drawing.Point(787, 522);
            this.ViewAvaiDtaGOBACK.Name = "ViewAvaiDtaGOBACK";
            this.ViewAvaiDtaGOBACK.Size = new System.Drawing.Size(117, 41);
            this.ViewAvaiDtaGOBACK.TabIndex = 35;
            this.ViewAvaiDtaGOBACK.Text = "Go Back";
            this.ViewAvaiDtaGOBACK.UseVisualStyleBackColor = true;
            // 
            // SearchDssIC
            // 
            this.SearchDssIC.Location = new System.Drawing.Point(258, 118);
            this.SearchDssIC.Name = "SearchDssIC";
            this.SearchDssIC.Size = new System.Drawing.Size(100, 20);
            this.SearchDssIC.TabIndex = 34;
            this.SearchDssIC.TextChanged += new System.EventHandler(this.SearchDssIC_TextChanged);
            // 
            // ProceedToPaymentIC
            // 
            this.ProceedToPaymentIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProceedToPaymentIC.Location = new System.Drawing.Point(713, 208);
            this.ProceedToPaymentIC.Name = "ProceedToPaymentIC";
            this.ProceedToPaymentIC.Size = new System.Drawing.Size(150, 55);
            this.ProceedToPaymentIC.TabIndex = 33;
            this.ProceedToPaymentIC.Text = "Proceed To Payment";
            this.ProceedToPaymentIC.UseVisualStyleBackColor = true;
            this.ProceedToPaymentIC.Click += new System.EventHandler(this.ProceedToPaymentIC_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAll.Location = new System.Drawing.Point(345, 269);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(117, 41);
            this.ClearAll.TabIndex = 32;
            this.ClearAll.Text = "Clear All";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // AVdataGridViewIC
            // 
            this.AVdataGridViewIC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AVdataGridViewIC.Location = new System.Drawing.Point(62, 346);
            this.AVdataGridViewIC.Name = "AVdataGridViewIC";
            this.AVdataGridViewIC.RowHeadersWidth = 51;
            this.AVdataGridViewIC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AVdataGridViewIC.Size = new System.Drawing.Size(420, 226);
            this.AVdataGridViewIC.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Search For Disease";
            // 
            // AvailableDtatlvl
            // 
            this.AvailableDtatlvl.AutoSize = true;
            this.AvailableDtatlvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableDtatlvl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AvailableDtatlvl.Location = new System.Drawing.Point(214, -39);
            this.AvailableDtatlvl.Name = "AvailableDtatlvl";
            this.AvailableDtatlvl.Size = new System.Drawing.Size(362, 37);
            this.AvailableDtatlvl.TabIndex = 29;
            this.AvailableDtatlvl.Text = "Get Your Desired Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(327, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 37);
            this.label5.TabIndex = 42;
            this.label5.Text = "Get Your Desired Data";
            // 
            // DataSELLClint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 604);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ICPayCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchAreaIC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchYrIC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViewAvaiDtaGOBACK);
            this.Controls.Add(this.SearchDssIC);
            this.Controls.Add(this.ProceedToPaymentIC);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.AVdataGridViewIC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AvailableDtatlvl);
            this.Name = "DataSELLClint";
            this.Text = "DataSellIClint";
            this.Load += new System.EventHandler(this.DataSELLClint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AVdataGridViewIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ICPayCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SearchAreaIC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchYrIC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewAvaiDtaGOBACK;
        private System.Windows.Forms.TextBox SearchDssIC;
        private System.Windows.Forms.Button ProceedToPaymentIC;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.DataGridView AVdataGridViewIC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AvailableDtatlvl;
        private System.Windows.Forms.Label label5;
    }
}
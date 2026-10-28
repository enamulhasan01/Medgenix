namespace Medgenix
{
    partial class ManageIClint
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
            this.SearchClint = new System.Windows.Forms.Label();
            this.TextSearchClint = new System.Windows.Forms.TextBox();
            this.MangeClintGoback = new System.Windows.Forms.Button();
            this.ClintMakeInAct = new System.Windows.Forms.Button();
            this.ClintMakeAct = new System.Windows.Forms.Button();
            this.ShowClintStatus = new System.Windows.Forms.Button();
            this.ClintStatusDtaGrid = new System.Windows.Forms.DataGridView();
            this.ListOfClintLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClintStatusDtaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchClint
            // 
            this.SearchClint.AutoSize = true;
            this.SearchClint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchClint.Location = new System.Drawing.Point(143, 183);
            this.SearchClint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchClint.Name = "SearchClint";
            this.SearchClint.Size = new System.Drawing.Size(470, 31);
            this.SearchClint.TabIndex = 34;
            this.SearchClint.Text = "Search Researcher By User Name:";
            // 
            // TextSearchClint
            // 
            this.TextSearchClint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearchClint.Location = new System.Drawing.Point(684, 185);
            this.TextSearchClint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextSearchClint.Name = "TextSearchClint";
            this.TextSearchClint.Size = new System.Drawing.Size(160, 30);
            this.TextSearchClint.TabIndex = 33;
            this.TextSearchClint.TextChanged += new System.EventHandler(this.TextSearchClint_TextChanged);
            // 
            // MangeClintGoback
            // 
            this.MangeClintGoback.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MangeClintGoback.Location = new System.Drawing.Point(999, 500);
            this.MangeClintGoback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MangeClintGoback.Name = "MangeClintGoback";
            this.MangeClintGoback.Size = new System.Drawing.Size(129, 48);
            this.MangeClintGoback.TabIndex = 32;
            this.MangeClintGoback.Text = "Go Back";
            this.MangeClintGoback.UseVisualStyleBackColor = true;
            this.MangeClintGoback.Click += new System.EventHandler(this.MangeClintGoback_Click);
            // 
            // ClintMakeInAct
            // 
            this.ClintMakeInAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClintMakeInAct.Location = new System.Drawing.Point(937, 335);
            this.ClintMakeInAct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClintMakeInAct.Name = "ClintMakeInAct";
            this.ClintMakeInAct.Size = new System.Drawing.Size(191, 50);
            this.ClintMakeInAct.TabIndex = 31;
            this.ClintMakeInAct.Text = "Make Inactive";
            this.ClintMakeInAct.UseVisualStyleBackColor = true;
            this.ClintMakeInAct.Click += new System.EventHandler(this.ClintMakeInAct_Click);
            // 
            // ClintMakeAct
            // 
            this.ClintMakeAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClintMakeAct.Location = new System.Drawing.Point(937, 256);
            this.ClintMakeAct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClintMakeAct.Name = "ClintMakeAct";
            this.ClintMakeAct.Size = new System.Drawing.Size(191, 50);
            this.ClintMakeAct.TabIndex = 30;
            this.ClintMakeAct.Text = "Make Active";
            this.ClintMakeAct.UseVisualStyleBackColor = true;
            this.ClintMakeAct.Click += new System.EventHandler(this.ClintMakeAct_Click);
            // 
            // ShowClintStatus
            // 
            this.ShowClintStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowClintStatus.Location = new System.Drawing.Point(256, 484);
            this.ShowClintStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowClintStatus.Name = "ShowClintStatus";
            this.ShowClintStatus.Size = new System.Drawing.Size(129, 48);
            this.ShowClintStatus.TabIndex = 29;
            this.ShowClintStatus.Text = "Show";
            this.ShowClintStatus.UseVisualStyleBackColor = true;
            this.ShowClintStatus.Click += new System.EventHandler(this.ShowClintStatus_Click);
            // 
            // ClintStatusDtaGrid
            // 
            this.ClintStatusDtaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClintStatusDtaGrid.Location = new System.Drawing.Point(207, 224);
            this.ClintStatusDtaGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClintStatusDtaGrid.MultiSelect = false;
            this.ClintStatusDtaGrid.Name = "ClintStatusDtaGrid";
            this.ClintStatusDtaGrid.RowHeadersWidth = 51;
            this.ClintStatusDtaGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClintStatusDtaGrid.Size = new System.Drawing.Size(639, 231);
            this.ClintStatusDtaGrid.TabIndex = 28;
            // 
            // ListOfClintLevel
            // 
            this.ListOfClintLevel.AutoSize = true;
            this.ListOfClintLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfClintLevel.Location = new System.Drawing.Point(299, 123);
            this.ListOfClintLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ListOfClintLevel.Name = "ListOfClintLevel";
            this.ListOfClintLevel.Size = new System.Drawing.Size(412, 31);
            this.ListOfClintLevel.TabIndex = 27;
            this.ListOfClintLevel.Text = "List Of Researcher with Status";
            // 
            // ManageIClint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 671);
            this.Controls.Add(this.SearchClint);
            this.Controls.Add(this.TextSearchClint);
            this.Controls.Add(this.MangeClintGoback);
            this.Controls.Add(this.ClintMakeInAct);
            this.Controls.Add(this.ClintMakeAct);
            this.Controls.Add(this.ShowClintStatus);
            this.Controls.Add(this.ClintStatusDtaGrid);
            this.Controls.Add(this.ListOfClintLevel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageIClint";
            this.Text = "ManageIClint";
            this.Load += new System.EventHandler(this.ManageIClint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClintStatusDtaGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchClint;
        private System.Windows.Forms.TextBox TextSearchClint;
        private System.Windows.Forms.Button MangeClintGoback;
        private System.Windows.Forms.Button ClintMakeInAct;
        private System.Windows.Forms.Button ClintMakeAct;
        private System.Windows.Forms.Button ShowClintStatus;
        private System.Windows.Forms.DataGridView ClintStatusDtaGrid;
        private System.Windows.Forms.Label ListOfClintLevel;
    }
}
namespace Medgenix
{
    partial class Patient
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
            this.ProvideDssInfo = new System.Windows.Forms.Label();
            this.DiseaseSymptoms = new System.Windows.Forms.Label();
            this.DssSymptComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DssRsnComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BlodGrpComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgeGrpComboBox = new System.Windows.Forms.ComboBox();
            this.Area = new System.Windows.Forms.Label();
            this.AreacomboBox = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProvideDssInfo
            // 
            this.ProvideDssInfo.AutoSize = true;
            this.ProvideDssInfo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvideDssInfo.Location = new System.Drawing.Point(57, 89);
            this.ProvideDssInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProvideDssInfo.Name = "ProvideDssInfo";
            this.ProvideDssInfo.Size = new System.Drawing.Size(540, 62);
            this.ProvideDssInfo.TabIndex = 5;
            this.ProvideDssInfo.Text = "Share Your Information To Identify Disease\r\n\r\n";
            // 
            // DiseaseSymptoms
            // 
            this.DiseaseSymptoms.AutoSize = true;
            this.DiseaseSymptoms.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiseaseSymptoms.Location = new System.Drawing.Point(80, 177);
            this.DiseaseSymptoms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiseaseSymptoms.Name = "DiseaseSymptoms";
            this.DiseaseSymptoms.Size = new System.Drawing.Size(158, 31);
            this.DiseaseSymptoms.TabIndex = 9;
            this.DiseaseSymptoms.Text = "Symptoms :";
            // 
            // DssSymptComboBox
            // 
            this.DssSymptComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DssSymptComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DssSymptComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DssSymptComboBox.FormattingEnabled = true;
            this.DssSymptComboBox.Items.AddRange(new object[] {
            "Fever",
            "Shivering",
            "Aching",
            "Exhaustion",
            "Sweat",
            "Whistling",
            "Gasping",
            "Tightness",
            "Puffing",
            "Thirsty",
            "Peeing",
            "Hunger",
            "Blurry",
            "DryMouth",
            "Pounding",
            "Ringing",
            "Dizzy",
            "Faint",
            "Pale",
            "Cold",
            "Tired",
            "Weakness"});
            this.DssSymptComboBox.Location = new System.Drawing.Point(258, 177);
            this.DssSymptComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.DssSymptComboBox.Name = "DssSymptComboBox";
            this.DssSymptComboBox.Size = new System.Drawing.Size(173, 32);
            this.DssSymptComboBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 243);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 31);
            this.label6.TabIndex = 28;
            this.label6.Text = " Reason     :";
            // 
            // DssRsnComboBox
            // 
            this.DssRsnComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DssRsnComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DssRsnComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DssRsnComboBox.FormattingEnabled = true;
            this.DssRsnComboBox.Items.AddRange(new object[] {
            "Virus",
            "Infection",
            "Transmission",
            "Contagion",
            "Exposure",
            "Genetics",
            "Allergens",
            "Pollution",
            "Irritants",
            "Inflammation",
            "Insulin",
            "Genetics",
            "Obesity",
            "Lifestyle",
            "Autoimmunity",
            "Sodium",
            "Stress",
            "Heredity",
            "Inactivity",
            "Aging",
            "Iron-deficiency",
            "Hemorrhage",
            "Nutrition",
            "Malabsorption",
            "Genetics"});
            this.DssRsnComboBox.Location = new System.Drawing.Point(258, 242);
            this.DssRsnComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.DssRsnComboBox.Name = "DssRsnComboBox";
            this.DssRsnComboBox.Size = new System.Drawing.Size(173, 32);
            this.DssRsnComboBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 31);
            this.label2.TabIndex = 30;
            this.label2.Text = "Blood Group    :";
            // 
            // BlodGrpComboBox
            // 
            this.BlodGrpComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BlodGrpComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BlodGrpComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BlodGrpComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlodGrpComboBox.FormattingEnabled = true;
            this.BlodGrpComboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.BlodGrpComboBox.Location = new System.Drawing.Point(258, 302);
            this.BlodGrpComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.BlodGrpComboBox.Name = "BlodGrpComboBox";
            this.BlodGrpComboBox.Size = new System.Drawing.Size(173, 32);
            this.BlodGrpComboBox.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 367);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 31);
            this.label3.TabIndex = 32;
            this.label3.Text = "Age   :";
            // 
            // AgeGrpComboBox
            // 
            this.AgeGrpComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AgeGrpComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AgeGrpComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgeGrpComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeGrpComboBox.FormattingEnabled = true;
            this.AgeGrpComboBox.Items.AddRange(new object[] {
            "Newborn(0 – 28 Day)",
            "Baby(29 Days – 1 Year)",
            "Toddler(1 – 3 Years)",
            "Preschooler(3 – 5 Years)",
            "Child(6 – 12 Years)",
            "Teenager(13 – 18 Years)",
            "Adult(19+ Years)"});
            this.AgeGrpComboBox.Location = new System.Drawing.Point(258, 366);
            this.AgeGrpComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.AgeGrpComboBox.Name = "AgeGrpComboBox";
            this.AgeGrpComboBox.Size = new System.Drawing.Size(173, 32);
            this.AgeGrpComboBox.TabIndex = 33;
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.Location = new System.Drawing.Point(139, 421);
            this.Area.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(98, 31);
            this.Area.TabIndex = 34;
            this.Area.Text = "Area   :";
            // 
            // AreacomboBox
            // 
            this.AreacomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AreacomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AreacomboBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AreacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreacomboBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreacomboBox.FormattingEnabled = true;
            this.AreacomboBox.Items.AddRange(new object[] {
            "Dhaka",
            "Chattogram",
            "Khulna",
            "Rajshahi",
            "Rangpur",
            "Barishal",
            "Sylhet",
            "Mymensingh"});
            this.AreacomboBox.Location = new System.Drawing.Point(258, 421);
            this.AreacomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.AreacomboBox.Name = "AreacomboBox";
            this.AreacomboBox.Size = new System.Drawing.Size(173, 32);
            this.AreacomboBox.TabIndex = 35;
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(370, 500);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(259, 44);
            this.Submit.TabIndex = 37;
            this.Submit.Text = "Get Recommendation ";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 636);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 44);
            this.button3.TabIndex = 39;
            this.button3.Text = "Log Out";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(789, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 31);
            this.label8.TabIndex = 40;
            this.label8.Text = "Recommendation :\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(666, 116);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(500, 218);
            this.textBox1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(844, 381);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 42;
            this.label1.Text = "Share Review :\r\n";
            this.label1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(766, 430);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(337, 162);
            this.textBox2.TabIndex = 43;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1047, 636);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 44);
            this.button2.TabIndex = 44;
            this.button2.Text = "Share";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 48);
            this.button1.TabIndex = 45;
            this.button1.Text = "Home Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1178, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.AreacomboBox);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.AgeGrpComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BlodGrpComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DssRsnComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DssSymptComboBox);
            this.Controls.Add(this.DiseaseSymptoms);
            this.Controls.Add(this.ProvideDssInfo);
            this.Name = "Patient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProvideDssInfo;
        private System.Windows.Forms.Label DiseaseSymptoms;
        private System.Windows.Forms.ComboBox DssSymptComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DssRsnComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BlodGrpComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AgeGrpComboBox;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.ComboBox AreacomboBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
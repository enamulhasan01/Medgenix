namespace Medgenix
{
    partial class Data_Input
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
            this.DiseaseName = new System.Windows.Forms.Label();
            this.DssNamecomboBox = new System.Windows.Forms.ComboBox();
            this.DiseaseSymptoms = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DssRsnComboBox = new System.Windows.Forms.ComboBox();
            this.DssSymptComboBox = new System.Windows.Forms.ComboBox();
            this.DoctorsTreatment = new System.Windows.Forms.Label();
            this.DctsTrmtComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HospitalNmcomboBox = new System.Windows.Forms.ComboBox();
            this.Area = new System.Windows.Forms.Label();
            this.AreacomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BlodGrpComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgeGrpComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CureStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Log_Out = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Show_RE_D = new System.Windows.Forms.TextBox();
            this.Claim = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ProvideDssInfo
            // 
            this.ProvideDssInfo.AutoSize = true;
            this.ProvideDssInfo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvideDssInfo.Location = new System.Drawing.Point(143, 46);
            this.ProvideDssInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProvideDssInfo.Name = "ProvideDssInfo";
            this.ProvideDssInfo.Size = new System.Drawing.Size(444, 31);
            this.ProvideDssInfo.TabIndex = 4;
            this.ProvideDssInfo.Text = "Share Information Abour Diseases :";
            // 
            // DiseaseName
            // 
            this.DiseaseName.AutoSize = true;
            this.DiseaseName.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiseaseName.Location = new System.Drawing.Point(96, 134);
            this.DiseaseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiseaseName.Name = "DiseaseName";
            this.DiseaseName.Size = new System.Drawing.Size(192, 31);
            this.DiseaseName.TabIndex = 5;
            this.DiseaseName.Text = "Disease Name:";
            // 
            // DssNamecomboBox
            // 
            this.DssNamecomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DssNamecomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DssNamecomboBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DssNamecomboBox.FormattingEnabled = true;
            this.DssNamecomboBox.Items.AddRange(new object[] {
            "Influenza",
            "Asthma",
            "Diabetes",
            "Hypertension",
            "Anemia"});
            this.DssNamecomboBox.Location = new System.Drawing.Point(307, 133);
            this.DssNamecomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DssNamecomboBox.Name = "DssNamecomboBox";
            this.DssNamecomboBox.Size = new System.Drawing.Size(160, 32);
            this.DssNamecomboBox.TabIndex = 7;
            this.DssNamecomboBox.SelectedIndexChanged += new System.EventHandler(this.DssNamecomboBox_SelectedIndexChanged);
            // 
            // DiseaseSymptoms
            // 
            this.DiseaseSymptoms.AutoSize = true;
            this.DiseaseSymptoms.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiseaseSymptoms.Location = new System.Drawing.Point(37, 187);
            this.DiseaseSymptoms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiseaseSymptoms.Name = "DiseaseSymptoms";
            this.DiseaseSymptoms.Size = new System.Drawing.Size(250, 31);
            this.DiseaseSymptoms.TabIndex = 8;
            this.DiseaseSymptoms.Text = "Disease Symptoms:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "Disease Reason:";
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
            this.DssRsnComboBox.Location = new System.Drawing.Point(307, 244);
            this.DssRsnComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DssRsnComboBox.Name = "DssRsnComboBox";
            this.DssRsnComboBox.Size = new System.Drawing.Size(160, 32);
            this.DssRsnComboBox.TabIndex = 24;
            this.DssRsnComboBox.SelectedIndexChanged += new System.EventHandler(this.DssRsnComboBox_SelectedIndexChanged);
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
            this.DssSymptComboBox.Location = new System.Drawing.Point(307, 186);
            this.DssSymptComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DssSymptComboBox.Name = "DssSymptComboBox";
            this.DssSymptComboBox.Size = new System.Drawing.Size(160, 32);
            this.DssSymptComboBox.TabIndex = 25;
            this.DssSymptComboBox.SelectedIndexChanged += new System.EventHandler(this.DssSymptComboBox_SelectedIndexChanged);
            // 
            // DoctorsTreatment
            // 
            this.DoctorsTreatment.AutoSize = true;
            this.DoctorsTreatment.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorsTreatment.Location = new System.Drawing.Point(37, 298);
            this.DoctorsTreatment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DoctorsTreatment.Name = "DoctorsTreatment";
            this.DoctorsTreatment.Size = new System.Drawing.Size(250, 31);
            this.DoctorsTreatment.TabIndex = 26;
            this.DoctorsTreatment.Text = "Doctors Treatment:";
            // 
            // DctsTrmtComboBox
            // 
            this.DctsTrmtComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DctsTrmtComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DctsTrmtComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DctsTrmtComboBox.FormattingEnabled = true;
            this.DctsTrmtComboBox.Items.AddRange(new object[] {
            "Antiviral",
            "Bronchodilator",
            "Insulin",
            "Antihypertensive",
            "Supplement"});
            this.DctsTrmtComboBox.Location = new System.Drawing.Point(307, 297);
            this.DctsTrmtComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DctsTrmtComboBox.Name = "DctsTrmtComboBox";
            this.DctsTrmtComboBox.Size = new System.Drawing.Size(160, 32);
            this.DctsTrmtComboBox.TabIndex = 27;
            this.DctsTrmtComboBox.SelectedIndexChanged += new System.EventHandler(this.DctsTrmtComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 345);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "Hospital Name :";
            // 
            // HospitalNmcomboBox
            // 
            this.HospitalNmcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.HospitalNmcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.HospitalNmcomboBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HospitalNmcomboBox.FormattingEnabled = true;
            this.HospitalNmcomboBox.Items.AddRange(new object[] {
            "Dhaka Medical",
            "Evercare",
            "Square",
            "Chattogram Medical",
            "Khulna Medical",
            "Rajshahi Medical",
            "Osmani Medical",
            "Rangpur Medical",
            "Sher-e-Bangla Medical",
            "Mymensingh Medical"});
            this.HospitalNmcomboBox.Location = new System.Drawing.Point(307, 351);
            this.HospitalNmcomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HospitalNmcomboBox.Name = "HospitalNmcomboBox";
            this.HospitalNmcomboBox.Size = new System.Drawing.Size(160, 32);
            this.HospitalNmcomboBox.TabIndex = 29;
            this.HospitalNmcomboBox.SelectedIndexChanged += new System.EventHandler(this.HospitalNmcomboBox_SelectedIndexChanged);
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.Location = new System.Drawing.Point(211, 398);
            this.Area.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(77, 31);
            this.Area.TabIndex = 30;
            this.Area.Text = "Area:";
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
            this.AreacomboBox.Location = new System.Drawing.Point(307, 405);
            this.AreacomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AreacomboBox.Name = "AreacomboBox";
            this.AreacomboBox.Size = new System.Drawing.Size(160, 32);
            this.AreacomboBox.TabIndex = 31;
            this.AreacomboBox.SelectedIndexChanged += new System.EventHandler(this.AreacomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 455);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 31);
            this.label2.TabIndex = 32;
            this.label2.Text = "Blood Group:";
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
            this.BlodGrpComboBox.Location = new System.Drawing.Point(307, 455);
            this.BlodGrpComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BlodGrpComboBox.Name = "BlodGrpComboBox";
            this.BlodGrpComboBox.Size = new System.Drawing.Size(160, 32);
            this.BlodGrpComboBox.TabIndex = 33;
            this.BlodGrpComboBox.SelectedIndexChanged += new System.EventHandler(this.BlodGrpComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 505);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 31);
            this.label3.TabIndex = 34;
            this.label3.Text = "Age Group:";
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
            this.AgeGrpComboBox.Location = new System.Drawing.Point(307, 503);
            this.AgeGrpComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AgeGrpComboBox.Name = "AgeGrpComboBox";
            this.AgeGrpComboBox.Size = new System.Drawing.Size(160, 32);
            this.AgeGrpComboBox.TabIndex = 35;
            this.AgeGrpComboBox.SelectedIndexChanged += new System.EventHandler(this.AgeGrpComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 559);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 31);
            this.label4.TabIndex = 36;
            this.label4.Text = "Cure Status:";
            // 
            // CureStatusComboBox
            // 
            this.CureStatusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CureStatusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CureStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CureStatusComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CureStatusComboBox.FormattingEnabled = true;
            this.CureStatusComboBox.Items.AddRange(new object[] {
            "Start (0%)",
            "Sick (20%)",
            "Reacting (40%)",
            "Better (60%)",
            "Almost (80%)",
            "Cured (100%)"});
            this.CureStatusComboBox.Location = new System.Drawing.Point(307, 559);
            this.CureStatusComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CureStatusComboBox.Name = "CureStatusComboBox";
            this.CureStatusComboBox.Size = new System.Drawing.Size(160, 32);
            this.CureStatusComboBox.TabIndex = 37;
            this.CureStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.CureStatusComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 610);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "Date:";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTextBox.Location = new System.Drawing.Point(307, 610);
            this.DateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(200, 30);
            this.DateTextBox.TabIndex = 39;
            this.DateTextBox.TextChanged += new System.EventHandler(this.DateTextBox_TextChanged);
            // 
            // Submit_Button
            // 
            this.Submit_Button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_Button.Location = new System.Drawing.Point(523, 652);
            this.Submit_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(153, 53);
            this.Submit_Button.TabIndex = 40;
            this.Submit_Button.Text = "Submit";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(1, 692);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(153, 53);
            this.Clear.TabIndex = 42;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Log_Out
            // 
            this.Log_Out.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_Out.Location = new System.Drawing.Point(1157, 692);
            this.Log_Out.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Log_Out.Name = "Log_Out";
            this.Log_Out.Size = new System.Drawing.Size(153, 53);
            this.Log_Out.TabIndex = 43;
            this.Log_Out.Text = "Log Out";
            this.Log_Out.UseVisualStyleBackColor = true;
            this.Log_Out.Click += new System.EventHandler(this.Log_Out_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(494, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(418, 31);
            this.label7.TabIndex = 45;
            this.label7.Text = "Share Drive Link About Diseases :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1025, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 31);
            this.label8.TabIndex = 46;
            this.label8.Text = "Reward Point :\r\n";
            // 
            // Show_RE_D
            // 
            this.Show_RE_D.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Show_RE_D.Location = new System.Drawing.Point(900, 186);
            this.Show_RE_D.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Show_RE_D.Multiline = true;
            this.Show_RE_D.Name = "Show_RE_D";
            this.Show_RE_D.ReadOnly = true;
            this.Show_RE_D.Size = new System.Drawing.Size(411, 368);
            this.Show_RE_D.TabIndex = 47;
            this.Show_RE_D.TextChanged += new System.EventHandler(this.Show_RE_D_TextChanged);
            // 
            // Claim
            // 
            this.Claim.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Claim.Location = new System.Drawing.Point(1125, 514);
            this.Claim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Claim.Name = "Claim";
            this.Claim.Size = new System.Drawing.Size(187, 39);
            this.Claim.TabIndex = 48;
            this.Claim.Text = "Claim Reward";
            this.Claim.UseVisualStyleBackColor = true;
            this.Claim.Click += new System.EventHandler(this.Claim_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(589, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 49;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Data_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1336, 751);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Claim);
            this.Controls.Add(this.Show_RE_D);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Log_Out);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CureStatusComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AgeGrpComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BlodGrpComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AreacomboBox);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.HospitalNmcomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DctsTrmtComboBox);
            this.Controls.Add(this.DoctorsTreatment);
            this.Controls.Add(this.DssSymptComboBox);
            this.Controls.Add(this.DssRsnComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DiseaseSymptoms);
            this.Controls.Add(this.DssNamecomboBox);
            this.Controls.Add(this.DiseaseName);
            this.Controls.Add(this.ProvideDssInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Data_Input";
            this.Text = "Data_Input";
            this.Load += new System.EventHandler(this.Data_Input_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProvideDssInfo;
        private System.Windows.Forms.Label DiseaseName;
        private System.Windows.Forms.ComboBox DssNamecomboBox;
        private System.Windows.Forms.Label DiseaseSymptoms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DssRsnComboBox;
        private System.Windows.Forms.ComboBox DssSymptComboBox;
        private System.Windows.Forms.Label DoctorsTreatment;
        private System.Windows.Forms.ComboBox DctsTrmtComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HospitalNmcomboBox;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.ComboBox AreacomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BlodGrpComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AgeGrpComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CureStatusComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Log_Out;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Show_RE_D;
        private System.Windows.Forms.Button Claim;
        private System.Windows.Forms.TextBox textBox1;
    }
}
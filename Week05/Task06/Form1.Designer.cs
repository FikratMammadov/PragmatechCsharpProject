namespace Task06
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.markaComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.yanacaqComboBox = new System.Windows.Forms.ComboBox();
            this.kuzaComboBox = new System.Windows.Forms.ComboBox();
            this.skorostComboBox = new System.Windows.Forms.ComboBox();
            this.motorComboBox = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addBtn = new System.Windows.Forms.Button();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yanacaq Tipi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Motor Tipi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Skorost Tipi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kuza Tipi";
            // 
            // markaComboBox
            // 
            this.markaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.markaComboBox.FormattingEnabled = true;
            this.markaComboBox.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Mercedes"});
            this.markaComboBox.Location = new System.Drawing.Point(87, 31);
            this.markaComboBox.Name = "markaComboBox";
            this.markaComboBox.Size = new System.Drawing.Size(152, 21);
            this.markaComboBox.TabIndex = 6;
            this.markaComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // modelComboBox
            // 
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(87, 73);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(152, 21);
            this.modelComboBox.TabIndex = 7;
            // 
            // yanacaqComboBox
            // 
            this.yanacaqComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yanacaqComboBox.FormattingEnabled = true;
            this.yanacaqComboBox.Items.AddRange(new object[] {
            "Benzin",
            "Dizel"});
            this.yanacaqComboBox.Location = new System.Drawing.Point(347, 31);
            this.yanacaqComboBox.Name = "yanacaqComboBox";
            this.yanacaqComboBox.Size = new System.Drawing.Size(152, 21);
            this.yanacaqComboBox.TabIndex = 8;
            // 
            // kuzaComboBox
            // 
            this.kuzaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kuzaComboBox.FormattingEnabled = true;
            this.kuzaComboBox.Items.AddRange(new object[] {
            "Qapali",
            "Aciq",
            "Sedan",
            "Pikap"});
            this.kuzaComboBox.Location = new System.Drawing.Point(347, 73);
            this.kuzaComboBox.Name = "kuzaComboBox";
            this.kuzaComboBox.Size = new System.Drawing.Size(152, 21);
            this.kuzaComboBox.TabIndex = 9;
            // 
            // skorostComboBox
            // 
            this.skorostComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skorostComboBox.FormattingEnabled = true;
            this.skorostComboBox.Items.AddRange(new object[] {
            "Avtomat",
            "Mexanika"});
            this.skorostComboBox.Location = new System.Drawing.Point(636, 31);
            this.skorostComboBox.Name = "skorostComboBox";
            this.skorostComboBox.Size = new System.Drawing.Size(152, 21);
            this.skorostComboBox.TabIndex = 10;
            // 
            // motorComboBox
            // 
            this.motorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.motorComboBox.FormattingEnabled = true;
            this.motorComboBox.Items.AddRange(new object[] {
            "motor1",
            "motor2",
            "motor3",
            "motor4"});
            this.motorComboBox.Location = new System.Drawing.Point(636, 73);
            this.motorComboBox.Name = "motorComboBox";
            this.motorComboBox.Size = new System.Drawing.Size(152, 21);
            this.motorComboBox.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(49, 196);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(739, 198);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marka";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yanacaq Tipi";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kuza Tipi";
            this.columnHeader4.Width = 84;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Skorost Tipi";
            this.columnHeader5.Width = 89;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Motor Tipi";
            this.columnHeader6.Width = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Reng";
            // 
            // colorBtn
            // 
            this.colorBtn.Location = new System.Drawing.Point(87, 112);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(47, 38);
            this.colorBtn.TabIndex = 15;
            this.colorBtn.Text = "Color";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(347, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(636, 119);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(127, 51);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "Əlavə et";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Rəng";
            this.columnHeader7.Width = 93;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Buraxilis ili";
            this.columnHeader8.Width = 93;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Buraxilis ili";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.colorBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.motorComboBox);
            this.Controls.Add(this.skorostComboBox);
            this.Controls.Add(this.kuzaComboBox);
            this.Controls.Add(this.yanacaqComboBox);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.markaComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox markaComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.ComboBox yanacaqComboBox;
        private System.Windows.Forms.ComboBox kuzaComboBox;
        private System.Windows.Forms.ComboBox skorostComboBox;
        private System.Windows.Forms.ComboBox motorComboBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label9;
    }
}


namespace PizzaApp
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
            this.pizzaList = new System.Windows.Forms.ListBox();
            this.radioFine = new System.Windows.Forms.RadioButton();
            this.radioThick = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numberUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.addShoppingCartBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.orderBtn = new System.Windows.Forms.Button();
            this.groupBoxIngridients = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberUpDown)).BeginInit();
            this.groupBoxIngridients.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(903, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Sifarisi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pizza:";
            // 
            // pizzaList
            // 
            this.pizzaList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pizzaList.FormattingEnabled = true;
            this.pizzaList.ItemHeight = 16;
            this.pizzaList.Items.AddRange(new object[] {
            "Klassik",
            "Qarisiq",
            "Pendirli",
            "Kolbasali",
            "Italiano",
            "Mexicano"});
            this.pizzaList.Location = new System.Drawing.Point(12, 132);
            this.pizzaList.Name = "pizzaList";
            this.pizzaList.Size = new System.Drawing.Size(222, 148);
            this.pizzaList.TabIndex = 2;
            // 
            // radioFine
            // 
            this.radioFine.AutoSize = true;
            this.radioFine.Location = new System.Drawing.Point(13, 296);
            this.radioFine.Name = "radioFine";
            this.radioFine.Size = new System.Drawing.Size(80, 17);
            this.radioFine.TabIndex = 3;
            this.radioFine.TabStop = true;
            this.radioFine.Text = "Ince kenarli";
            this.radioFine.UseVisualStyleBackColor = true;
            // 
            // radioThick
            // 
            this.radioThick.AutoSize = true;
            this.radioThick.Location = new System.Drawing.Point(147, 296);
            this.radioThick.Name = "radioThick";
            this.radioThick.Size = new System.Drawing.Size(83, 17);
            this.radioThick.TabIndex = 4;
            this.radioThick.TabStop = true;
            this.radioThick.Text = "Qalin kenarli";
            this.radioThick.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Pendirli";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(20, 54);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Sosisli";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(20, 77);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(67, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Zeytunlu";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(20, 100);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(70, 17);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "Gobelekli";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(20, 123);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(71, 17);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "Pul biberli";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(154, 123);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(101, 17);
            this.checkBox6.TabIndex = 14;
            this.checkBox6.Text = "Dana basdirmali";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(154, 100);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(72, 17);
            this.checkBox7.TabIndex = 13;
            this.checkBox7.Text = "Toyuq etli";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(154, 77);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(68, 17);
            this.checkBox8.TabIndex = 12;
            this.checkBox8.Text = "Kolbasali";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(154, 54);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(78, 17);
            this.checkBox9.TabIndex = 11;
            this.checkBox9.Text = "Yasil biberli";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(154, 31);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(61, 17);
            this.checkBox10.TabIndex = 10;
            this.checkBox10.Text = "Soganli";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pizzanin olcusu:";
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Items.AddRange(new object[] {
            "Kicik",
            "Orta",
            "Boyuk",
            "Maxi"});
            this.sizeComboBox.Location = new System.Drawing.Point(12, 78);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(222, 21);
            this.sizeComboBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Eded:";
            // 
            // numberUpDown
            // 
            this.numberUpDown.Location = new System.Drawing.Point(53, 489);
            this.numberUpDown.Name = "numberUpDown";
            this.numberUpDown.Size = new System.Drawing.Size(120, 20);
            this.numberUpDown.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Hesabla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.Location = new System.Drawing.Point(283, 78);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(625, 394);
            this.shoppingCartListBox.TabIndex = 20;
            // 
            // addShoppingCartBtn
            // 
            this.addShoppingCartBtn.Location = new System.Drawing.Point(494, 491);
            this.addShoppingCartBtn.Name = "addShoppingCartBtn";
            this.addShoppingCartBtn.Size = new System.Drawing.Size(107, 23);
            this.addShoppingCartBtn.TabIndex = 23;
            this.addShoppingCartBtn.Text = "Sebete elave et";
            this.addShoppingCartBtn.UseVisualStyleBackColor = true;
            this.addShoppingCartBtn.Click += new System.EventHandler(this.addShoppingCartBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Total Mebleg:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(403, 494);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(13, 13);
            this.totalPriceLabel.TabIndex = 25;
            this.totalPriceLabel.Text = "0";
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(666, 491);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(101, 23);
            this.orderBtn.TabIndex = 26;
            this.orderBtn.Text = "Sifarisi tesdiqle";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // groupBoxIngridients
            // 
            this.groupBoxIngridients.Controls.Add(this.checkBox1);
            this.groupBoxIngridients.Controls.Add(this.checkBox2);
            this.groupBoxIngridients.Controls.Add(this.checkBox3);
            this.groupBoxIngridients.Controls.Add(this.checkBox4);
            this.groupBoxIngridients.Controls.Add(this.checkBox5);
            this.groupBoxIngridients.Controls.Add(this.checkBox10);
            this.groupBoxIngridients.Controls.Add(this.checkBox9);
            this.groupBoxIngridients.Controls.Add(this.checkBox8);
            this.groupBoxIngridients.Controls.Add(this.checkBox7);
            this.groupBoxIngridients.Controls.Add(this.checkBox6);
            this.groupBoxIngridients.Location = new System.Drawing.Point(15, 332);
            this.groupBoxIngridients.Name = "groupBoxIngridients";
            this.groupBoxIngridients.Size = new System.Drawing.Size(255, 151);
            this.groupBoxIngridients.TabIndex = 28;
            this.groupBoxIngridients.TabStop = false;
            this.groupBoxIngridients.Text = "Ingridients";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 529);
            this.Controls.Add(this.groupBoxIngridients);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addShoppingCartBtn);
            this.Controls.Add(this.shoppingCartListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sizeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioThick);
            this.Controls.Add(this.radioFine);
            this.Controls.Add(this.pizzaList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberUpDown)).EndInit();
            this.groupBoxIngridients.ResumeLayout(false);
            this.groupBoxIngridients.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox pizzaList;
        private System.Windows.Forms.RadioButton radioFine;
        private System.Windows.Forms.RadioButton radioThick;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numberUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.Button addShoppingCartBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.GroupBox groupBoxIngridients;
    }
}


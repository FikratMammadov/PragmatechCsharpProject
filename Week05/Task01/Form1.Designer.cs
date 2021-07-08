namespace Task01
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.operatorBox = new System.Windows.Forms.ComboBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(104, 25);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(243, 25);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 1;
            // 
            // operatorBox
            // 
            this.operatorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operatorBox.FormattingEnabled = true;
            this.operatorBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
            this.operatorBox.Location = new System.Drawing.Point(379, 25);
            this.operatorBox.Name = "operatorBox";
            this.operatorBox.Size = new System.Drawing.Size(121, 21);
            this.operatorBox.TabIndex = 2;
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(211, 83);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(13, 13);
            this.labelAnswer.TabIndex = 3;
            this.labelAnswer.Text = "0";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(112, 83);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(37, 13);
            this.result.TabIndex = 4;
            this.result.Text = "Result";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(379, 68);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(121, 42);
            this.calculateBtn.TabIndex = 5;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.result);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.operatorBox);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ComboBox operatorBox;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button calculateBtn;
    }
}


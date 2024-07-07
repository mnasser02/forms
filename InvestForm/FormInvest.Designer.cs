namespace Forms {
    partial class FormInvest {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            insertbtn = new Button();
            editbtn = new Button();
            vehl = new Button();
            button4 = new Button();
            button5 = new Button();
            InvPers = new Button();
            cancelbtn = new Button();
            newbtn = new Button();
            deletebtn = new Button();
            panel1 = new Panel();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            pictureBox1 = new PictureBox();
            insertDatePicker = new DateTimePicker();
            transactionDatePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            crimeTypeComboBox = new ComboBox();
            remarksTextBox = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // insertbtn
            // 
            insertbtn.Location = new Point(1024, 487);
            insertbtn.Name = "insertbtn";
            insertbtn.Size = new Size(94, 29);
            insertbtn.TabIndex = 0;
            insertbtn.Text = "إدخال";
            insertbtn.UseVisualStyleBackColor = true;
            insertbtn.Click += insertbtn_Click;
            // 
            // editbtn
            // 
            editbtn.Location = new Point(924, 487);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(94, 29);
            editbtn.TabIndex = 1;
            editbtn.Text = "تعديل";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // vehl
            // 
            vehl.Location = new Point(324, 487);
            vehl.Name = "vehl";
            vehl.Size = new Size(94, 29);
            vehl.TabIndex = 2;
            vehl.Text = "سيارات";
            vehl.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(224, 487);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "ملخص";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(424, 487);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "تصنيف";
            button5.UseVisualStyleBackColor = true;
            // 
            // InvPers
            // 
            InvPers.Location = new Point(524, 487);
            InvPers.Name = "InvPers";
            InvPers.Size = new Size(94, 29);
            InvPers.TabIndex = 5;
            InvPers.Text = "أشخاص";
            InvPers.UseVisualStyleBackColor = true;
            // 
            // cancelbtn
            // 
            cancelbtn.Location = new Point(624, 487);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(94, 29);
            cancelbtn.TabIndex = 6;
            cancelbtn.Text = "الغاء";
            cancelbtn.UseVisualStyleBackColor = true;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // newbtn
            // 
            newbtn.Location = new Point(724, 487);
            newbtn.Name = "newbtn";
            newbtn.Size = new Size(94, 29);
            newbtn.TabIndex = 7;
            newbtn.Text = "تحديث";
            newbtn.UseVisualStyleBackColor = true;
            newbtn.Click += newbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(824, 487);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(94, 29);
            deletebtn.TabIndex = 8;
            deletebtn.Text = "حذف";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button14);
            panel1.Controls.Add(button13);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 533);
            panel1.TabIndex = 9;
            // 
            // button14
            // 
            button14.Location = new Point(-3, 324);
            button14.Name = "button14";
            button14.Size = new Size(223, 58);
            button14.TabIndex = 5;
            button14.Text = "الجرائم";
            button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(-3, 260);
            button13.Name = "button13";
            button13.Size = new Size(223, 58);
            button13.TabIndex = 4;
            button13.Text = "إحصائيات";
            button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(-3, 196);
            button12.Name = "button12";
            button12.Size = new Size(223, 58);
            button12.TabIndex = 3;
            button12.Text = "المتهمين";
            button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(-3, 132);
            button11.Name = "button11";
            button11.Size = new Size(223, 58);
            button11.TabIndex = 2;
            button11.Text = "إدخال";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(0, 68);
            button10.Name = "button10";
            button10.Size = new Size(220, 58);
            button10.TabIndex = 1;
            button10.Text = "تقارير";
            button10.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // insertDatePicker
            // 
            insertDatePicker.Location = new Point(0, 37);
            insertDatePicker.Name = "insertDatePicker";
            insertDatePicker.Size = new Size(250, 27);
            insertDatePicker.TabIndex = 10;
            // 
            // transactionDatePicker
            // 
            transactionDatePicker.Location = new Point(0, 96);
            transactionDatePicker.Name = "transactionDatePicker";
            transactionDatePicker.Size = new Size(250, 27);
            transactionDatePicker.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 14);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 12;
            label1.Text = "تاريخ الادخال";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 72);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 13;
            label2.Text = "تاريخ المعاملة";
            // 
            // crimeTypeComboBox
            // 
            crimeTypeComboBox.FormattingEnabled = true;
            crimeTypeComboBox.Location = new Point(3, 157);
            crimeTypeComboBox.Name = "crimeTypeComboBox";
            crimeTypeComboBox.Size = new Size(247, 28);
            crimeTypeComboBox.TabIndex = 14;
            // 
            // remarksTextBox
            // 
            remarksTextBox.Location = new Point(0, 211);
            remarksTextBox.Name = "remarksTextBox";
            remarksTextBox.Size = new Size(247, 252);
            remarksTextBox.TabIndex = 16;
            remarksTextBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 160);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 17;
            label3.Text = "[الجرم]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 221);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 18;
            label4.Text = "[موضوع المعاملة]";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(490, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(628, 417);
            dataGridView1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(remarksTextBox);
            panel2.Controls.Add(insertDatePicker);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(transactionDatePicker);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(crimeTypeComboBox);
            panel2.Location = new Point(224, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 466);
            panel2.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 134);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 20;
            label6.Text = "[ ادخال جرم جديد]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 188);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 19;
            label5.Text = "[موضوع المعاملة]";
            // 
            // FormInvest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 528);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(deletebtn);
            Controls.Add(newbtn);
            Controls.Add(cancelbtn);
            Controls.Add(InvPers);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(vehl);
            Controls.Add(editbtn);
            Controls.Add(insertbtn);
            Name = "FormInvest";
            Text = "FormInvest";
            Load += FormInvest_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button insertbtn;
        private Button editbtn;
        private Button vehl;
        private Button button4;
        private Button button5;
        private Button InvPers;
        private Button cancelbtn;
        private Button newbtn;
        private Button deletebtn;
        private Panel panel1;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private PictureBox pictureBox1;
        private Button button14;
        private DateTimePicker insertDatePicker;
        private DateTimePicker transactionDatePicker;
        private Label label1;
        private Label label2;
        private ComboBox crimeTypeComboBox;
        private RichTextBox remarksTextBox;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label6;
        private Label label5;
    }
}

namespace Forms {
    partial class FormPerson {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            insertBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            cancelBtn = new Button();
            panel1 = new Panel();
            label5 = new Label();
            archTextBox = new TextBox();
            idnumTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            mobilenoTextBox = new TextBox();
            adrsTextBox = new TextBox();
            label1 = new Label();
            label6 = new Label();
            label4 = new Label();
            dbirthDateTimePicker = new DateTimePicker();
            nicknameTextBox = new TextBox();
            occupationTextBox = new TextBox();
            genderComboBox = new ComboBox();
            statusComboBox = new ComboBox();
            exstCheckBox = new CheckBox();
            label12 = new Label();
            attrComboBox = new ComboBox();
            residComboBox = new ComboBox();
            pbirthComboBox = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            nationComboBox = new ComboBox();
            regTextBox = new TextBox();
            motherTextBox = new TextBox();
            fatherTextBox = new TextBox();
            lnameTextBox = new TextBox();
            fnameTextBox = new TextBox();
            serialTextBox = new TextBox();
            serpersTextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            fpBtn = new Button();
            faceBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // insertBtn
            // 
            insertBtn.BackColor = SystemColors.GradientActiveCaption;
            insertBtn.Font = new Font("Times New Roman", 13.8F);
            insertBtn.ForeColor = SystemColors.Desktop;
            insertBtn.Location = new Point(1142, 680);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(103, 35);
            insertBtn.TabIndex = 0;
            insertBtn.Text = "إدخال";
            insertBtn.UseVisualStyleBackColor = false;
            insertBtn.Click += insertBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = SystemColors.GradientActiveCaption;
            updateBtn.Font = new Font("Times New Roman", 13.8F);
            updateBtn.ForeColor = SystemColors.Desktop;
            updateBtn.Location = new Point(918, 680);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(105, 35);
            updateBtn.TabIndex = 1;
            updateBtn.Text = "تعديل";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = SystemColors.GradientActiveCaption;
            deleteBtn.Font = new Font("Times New Roman", 13.8F);
            deleteBtn.ForeColor = SystemColors.Desktop;
            deleteBtn.Location = new Point(1029, 680);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(107, 35);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "حذف";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = SystemColors.GradientActiveCaption;
            cancelBtn.Font = new Font("Times New Roman", 13.8F);
            cancelBtn.ForeColor = SystemColors.Desktop;
            cancelBtn.Location = new Point(807, 680);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(105, 35);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "إلغاء";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(archTextBox);
            panel1.Controls.Add(idnumTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(mobilenoTextBox);
            panel1.Controls.Add(adrsTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dbirthDateTimePicker);
            panel1.Controls.Add(nicknameTextBox);
            panel1.Controls.Add(occupationTextBox);
            panel1.Controls.Add(genderComboBox);
            panel1.Controls.Add(statusComboBox);
            panel1.Controls.Add(exstCheckBox);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(attrComboBox);
            panel1.Controls.Add(residComboBox);
            panel1.Controls.Add(pbirthComboBox);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(nationComboBox);
            panel1.Controls.Add(regTextBox);
            panel1.Controls.Add(motherTextBox);
            panel1.Controls.Add(fatherTextBox);
            panel1.Controls.Add(lnameTextBox);
            panel1.Controls.Add(fnameTextBox);
            panel1.Controls.Add(serialTextBox);
            panel1.Controls.Add(serpersTextBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 691);
            panel1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F);
            label5.ForeColor = SystemColors.MenuText;
            label5.Location = new Point(299, 488);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(85, 20);
            label5.TabIndex = 37;
            label5.Text = "الرقم الداخلي";
            // 
            // archTextBox
            // 
            archTextBox.Location = new Point(18, 485);
            archTextBox.Name = "archTextBox";
            archTextBox.Size = new Size(273, 27);
            archTextBox.TabIndex = 36;
            archTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // idnumTextBox
            // 
            idnumTextBox.Location = new Point(18, 289);
            idnumTextBox.Name = "idnumTextBox";
            idnumTextBox.Size = new Size(238, 27);
            idnumTextBox.TabIndex = 35;
            idnumTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F);
            label3.ForeColor = SystemColors.MenuText;
            label3.Location = new Point(312, 292);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(68, 20);
            label3.TabIndex = 34;
            label3.Text = "رقم الهوية";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F);
            label2.ForeColor = SystemColors.MenuText;
            label2.Location = new Point(299, 409);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(87, 20);
            label2.TabIndex = 33;
            label2.Text = "الرقم الخليوي";
            // 
            // mobilenoTextBox
            // 
            mobilenoTextBox.Location = new Point(18, 406);
            mobilenoTextBox.Name = "mobilenoTextBox";
            mobilenoTextBox.Size = new Size(273, 27);
            mobilenoTextBox.TabIndex = 32;
            mobilenoTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // adrsTextBox
            // 
            adrsTextBox.Location = new Point(18, 373);
            adrsTextBox.Name = "adrsTextBox";
            adrsTextBox.Size = new Size(273, 27);
            adrsTextBox.TabIndex = 31;
            adrsTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(297, 373);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(82, 20);
            label1.TabIndex = 30;
            label1.Text = "عنوان السكن";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F);
            label6.ForeColor = SystemColors.MenuText;
            label6.Location = new Point(334, 576);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(46, 20);
            label6.TabIndex = 29;
            label6.Text = "الجنس";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F);
            label4.ForeColor = SystemColors.MenuText;
            label4.Location = new Point(274, 542);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(106, 20);
            label4.TabIndex = 28;
            label4.Text = "الحالة الاجتماعية";
            // 
            // dbirthDateTimePicker
            // 
            dbirthDateTimePicker.Location = new Point(18, 256);
            dbirthDateTimePicker.Name = "dbirthDateTimePicker";
            dbirthDateTimePicker.Size = new Size(238, 27);
            dbirthDateTimePicker.TabIndex = 27;
            // 
            // nicknameTextBox
            // 
            nicknameTextBox.Font = new Font("Times New Roman", 10.8F);
            nicknameTextBox.ForeColor = SystemColors.WindowFrame;
            nicknameTextBox.Location = new Point(202, 619);
            nicknameTextBox.Name = "nicknameTextBox";
            nicknameTextBox.Size = new Size(183, 28);
            nicknameTextBox.TabIndex = 26;
            nicknameTextBox.Text = "[اللقب]";
            nicknameTextBox.TextAlign = HorizontalAlignment.Right;
            nicknameTextBox.Click += nicknameTextBox_Click;
            nicknameTextBox.Leave += nicknameTextBox_Leave;
            // 
            // occupationTextBox
            // 
            occupationTextBox.Font = new Font("Times New Roman", 10.8F);
            occupationTextBox.ForeColor = SystemColors.WindowFrame;
            occupationTextBox.Location = new Point(202, 652);
            occupationTextBox.Name = "occupationTextBox";
            occupationTextBox.Size = new Size(183, 28);
            occupationTextBox.TabIndex = 25;
            occupationTextBox.Text = "[المهنة]";
            occupationTextBox.TextAlign = HorizontalAlignment.Right;
            occupationTextBox.Click += occupationTextBox_Click;
            occupationTextBox.Leave += occupationTextBox_Leave;
            // 
            // genderComboBox
            // 
            genderComboBox.BackColor = SystemColors.InactiveBorder;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(117, 575);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.RightToLeft = RightToLeft.Yes;
            genderComboBox.Size = new Size(151, 28);
            genderComboBox.TabIndex = 13;
            // 
            // statusComboBox
            // 
            statusComboBox.BackColor = SystemColors.InactiveBorder;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(117, 538);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.RightToLeft = RightToLeft.Yes;
            statusComboBox.Size = new Size(151, 28);
            statusComboBox.TabIndex = 14;
            // 
            // exstCheckBox
            // 
            exstCheckBox.AutoSize = true;
            exstCheckBox.Font = new Font("Times New Roman", 10.8F);
            exstCheckBox.ForeColor = SystemColors.MenuText;
            exstCheckBox.Location = new Point(236, 455);
            exstCheckBox.Name = "exstCheckBox";
            exstCheckBox.RightToLeft = RightToLeft.Yes;
            exstCheckBox.Size = new Size(146, 24);
            exstCheckBox.TabIndex = 15;
            exstCheckBox.Text = "هل يوجد رقم داخلي";
            exstCheckBox.UseVisualStyleBackColor = true;
            exstCheckBox.CheckedChanged += exstCheckBox_CheckedChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 10.8F);
            label12.ForeColor = SystemColors.MenuText;
            label12.Location = new Point(299, 263);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.Yes;
            label12.Size = new Size(81, 20);
            label12.TabIndex = 24;
            label12.Text = "تاريخ الولادة";
            // 
            // attrComboBox
            // 
            attrComboBox.BackColor = SystemColors.InactiveBorder;
            attrComboBox.Font = new Font("Times New Roman", 10.8F);
            attrComboBox.FormattingEnabled = true;
            attrComboBox.Location = new Point(18, 322);
            attrComboBox.Name = "attrComboBox";
            attrComboBox.RightToLeft = RightToLeft.Yes;
            attrComboBox.Size = new Size(238, 28);
            attrComboBox.TabIndex = 23;
            attrComboBox.Text = "مدعي";
            attrComboBox.SelectedIndexChanged += attrComboBox_SelectedIndexChanged;
            // 
            // residComboBox
            // 
            residComboBox.BackColor = SystemColors.InactiveBorder;
            residComboBox.FormattingEnabled = true;
            residComboBox.Location = new Point(18, 222);
            residComboBox.Name = "residComboBox";
            residComboBox.RightToLeft = RightToLeft.Yes;
            residComboBox.Size = new Size(238, 28);
            residComboBox.TabIndex = 22;
            residComboBox.SelectedIndexChanged += residComboBox_SelectedIndexChanged;
            // 
            // pbirthComboBox
            // 
            pbirthComboBox.BackColor = SystemColors.InactiveBorder;
            pbirthComboBox.FormattingEnabled = true;
            pbirthComboBox.Location = new Point(18, 188);
            pbirthComboBox.Name = "pbirthComboBox";
            pbirthComboBox.RightToLeft = RightToLeft.Yes;
            pbirthComboBox.Size = new Size(238, 28);
            pbirthComboBox.TabIndex = 21;
            pbirthComboBox.SelectedIndexChanged += pbirthComboBox_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10.8F);
            label11.ForeColor = SystemColors.MenuText;
            label11.Location = new Point(307, 230);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.Yes;
            label11.Size = new Size(77, 20);
            label11.TabIndex = 20;
            label11.Text = "محل الإقامة";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.8F);
            label10.ForeColor = SystemColors.MenuText;
            label10.Location = new Point(305, 196);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(77, 20);
            label10.TabIndex = 14;
            label10.Text = "محل الولادة";
            // 
            // nationComboBox
            // 
            nationComboBox.BackColor = SystemColors.InactiveBorder;
            nationComboBox.Font = new Font("Times New Roman", 10.8F);
            nationComboBox.FormattingEnabled = true;
            nationComboBox.Location = new Point(18, 154);
            nationComboBox.Name = "nationComboBox";
            nationComboBox.RightToLeft = RightToLeft.Yes;
            nationComboBox.Size = new Size(238, 28);
            nationComboBox.TabIndex = 15;
            nationComboBox.Text = "لبنان";
            nationComboBox.SelectedIndexChanged += nationComboBox_SelectedIndexChanged;
            // 
            // regTextBox
            // 
            regTextBox.Font = new Font("Times New Roman", 10.8F);
            regTextBox.ForeColor = SystemColors.WindowFrame;
            regTextBox.Location = new Point(18, 121);
            regTextBox.Name = "regTextBox";
            regTextBox.Size = new Size(376, 28);
            regTextBox.TabIndex = 19;
            regTextBox.Text = "[رقم و مكان السجل]";
            regTextBox.TextAlign = HorizontalAlignment.Right;
            regTextBox.Click += regTextBox_Click;
            regTextBox.Leave += regTextBox_Leave;
            // 
            // motherTextBox
            // 
            motherTextBox.Font = new Font("Times New Roman", 10.8F);
            motherTextBox.ForeColor = SystemColors.WindowFrame;
            motherTextBox.Location = new Point(18, 88);
            motherTextBox.Name = "motherTextBox";
            motherTextBox.Size = new Size(183, 28);
            motherTextBox.TabIndex = 18;
            motherTextBox.Text = "[اسم الأم]";
            motherTextBox.TextAlign = HorizontalAlignment.Right;
            motherTextBox.Click += motherTextBox_Click;
            motherTextBox.Leave += motherTextBox_Leave;
            // 
            // fatherTextBox
            // 
            fatherTextBox.Font = new Font("Times New Roman", 10.8F);
            fatherTextBox.ForeColor = SystemColors.WindowFrame;
            fatherTextBox.Location = new Point(210, 88);
            fatherTextBox.Name = "fatherTextBox";
            fatherTextBox.Size = new Size(184, 28);
            fatherTextBox.TabIndex = 17;
            fatherTextBox.Text = "[اسم الأب]";
            fatherTextBox.TextAlign = HorizontalAlignment.Right;
            fatherTextBox.Click += fatherTextBox_Click;
            fatherTextBox.Leave += fatherTextBox_Leave;
            // 
            // lnameTextBox
            // 
            lnameTextBox.Font = new Font("Times New Roman", 10.8F);
            lnameTextBox.ForeColor = SystemColors.WindowFrame;
            lnameTextBox.Location = new Point(18, 55);
            lnameTextBox.Name = "lnameTextBox";
            lnameTextBox.Size = new Size(183, 28);
            lnameTextBox.TabIndex = 16;
            lnameTextBox.Text = "[الشهرة]";
            lnameTextBox.TextAlign = HorizontalAlignment.Right;
            lnameTextBox.Click += lnameTextBox_Click;
            lnameTextBox.Leave += lnameTextBox_Leave;
            // 
            // fnameTextBox
            // 
            fnameTextBox.Font = new Font("Times New Roman", 10.8F);
            fnameTextBox.ForeColor = SystemColors.WindowFrame;
            fnameTextBox.Location = new Point(210, 55);
            fnameTextBox.Name = "fnameTextBox";
            fnameTextBox.Size = new Size(184, 28);
            fnameTextBox.TabIndex = 15;
            fnameTextBox.Text = "[الاسم]";
            fnameTextBox.TextAlign = HorizontalAlignment.Right;
            fnameTextBox.Click += fnameTextBox_Click;
            fnameTextBox.Leave += fnameTextBox_Leave;
            // 
            // serialTextBox
            // 
            serialTextBox.Location = new Point(365, 6);
            serialTextBox.Name = "serialTextBox";
            serialTextBox.Size = new Size(30, 27);
            serialTextBox.TabIndex = 14;
            // 
            // serpersTextBox
            // 
            serpersTextBox.Location = new Point(173, 6);
            serpersTextBox.Name = "serpersTextBox";
            serpersTextBox.Size = new Size(30, 27);
            serpersTextBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.8F);
            label7.ForeColor = SystemColors.MenuText;
            label7.Location = new Point(227, 9);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(132, 20);
            label7.TabIndex = 11;
            label7.Text = "الرقم المتسلسل للملف";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.8F);
            label8.ForeColor = SystemColors.MenuText;
            label8.Location = new Point(20, 9);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(147, 20);
            label8.TabIndex = 12;
            label8.Text = "الرقم المتسلسل للشخص\n";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(403, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(842, 570);
            dataGridView1.TabIndex = 5;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // fpBtn
            // 
            fpBtn.BackColor = SystemColors.GradientActiveCaption;
            fpBtn.Font = new Font("Times New Roman", 13.8F);
            fpBtn.ForeColor = SystemColors.Desktop;
            fpBtn.Location = new Point(613, 680);
            fpBtn.Name = "fpBtn";
            fpBtn.Size = new Size(156, 35);
            fpBtn.TabIndex = 6;
            fpBtn.Text = "إدخال البصمة";
            fpBtn.UseVisualStyleBackColor = false;
            fpBtn.Click += fpBtn_Click;
            // 
            // faceBtn
            // 
            faceBtn.BackColor = SystemColors.GradientActiveCaption;
            faceBtn.Font = new Font("Times New Roman", 13.8F);
            faceBtn.ForeColor = SystemColors.Desktop;
            faceBtn.Location = new Point(451, 680);
            faceBtn.Name = "faceBtn";
            faceBtn.Size = new Size(156, 35);
            faceBtn.TabIndex = 7;
            faceBtn.Text = "إدخال الوجه ";
            faceBtn.UseVisualStyleBackColor = false;
            faceBtn.Click += faceBtn_Click;
            // 
            // FormPerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1257, 727);
            Controls.Add(faceBtn);
            Controls.Add(fpBtn);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(cancelBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(insertBtn);
            Name = "FormPerson";
            Text = "FormPerson";
            Load += FormPerson_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button insertBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button cancelBtn;
        private Panel panel1;
        private Label label7;
        private Label label8;
        private Label label10;
        private TextBox regTextBox;
        private TextBox motherTextBox;
        private TextBox fatherTextBox;
        private TextBox lnameTextBox;
        private TextBox fnameTextBox;
        private TextBox serialTextBox;
        private Label label12;
        private ComboBox attrComboBox;
        private ComboBox residComboBox;
        private ComboBox pbirthComboBox;
        private Label label11;
        private ComboBox nationComboBox;
        private CheckBox exstCheckBox;
        private ComboBox statusComboBox;
        private ComboBox genderComboBox;
        private TextBox nicknameTextBox;
        private TextBox occupationTextBox;
        private DataGridView dataGridView1;
        private DateTimePicker dbirthDateTimePicker;
        private Label label6;
        private Label label4;
        private TextBox adrsTextBox;
        private Label label1;
        private Label label2;
        private TextBox mobilenoTextBox;
        private Label label3;
        private TextBox idnumTextBox;
        private Label label5;
        private TextBox archTextBox;
        private TextBox serpersTextBox;
        private Button fpBtn;
        private Button faceBtn;
    }
}
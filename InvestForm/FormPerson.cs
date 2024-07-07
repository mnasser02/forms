﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvestForm.Repositories;
using InvestForm.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms {
    public partial class FormPerson : Form {

        private InvEntities _context;
        public FormPerson() {
            InitializeComponent();
            PopulateComboBox();
            _context = new InvEntities();
            dataGridView1.ReadOnly = true;
        }

        private void PopulateComboBox() {
            var genders = new List<string> {
                "ذكر",
                "أنثى"
            };

            var pbirths = new List<string> {
                "بيروت",
                "طرابلس",
                "صيدا",
                "صور",
                "جبيل",
                "بعلبك",
                "زحلة",
                "البترون",
                "الشوف",
                "النبطية",
                "عاليه",
                "بشري",
                "الكورة",
                "جزين",
                "بنت جبيل"
            };

            var resids = new List<string> {
                "بيروت",
                "طرابلس",
                "صيدا",
                "صور",
                "جبيل",
                "بعلبك",
                "زحلة",
                "البترون",
                "الشوف",
                "النبطية",
                "عاليه",
                "بشري",
                "الكورة",
                "جزين",
                "بنت جبيل"
            };


            var statuses = new List<string> {
                "أعزب",
                "متزوج",
                "مطلق",
                "أرمل"
            };

            pbirthComboBox.DataSource = pbirths;
            pbirthComboBox.SelectedIndex = -1;

            residComboBox.DataSource = resids;
            residComboBox.SelectedIndex = -1;

            statusComboBox.DataSource = statuses;
            statusComboBox.SelectedIndex = -1;

            genderComboBox.DataSource = genders;
            genderComboBox.SelectedIndex = -1;

        }

        private async void FormPerson_Load(object sender, EventArgs e) {
            await LoadPersonsAsync();
        }

        private async Task LoadPersonsAsync() {
            var persons = await _context.Invpersons.ToListAsync();
            dataGridView1.DataSource = persons;

            //   fix columns height

            dataGridView1.Columns["SERIAL"].Width = 50;
            dataGridView1.Columns["SERPERS"].Width = 50;
            dataGridView1.Columns["SERIAL"].HeaderText = "[الرقم المتسلسل للملف]";
            dataGridView1.Columns["SERPERS"].HeaderText = "[الرقم المتسلسل للشخص]";
            dataGridView1.Columns["FNAME"].HeaderText = "[الإسم]";
            dataGridView1.Columns["LNAME"].HeaderText = "[الشهرة]";
            dataGridView1.Columns["FATHER"].HeaderText = "[إسم الأب]";
            dataGridView1.Columns["MOTHER"].HeaderText = "[إسم الأم]";
            dataGridView1.Columns["NATION"].HeaderText = "[الجنسية]";
            dataGridView1.Columns["REG"].HeaderText = "[سجل القيد]";
            dataGridView1.Columns["PBIRTH"].HeaderText = "[محل الولادة]";
            dataGridView1.Columns["DBIRTH"].HeaderText = "[تأريخ الولادة]";
            dataGridView1.Columns["RESID"].HeaderText = "[محل السكن]";
            dataGridView1.Columns["ADRS"].HeaderText = "[عنوان السكن]";
            dataGridView1.Columns["ATTR"].HeaderText = "[الصفة]";
            dataGridView1.Columns["EXST"].HeaderText = "[هل يوجد رقم في الداخلي]";
            dataGridView1.Columns["ARCH"].HeaderText = "[الرقم في الداخلي]";
            dataGridView1.Columns["nickname"].HeaderText = "[اللقب]";
            dataGridView1.Columns["occupation"].HeaderText = "[المهنة]";
            dataGridView1.Columns["idnum"].HeaderText = "[رقم الهوية]";
            dataGridView1.Columns["mobileno"].HeaderText = "[رقم الهاتف]";
            dataGridView1.Columns["status"].HeaderText = "[الحالة الاجتماعية]";
            dataGridView1.Columns["gender"].HeaderText = "[الجنس]";
        }

        private async void insertBtn_Click(object sender, EventArgs e) {
            if (MessageBox.Show("سيتم ادخال المعلومات", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) {

                if(!verify()) {
                    return;
                }
                int serialNumber = Convert.ToInt32(serialTextBox.Text);
                int serpersNumber = Convert.ToInt32(serpersTextBox.Text);
                var person = await _context.Invpersons.FindAsync(serialNumber, serpersNumber);

                if (person != null) {
                    MessageBox.Show("السجل موجود في قاعدة البيانات");
                    return;
                }

                var newPerson = new Invperson {
                    Serial = Convert.ToInt32(serialTextBox.Text),
                    Serpers = Convert.ToInt32(serpersTextBox.Text),
                    Fname = fnameTextBox.Text == "[الاسم]" ? "" : fnameTextBox.Text,
                    Lname = lnameTextBox.Text == "[الشهرة]" ? "" : lnameTextBox.Text,
                    Father = fatherTextBox.Text == "[اسم الأب]" ? "" : fatherTextBox.Text,
                    Mother = motherTextBox.Text == "[اسم الأم]" ? "" : motherTextBox.Text,
                    //Nation = nationComboBox.Text, int??
                    Reg = regTextBox.Text == "[رقم و مكان السجل]" ? "" : regTextBox.Text,
                    Pbirth = pbirthComboBox.Text,
                    //Dbirth = DateOnly.FromDateTime(dbirthDateTimePicker.Value), int??
                    Resid = residComboBox.Text,
                    //Adrs = adrsTextBox.Text,
                    //Attr = attrComboBox.Text, int??
                    Exst = Convert.ToInt32(exstCheckBox.Checked),
                    //Arch = archTextBox.Text,
                    Nickname = nicknameTextBox.Text == "[اللقب]" ? "" : nicknameTextBox.Text,
                    Occupation = occupationTextBox.Text == "[المهنة]" ? "" : occupationTextBox.Text,
                    //Idnum = idnumTextBox.Text,
                    //Mobileno = mobilenoTextBox.Text,
                    Status = statusComboBox.Text,
                    Gender = genderComboBox.Text
                };

                _context.Invpersons.Add(newPerson);
                await _context.SaveChangesAsync();
                await LoadPersonsAsync();
                ResetForm();
            }
            else {
                MessageBox.Show("لقد قمت بالنقر فوق زر الإلغاء");
            }

        }


        private void cancelBtn_Click(object sender, EventArgs e) {
            ResetForm();
        }

        private async void deleteBtn_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                var confirmation = MessageBox.Show("هل أنت متأكد أنك تريد حذف هذا الشخص؟", "تأكيد", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes) {
                    int serialNumber = (int)dataGridView1.SelectedRows[0].Cells["SERIAL"].Value;
                    int serpersNumber = (int)dataGridView1.SelectedRows[0].Cells["SERPERS"].Value;
                    var person = await _context.Invpersons.FindAsync(serialNumber, serpersNumber);
                    if (person != null) {
                        _context.Invpersons.Remove(person);
                        _context.SaveChanges();
                        await LoadPersonsAsync();
                        MessageBox.Show("تم حذف الشخص بنجاح");
                    }
                    else {
                        MessageBox.Show("لم يتم العثور على الشخص");
                    }

                }
            }
            else {
                MessageBox.Show("الرجاء تحديد تحقيق لحذفه");
            }

        }

        private async void updateBtn_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                if (MessageBox.Show("هل تريد تحديث معلومات الشخص؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes) {

                    if(!verify()) {
                        return;
                    }

                    int serialNumber = (int)dataGridView1.SelectedRows[0].Cells["SERIAL"].Value;
                    int serpersNumber = (int)dataGridView1.SelectedRows[0].Cells["SERPERS"].Value;
                    var person = await _context.Invpersons.FindAsync(serialNumber, serpersNumber);

                    if (person != null) {

                        person.Serial = Convert.ToInt32(serialTextBox.Text);
                        person.Serpers = Convert.ToInt32(serpersTextBox.Text);
                        person.Fname = fnameTextBox.Text == "[الاسم]" ? "" : fnameTextBox.Text;
                        person.Lname = lnameTextBox.Text == "[الشهرة]" ? "" : lnameTextBox.Text;
                        person.Father = fatherTextBox.Text == "[اسم الأب]" ? "" : fatherTextBox.Text;
                        person.Mother = motherTextBox.Text == "[اسم الأم]" ? "" : motherTextBox.Text;
                        //person.Nation = nationComboBox.Text; int??
                        person.Reg = regTextBox.Text;
                        person.Pbirth = pbirthComboBox.Text;
                        //person.Dbirth = DateOnly.FromDateTime(dbirthDateTimePicker.Value); int??
                        person.Resid = residComboBox.Text;
                        //person.Adrs = adrsTextBox.Text;
                        //person.Attr = attrComboBox.Text; int??
                        person.Exst = Convert.ToInt32(exstCheckBox.Checked);
                        //person.Arch = archTextBox.Text;
                        person.Nickname = nicknameTextBox.Text == "[اللقب]" ? "" : nicknameTextBox.Text;
                        person.Occupation = occupationTextBox.Text == "[المهنة]" ? "" : occupationTextBox.Text;
                        //person.Idnum = idnumTextBox.Text;
                        //person.Mobileno = mobilenoTextBox.Text;
                        person.Status = statusComboBox.Text;
                        person.Gender = genderComboBox.Text;

                        try {
                            await _context.SaveChangesAsync();
                            await LoadPersonsAsync();
                            MessageBox.Show("تم تحديث الشخص بنجاح");
                            ResetForm();
                        }
                        catch (DbUpdateConcurrencyException) {
                            MessageBox.Show("السجل الذي حاولت تعديله تم تعديله بواسطة مستخدم آخر بعد أن حصلت على القيمة الأصلية. تم إلغاء عملية التعديل");
                        }
                    }
                }
                else {
                    MessageBox.Show("تم إلغاء العملية");
                }
            }
            else {
                MessageBox.Show("الرجاء تحديد تحقيق لتعديله");
            }
        }

        private bool verify() {
            if (!int.TryParse(serialTextBox.Text, out _)) {
                MessageBox.Show("الرجاء إدخال رقم متسلسل صحيح");
                return false;
            }

            if (!int.TryParse(serpersTextBox.Text, out _)) {
                MessageBox.Show("الرجاء إدخال رقم متسلسل صحيح للشخص");
                return false;
            }

            if (fnameTextBox.Text == "[الاسم]" && nicknameTextBox.Text == "[اللقب]") {
                MessageBox.Show("الرجاء إدخال الإسم أو اللقب");
                return false;
            }

            return true;
        }

        private void ResetForm() {
            serialTextBox.Text = "";
            serpersTextBox.Text = "";
            fnameTextBox.Text = "[الاسم]";
            lnameTextBox.Text = "[الشهرة]";
            fatherTextBox.Text = "[اسم الأب]";
            motherTextBox.Text = "[اسم الأم]";
            nationComboBox.SelectedIndex = -1;
            regTextBox.Text = "[رقم و مكان السجل]";
            pbirthComboBox.SelectedIndex = -1;
            dbirthDateTimePicker.Value = DateTime.Now;
            residComboBox.SelectedIndex = -1;
            //adrsTextBox.Text = "";
            attrComboBox.SelectedIndex = -1;
            exstCheckBox.Checked = false;
            checkBox.Checked = false;
            //archTextBox.Text = "";
            nicknameTextBox.Text = "[اللقب]";
            occupationTextBox.Text = "[المهنة]";
            //idnumTextBox.Text = "";
            //mobilenoTextBox.Text = "";
            statusComboBox.SelectedIndex = -1;
            genderComboBox.SelectedIndex = -1;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                serialTextBox.Text = selectedRow.Cells["SERIAL"].Value.ToString();
                serpersTextBox.Text = selectedRow.Cells["SERPERS"].Value.ToString();
                fnameTextBox.Text = selectedRow.Cells["FNAME"].Value.ToString();
                if (fnameTextBox.Text == "") {
                    fnameTextBox.Text = "[الاسم]";
                }
                lnameTextBox.Text = selectedRow.Cells["LNAME"].Value.ToString();
                if (lnameTextBox.Text == "") {
                    lnameTextBox.Text = "[الشهرة]";
                }
                fatherTextBox.Text = selectedRow.Cells["FATHER"].Value.ToString();
                if (fatherTextBox.Text == "") {
                    fatherTextBox.Text = "[اسم الأب]";
                }
                motherTextBox.Text = selectedRow.Cells["MOTHER"].Value.ToString();
                if (motherTextBox.Text == "") {
                    motherTextBox.Text = "[اسم الأم]";
                }
                //nationComboBox.Text = selectedRow.Cells["NATION"].Value.ToString(); error
                regTextBox.Text = selectedRow.Cells["REG"].Value.ToString();
                if (regTextBox.Text == "") {
                    regTextBox.Text = "[رقم و مكان السجل]";
                }
                pbirthComboBox.Text = selectedRow.Cells["PBIRTH"].Value.ToString();
                //dbirthDateTimePicker.Value = Convert.ToDateTime(selectedRow.Cells["DBIRTH"].Value); error
                residComboBox.Text = selectedRow.Cells["RESID"].Value.ToString();
                //adrsTextBox.Text = selectedRow.Cells["ADRS"].Value.ToString();
                //attrComboBox.Text = selectedRow.Cells["ATTR"].Value.ToString(); error
                exstCheckBox.Checked = Convert.ToBoolean(selectedRow.Cells["EXST"].Value);
                checkBox.Checked = Convert.ToBoolean(selectedRow.Cells["ARCH"].Value);
                //archTextBox.Text = selectedRow.Cells["ARCH"].Value.ToString();
                nicknameTextBox.Text = selectedRow.Cells["nickname"].Value.ToString();
                if (nicknameTextBox.Text == "") {
                    nicknameTextBox.Text = "[اللقب]";
                }
                occupationTextBox.Text = selectedRow.Cells["occupation"].Value.ToString();
                if (occupationTextBox.Text == "") {
                    occupationTextBox.Text = "[المهنة]";
                }
                //idnumTextBox.Text = selectedRow.Cells["idnum"].Value.ToString();
                //mobilenoTextBox.Text = selectedRow.Cells["mobileno"].Value.ToString();
                statusComboBox.Text = selectedRow.Cells["status"].Value.ToString();
                genderComboBox.Text = selectedRow.Cells["Gender"].Value.ToString();

            }
        }


        private void fnameTextBox_Click(object sender, EventArgs e) {
            if (fnameTextBox.Text == "[الاسم]") {
                fnameTextBox.Text = "";
            }
        }

        private void fatherTextBox_Click(object sender, EventArgs e) {
            if (fatherTextBox.Text == "[اسم الأب]") {
                fatherTextBox.Text = "";
            }
        }

        private void motherTextBox_Click(object sender, EventArgs e) {
            if (motherTextBox.Text == "[اسم الأم]") {
                motherTextBox.Text = "";
            }
        }

        private void lnameTextBox_Click(object sender, EventArgs e) {
            if (lnameTextBox.Text == "[الشهرة]") {
                lnameTextBox.Text = "";
            }
        }

        private void fnameTextBox_Leave(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(fnameTextBox.Text)) {
                fnameTextBox.Text = "[الاسم]";
            }
        }

        private void fatherTextBox_Leave(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(fatherTextBox.Text)) {
                fatherTextBox.Text = "[اسم الأب]";
            }
        }

        private void lnameTextBox_Leave(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(lnameTextBox.Text)) {
                lnameTextBox.Text = "[الشهرة]";
            }
        }

        private void motherTextBox_Leave(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(motherTextBox.Text)) {
                motherTextBox.Text = "[اسم الأم]";
            }
        }

        private void regTextBox_Click(object sender, EventArgs e) {
            if (regTextBox.Text == "[رقم و مكان السجل]") {
                regTextBox.Text = "";
            }
        }

        private void regTextBox_Leave(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(regTextBox.Text)) {
                regTextBox.Text = "[رقم و مكان السجل]";
            }
        }

        private void nicknameTextBox_Click(object sender, EventArgs e) {
            if (nicknameTextBox.Text == "[اللقب]") {
                nicknameTextBox.Text = "";
            }
        }

        private void nicknameTextBox_Leave(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(nicknameTextBox.Text)) {
                nicknameTextBox.Text = "[اللقب]";
            }
        }


        private void occupationTextBox_Click(object sender, EventArgs e) {
            if (occupationTextBox.Text == "[المهنة]") {
                occupationTextBox.Text = "";
            }
        }

        private void occupationTextBox_Leave(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(occupationTextBox.Text)) {
                occupationTextBox.Text = "[المهنة]";
            }
        }
    }
}
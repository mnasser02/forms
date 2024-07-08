using System;
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
using OfficeOpenXml;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms {
    public partial class FormPerson : Form {

        private readonly string ROOT_DIR = Directory.GetCurrentDirectory();
        private InvEntities _context;
        private int prevIndexNation, prevIndexPbirth, prevIndexResid, prevIndexAttr;
        public FormPerson() {
            InitializeComponent();
            InitComboBoxes();
            _context = new InvEntities();
            dataGridView1.ReadOnly = true;
            archTextBox.Enabled = false;
        }

        private void InitComboBoxes() {
            populatenationComboBox();
            populateresidComboBox();
            populatepbirthComboBox();
            populateattrComboBox();
            populatestatusComboBox();
            populategenderComboBox();

            nationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            attrComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            pbirthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            residComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            prevIndexNation = nationComboBox.SelectedIndex;
            prevIndexPbirth = pbirthComboBox.SelectedIndex;
            prevIndexResid = residComboBox.SelectedIndex;
            prevIndexAttr = attrComboBox.SelectedIndex;
        }

        private void populatenationComboBox() {
            string filePath = "../../../TABLES/nations.xlsx";
            string column = "C";
            var nations = ReadColumnFromExcel(filePath, column);


            nationComboBox.DataSource = nations;
            nationComboBox.SelectedIndex = 0;
        }

        private void populateattrComboBox() {
            string filePath = "../../../TABLES/attr.xlsx";
            string column = "C";
            var attr = ReadColumnFromExcel(filePath, column);
           
            attrComboBox.DataSource = attr;
            attrComboBox.SelectedIndex = 0;
        }

        private void populateresidComboBox() {
            string filePath = "../../../TABLES/VILLAGE.xlsx";
            string column = "C";
            var resids = ReadColumnFromExcel(filePath, column);

            residComboBox.DataSource = resids;
            residComboBox.SelectedIndex = -1;
        }

        private void populatepbirthComboBox() {
            string filePath = "../../../TABLES/VILLAGE.xlsx";
            string column = "C";
            var pbirths = ReadColumnFromExcel(filePath, column);

            pbirthComboBox.DataSource = pbirths;
            pbirthComboBox.SelectedIndex = -1;
        }

        private void populatestatusComboBox() {
            var statuses = new List<string> {
                "أعزب",
                "متزوج",
                "مطلق",
                "أرمل"
            };

            statusComboBox.DataSource = statuses;
            statusComboBox.SelectedIndex = -1;
        }

        private void populategenderComboBox() {
            var genders = new List<string> {
                "ذكر",
                "أنثى"
            };

            genderComboBox.DataSource = genders;
            genderComboBox.SelectedIndex = -1;
        }

        static List<string> ReadColumnFromExcel(string filePath, string columnName) {
            var data = new List<string>();

            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo)) {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; 
                int totalRows = worksheet.Dimension.Rows;

                for (int row = 2; row <= totalRows; row++) {
                    var cellValue = worksheet.Cells[$"{columnName}{row}"].Text;
                    data.Add(cellValue);
                }
            }

            return data;
        }

        private async void FormPerson_Load(object sender, EventArgs e) {
            await LoadPersonsAsync();
        }

        private async Task LoadPersonsAsync() {
            var persons = await _context.Invpersons.ToListAsync();
            dataGridView1.DataSource = persons;

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

                if (!verify()) {
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
                    Nation = nationComboBox.SelectedIndex,
                    Reg = regTextBox.Text == "[رقم و مكان السجل]" ? "" : regTextBox.Text,
                    Pbirth = pbirthComboBox.Text,
                    Dbirth = Convert.ToInt32(dbirthDateTimePicker.Value.ToString("yyyyMMdd")),
                    Resid = residComboBox.Text,
                    Adrs = adrsTextBox.Text,
                    Attr = attrComboBox.SelectedIndex,
                    Exst = Convert.ToInt32(exstCheckBox.Checked),
                    Arch = exstCheckBox.Checked ? Convert.ToInt32(archTextBox.Text) : null,
                    Nickname = nicknameTextBox.Text == "[اللقب]" ? "" : nicknameTextBox.Text,
                    Occupation = occupationTextBox.Text == "[المهنة]" ? "" : occupationTextBox.Text,
                    Idnum = idnumTextBox.Text,
                    Mobileno = mobilenoTextBox.Text,
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

                    if (!verify()) {
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
                        person.Nation = nationComboBox.SelectedIndex;
                        person.Reg = regTextBox.Text == "[رقم و مكان السجل]" ? "" : regTextBox.Text;
                        person.Pbirth = pbirthComboBox.Text;
                        person.Dbirth = Convert.ToInt32(dbirthDateTimePicker.Value.ToString("yyyyMMdd"));
                        person.Resid = residComboBox.Text;
                        person.Adrs = adrsTextBox.Text;
                        person.Attr = attrComboBox.SelectedIndex;
                        person.Exst = Convert.ToInt32(exstCheckBox.Checked);
                        person.Arch = exstCheckBox.Checked ? Convert.ToInt32(archTextBox.Text) : null;
                        person.Nickname = nicknameTextBox.Text == "[اللقب]" ? "" : nicknameTextBox.Text;
                        person.Occupation = occupationTextBox.Text == "[المهنة]" ? "" : occupationTextBox.Text;
                        person.Idnum = idnumTextBox.Text;
                        person.Mobileno = mobilenoTextBox.Text;
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

            if (exstCheckBox.Checked && !int.TryParse(archTextBox.Text, out _)) {
                MessageBox.Show("الرجاء إدخال رقم داخلي صحيح");
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
            nationComboBox.SelectedIndex = 0;

            regTextBox.Text = "[رقم و مكان السجل]";
            pbirthComboBox.SelectedIndex = -1;
            dbirthDateTimePicker.Value = DateTime.Now;
            residComboBox.SelectedIndex = -1;
            adrsTextBox.Text = "";
            attrComboBox.SelectedIndex = 0;
            exstCheckBox.Checked = false;
            archTextBox.Text = "";
            nicknameTextBox.Text = "[اللقب]";
            occupationTextBox.Text = "[المهنة]";
            idnumTextBox.Text = "";
            mobilenoTextBox.Text = "";
            statusComboBox.SelectedIndex = -1;
            genderComboBox.SelectedIndex = -1;


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                ResetForm();
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

                prevIndexNation = Convert.ToInt32(selectedRow.Cells["NATION"].Value);
                nationComboBox.SelectedIndex = Convert.ToInt32(selectedRow.Cells["NATION"].Value);

                regTextBox.Text = selectedRow.Cells["REG"].Value.ToString();
                if (regTextBox.Text == "") {
                    regTextBox.Text = "[رقم و مكان السجل]";
                }
                pbirthComboBox.Text = selectedRow.Cells["PBIRTH"].Value.ToString();

                DateTime date;
                DateTime.TryParseExact(selectedRow.Cells["DBIRTH"].Value.ToString(), "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out date);
                dbirthDateTimePicker.Value = date;

                residComboBox.Text = selectedRow.Cells["RESID"].Value.ToString();
                adrsTextBox.Text = selectedRow.Cells["ADRS"].Value.ToString();

                prevIndexAttr = Convert.ToInt32(selectedRow.Cells["ATTR"].Value);
                attrComboBox.SelectedIndex = Convert.ToInt32(selectedRow.Cells["ATTR"].Value);

                exstCheckBox.Checked = Convert.ToBoolean(selectedRow.Cells["EXST"].Value);
                if (exstCheckBox.Checked) {
                    archTextBox.Text = selectedRow.Cells["ARCH"].Value.ToString();
                }

                nicknameTextBox.Text = selectedRow.Cells["nickname"].Value.ToString();
                if (nicknameTextBox.Text == "") {
                    nicknameTextBox.Text = "[اللقب]";
                }
                occupationTextBox.Text = selectedRow.Cells["occupation"].Value.ToString();
                if (occupationTextBox.Text == "") {
                    occupationTextBox.Text = "[المهنة]";
                }
                idnumTextBox.Text = selectedRow.Cells["idnum"].Value.ToString();
                mobilenoTextBox.Text = selectedRow.Cells["mobileno"].Value.ToString();
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

        private void nationComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (nationComboBox.SelectedIndex == prevIndexNation || nationComboBox.SelectedIndex == 0) {
                prevIndexNation = nationComboBox.SelectedIndex;
                return;
            }

            string selectedNation = nationComboBox.Text;

            // Display confirmation dialog to the user
            DialogResult result = MessageBox.Show($"هل أنت متأكد من رغبتك في تغيير الدولة إلى '{selectedNation}'؟",
                                                  "تأكيد تغيير الدولة",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.No) {
                nationComboBox.SelectedIndex = prevIndexNation;
            }
            else {
                prevIndexNation = nationComboBox.SelectedIndex;
            }
        }

        private void pbirthComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (pbirthComboBox.SelectedIndex == prevIndexPbirth || pbirthComboBox.SelectedIndex == -1 || prevIndexPbirth == -1) {
                prevIndexPbirth = pbirthComboBox.SelectedIndex;
                return;
            }

            string selectedPbirth = pbirthComboBox.Text;

            // Display confirmation dialog to the user
            DialogResult result = MessageBox.Show($"هل أنت متأكد من رغبتك في تغيير محل الولادة إلى '{selectedPbirth}'؟",
                                                  "تأكيد تغيير محل الولادة",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.No) {
                pbirthComboBox.SelectedIndex = prevIndexPbirth;
            }
            else {
                prevIndexPbirth = pbirthComboBox.SelectedIndex;
            }
        }

        private void residComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (residComboBox.SelectedIndex == prevIndexResid || residComboBox.SelectedIndex == -1 || prevIndexResid == -1) {
                prevIndexResid = residComboBox.SelectedIndex;
                return;
            }
            string selectedResid = residComboBox.Text;

            // Display confirmation dialog to the user
            DialogResult result = MessageBox.Show($"هل أنت متأكد من رغبتك في تغيير محل السكن إلى '{selectedResid}'؟",
                                                  "تأكيد تغيير محل السكن",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.No) {
                residComboBox.SelectedIndex = prevIndexResid;
            }
            else {
                prevIndexResid = residComboBox.SelectedIndex;
            }

        }

        private void attrComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (attrComboBox.SelectedIndex == prevIndexAttr || attrComboBox.SelectedIndex == 0) {
                prevIndexAttr = attrComboBox.SelectedIndex;
                return;
            }
            string selectedAttr = attrComboBox.Text;

            DialogResult result = MessageBox.Show($"هل أنت متأكد من رغبتك في تغيير الصفة إلى '{selectedAttr}'؟",
                                                  "تأكيد تغيير الصفة",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.No) {
                attrComboBox.SelectedIndex = prevIndexAttr;
            }
            else {
                prevIndexAttr = attrComboBox.SelectedIndex;
            }

        }

        private void exstCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (exstCheckBox.Checked) {
                archTextBox.Enabled = true;
            }
            else {
                archTextBox.Enabled = false;
            }
        }
    }
}

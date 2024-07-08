using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvestForm.Repositories;
using InvestForm.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;

namespace Forms {
    public partial class FormInvest : Form {

        private InvEntities _context;
        public FormInvest() {
            InitializeComponent();
            PopulateComboBox();
            _context = new InvEntities();
            dataGridView1.ReadOnly = true;
        }

        private void PopulateComboBox() {
            string filePath = "../../../TABLES/worldkey.xlsx";
            string column = "C";
            var crimeTypes = ReadColumnFromExcel(filePath, column);

            crimeTypeComboBox.DataSource = crimeTypes;
            crimeTypeComboBox.SelectedIndex = -1;
            crimeTypeComboBox.Text = "[«·Ã—„]";
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


        private async void FormInvest_Load(object sender, EventArgs e) {
            await LoadInvestigationsAsync();
        }

        private async Task LoadInvestigationsAsync() {
            var investigations = await _context.Invests.ToListAsync();
            dataGridView1.DataSource = investigations;
        }

        private async void insertbtn_Click(object sender, EventArgs e) {
            if (MessageBox.Show("”Ì „ «œŒ«· «·„⁄·Ê„« ", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                var newInvest = new Invest {
                    Serial = await _context.Invests.MaxAsync(i => (int?)i.Serial) + 1 ?? 1,
                    Crime = crimeTypeComboBox.Text == "[«·Ã—„]" ? "" : crimeTypeComboBox.Text,
                    Dfile = DateOnly.FromDateTime(insertDatePicker.Value),
                    Dmahdar = DateOnly.FromDateTime(transactionDatePicker.Value),
                    Rem = remarksTextBox.Text
                };

                _context.Invests.Add(newInvest);
                await _context.SaveChangesAsync();
                await LoadInvestigationsAsync();
                ResetForm();
            }
            else {
                MessageBox.Show("·ﬁœ ﬁ„  »«·‰ﬁ— ›Êﬁ “— «·≈·€«¡");
            }

        }
        private async void editbtn_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                if (MessageBox.Show("Â·  —Ìœ  ÕœÌÀ „⁄·Ê„«  «· ÕﬁÌﬁø", " √ﬂÌœ", MessageBoxButtons.YesNo) == DialogResult.Yes) {

                    int serialNumber = (int)dataGridView1.SelectedRows[0].Cells["Serial"].Value;
                    var invest = await _context.Invests.FindAsync(serialNumber);

                    if (invest != null) {
                        invest.Crime = crimeTypeComboBox.Text == "[«·Ã—„]" ? "" : crimeTypeComboBox.Text;
                        invest.Dfile = DateOnly.FromDateTime(insertDatePicker.Value);
                        invest.Dmahdar = DateOnly.FromDateTime(transactionDatePicker.Value);
                        invest.Rem = remarksTextBox.Text;

                        try {
                            await _context.SaveChangesAsync();
                            await LoadInvestigationsAsync();
                            MessageBox.Show(" „  ÕœÌÀ «· ÕﬁÌﬁ »‰Ã«Õ");
                            ResetForm();
                        }
                        catch (DbUpdateConcurrencyException) {
                            MessageBox.Show("«·”Ã· «·–Ì Õ«Ê·   ⁄œÌ·Â  „  ⁄œÌ·Â »Ê«”ÿ… „” Œœ„ ¬Œ— »⁄œ √‰ Õ’·  ⁄·Ï «·ﬁÌ„… «·√’·Ì….  „ ≈·€«¡ ⁄„·Ì… «· ⁄œÌ·");
                        }
                    }
                }
                else {
                    MessageBox.Show(" „ ≈·€«¡ «·⁄„·Ì…");
                }
            }
            else {
                MessageBox.Show("«·—Ã«¡  ÕœÌœ  ÕﬁÌﬁ · ⁄œÌ·Â");
            }


        }

        private async void deletebtn_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                var confirmation = MessageBox.Show("Â· √‰  „ √ﬂœ √‰ﬂ  —Ìœ Õ–› Â–« «· ÕﬁÌﬁø", " √ﬂÌœ", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes) {
                    int serial = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Serial"].Value);
                    var investToDelete = await _context.Invests.FirstOrDefaultAsync(i => i.Serial == serial);
                    if (investToDelete != null) {
                        _context.Invests.Remove(investToDelete);
                        await _context.SaveChangesAsync();
                        await LoadInvestigationsAsync();
                        MessageBox.Show(" „ Õ–› «· ÕﬁÌﬁ »‰Ã«Õ");
                    }
                    else {
                        MessageBox.Show("·„ Ì „ «·⁄ÀÊ— ⁄·Ï «· ÕﬁÌﬁ");
                    }
                }

            }
            else {
                MessageBox.Show("«·—Ã«¡  ÕœÌœ  ÕﬁÌﬁ ·Õ–›Â");
            }
        }

        // TODO
        private async void newbtn_Click(object sender, EventArgs e) {
            await LoadInvestigationsAsync();
        }

        private void cancelbtn_Click(object sender, EventArgs e) {
            ResetForm();
        }


        private void ResetForm() {
            crimeTypeComboBox.SelectedIndex = -1;
            crimeTypeComboBox.Text = "[«·Ã—„]";
            insertDatePicker.Value = DateTime.Now;
            transactionDatePicker.Value = DateTime.Now;
            remarksTextBox.Text = "";
        }

        private void crimeTypeComboBox_Leave(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(crimeTypeComboBox.Text)) {
                crimeTypeComboBox.Text = "[«·Ã—„]";
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                ResetForm();

                crimeTypeComboBox.Text = dataGridView1.CurrentRow.Cells["Crime"].Value.ToString();
                insertDatePicker.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Dfile"].Value.ToString());
                transactionDatePicker.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Dmahdar"].Value.ToString());
                remarksTextBox.Text = dataGridView1.CurrentRow.Cells["Rem"].Value.ToString();

                if (crimeTypeComboBox.Text == "") {
                    crimeTypeComboBox.Text = "[«·Ã—„]";
                }
            }
        }

        private void InvPers_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                int serial = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Serial"].Value);
                var invPersForm = new FormPerson(serial);
                invPersForm.Show();
            }
            else {
                MessageBox.Show("«·—Ã«¡  ÕœÌœ  ÕﬁÌﬁ ·⁄—÷ «·√‘Œ«’ «·„— »ÿÌ‰ »Â");
            }
        }

        //private void word_Click(object sender, EventArgs e) {
        //    if (dataGridView1.SelectedRows.Count > 0) {
        //        int serial = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Serial"].Value);
        //        if (invest != null) {
        //            var word = new FormWord(serial);
        //            word.CreateDocument();
        //        }
        //    }
        //    else {
        //        MessageBox.Show("«·—Ã«¡  ÕœÌœ  ÕﬁÌﬁ ·⁄—÷ «·Õ«·«  «·„— »ÿÌ‰ »Â");
        //    }
        //}

        //private void vehl_Click(object sender, EventArgs e) {
        //    if (dataGridView1.SelectedRows.Count > 0) {
        //        int serial = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Serial"].Value);
        //        var vehlForm = new FormVehicle(serial);
        //        vehlForm.Show();
        //    }
        //    else {
        //        MessageBox.Show("«·—Ã«¡  ÕœÌœ  ÕﬁÌﬁ ·⁄—÷ «·„—ﬂ»«  «·„— »ÿ… »Â");
        //    }
        //}
    }
}

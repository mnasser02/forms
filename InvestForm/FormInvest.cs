using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvestForm.Repositories;
using InvestForm.Repositories.Models;
using Microsoft.EntityFrameworkCore;

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
            var crimeTypes = new List<string>
            {
            "Fraud",
            "Assault",
            "Burglary",
            "Vandalism",
            "Robbery",
            "Forgery",
            "Kidnapping",
            "Embezzlement"
            };

            crimeTypeComboBox.DataSource = crimeTypes;
            crimeTypeComboBox.SelectedIndex = -1;
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
                    Crime = crimeTypeComboBox.Text,
                    Dfile = DateOnly.FromDateTime(insertDatePicker.Value),
                    Dmahdar = DateOnly.FromDateTime(transactionDatePicker.Value),
                    //Summary = summaryTextBox.Text,
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
                        invest.Crime = crimeTypeComboBox.Text;
                        invest.Dfile = DateOnly.FromDateTime(insertDatePicker.Value);
                        invest.Dmahdar = DateOnly.FromDateTime(transactionDatePicker.Value);
                        //invest.Summary = summaryTextBox.Text;
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
            crimeTypeComboBox.SelectedIndex = -1; // This will make the ComboBox empty
            insertDatePicker.Value = DateTime.Now;
            transactionDatePicker.Value = DateTime.Now;
            //summaryTextBox.Text = "";
            remarksTextBox.Text = "";
        }

        
    }
}

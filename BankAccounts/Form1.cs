using Newtonsoft.Json;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace BankAccounts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataAcc.DataSource = bankAccounts;
        }

        private BindingList<BankAccount> bankAccounts = new BindingList<BankAccount>
        {
            new BankAccount("Pawe³ Ogórek"),
            new BankAccount("Marta Nowak")

        };

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            string name = NameTxt.Text;
            decimal amount = AmountTxt.Value;

            var person = bankAccounts.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (person != null)
            {
                person.Balance += amount;

                MessageBox.Show($"Amount {amount} has been added to {person.Name}. New balance: {person.Balance}");
            }
            else
            {
                MessageBox.Show($"Person with the name {name} was not found.");
            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            string name = NameTxt.Text;
            decimal amount = AmountTxt.Value;

            var person = bankAccounts.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (person != null)
            {
                person.Balance -= amount;

                MessageBox.Show($"Amount {amount} has been withdrawn from {person.Name}. New balance: {person.Balance}");
            }
            else
            {
                MessageBox.Show($"Person with the name {name} was not found.");
            }

        }

        private void SortNameBtn_Click(object sender, EventArgs e)
        {
            var sortedList = bankAccounts.OrderBy(p => p.Name).ToList();
            DataAcc.DataSource = new BindingList<BankAccount>(sortedList);
            MessageBox.Show("List has been sorted.");
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            string name = NameTxt.Text;
            bankAccounts.Add(new BankAccount(name));
            MessageBox.Show($"Account for {name} has been made.");
        }

        private void SortBalanceBtn_Click(object sender, EventArgs e)
        {
            var sortedList = bankAccounts.OrderBy(p => p.Balance).ToList();
            DataAcc.DataSource = new BindingList<BankAccount>(sortedList);
            MessageBox.Show("List has been sorted.");
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string name = NameTxt.Text;
            var searchResult = bankAccounts.Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
            DataAcc.DataSource = new BindingList<BankAccount>(searchResult);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            DataAcc.DataSource = bankAccounts;
        }

        private void ChangeNameBtn_Click(object sender, EventArgs e)
        {
            string oldName = OldNameTxt.Text;
            string newName = NewNameBtn.Text;
            var person = bankAccounts.FirstOrDefault(p => p.Name.Equals(oldName));
            if (person != null)
            {
                person.Name = newName;
                MessageBox.Show($"Name has been updated to {newName}.");
            }
            else
            {
                MessageBox.Show($"No account found with the name {oldName}.");
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            LoadFromFile();
        }

        private string filePath = "bankAccounts.json";
        private void CreateFileIfNotExists()
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[]");
            }
        }
        private void SaveToFile()
        {
            CreateFileIfNotExists();

            string json = JsonConvert.SerializeObject(bankAccounts, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
        private void LoadFromFile()
        {
            CreateFileIfNotExists();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var deserialized = JsonConvert.DeserializeObject<BindingList<BankAccount>>(json);
                if (deserialized != null)
                {
                    bankAccounts = deserialized;
                    DataAcc.DataSource = bankAccounts;
                }
                else
                {   
                    bankAccounts = new BindingList<BankAccount>();
                    DataAcc.DataSource = bankAccounts;
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToFile();
        }


    }
}

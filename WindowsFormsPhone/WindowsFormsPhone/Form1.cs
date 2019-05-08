using StatePattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPhone
{
    public partial class Form1 : Form
    {
        List<Phone> phones;
        public Form1()
        {
            InitializeComponent();
            phones = new List<Phone>();
            phones.Add(new Phone("375293261212", 1, 0.25));
        }
        private void GenerPhoneList()
        {
            listBoxPhones.Items.Clear();
            foreach(Phone phone in phones)
            {
                listBoxPhones.Items.Add(string.Format("{0} - {1} - {2}",
                    phone.Number, phone.Account, phone.State.Note));
            }
        }      
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Manage of objects states " + "(Artsiom Shabolda, PIr - 161)";
            GenerPhoneList();
            txtBoxNumber.Text = phones[0].Number;
            txtBoxAccount.Text = phones[0].Account.ToString();
            txtBoxCallProbability.Text = phones[0].CallProbability.ToString();
        }

        private void BtnAddPhone_Click(object sender, EventArgs e)
        {
            double probability = 0;
            double account = 0;
            try
            {
                probability = Convert.ToDouble(txtBoxCallProbability.Text);
                account = Convert.ToDouble(txtBoxAccount.Text);                
            }
            catch(FormatException exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            phones.Add(new Phone(txtBoxNumber.Text, account, probability));
            GenerPhoneList();
        }

        private void ListBoxPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxPhones.SelectedIndex;
            if(index < 0)
            {
                return;
            }
            txtBoxNumber.Text = phones[index].Number;
            txtBoxAccount.Text = phones[index].Account.ToString();
            txtBoxCallProbability.Text = phones[index].CallProbability.ToString();
        }

        private void BtnTopUpAccount_Click(object sender, EventArgs e)
        {
            int index = listBoxPhones.SelectedIndex;
            if(index < 0)
            {
                return;
            }
            try
            {
                phones[index].TopUpAccount(1);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            GenerPhoneList();
        }

        private void BtnPickUp_Click(object sender, EventArgs e)
        {
            int index = listBoxPhones.SelectedIndex;
            if(index < 0)
            {
                return;
            }
            try
            {
                phones[index].PickUp();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            GenerPhoneList();
        }

        private void BtnCall_Click(object sender, EventArgs e)
        {
            int index = listBoxPhones.SelectedIndex;
            if(index < 0)
            {
                return;
            }
            try
            {
                phones[index].Call();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            GenerPhoneList();
        }

        private void BtnEndCall_Click(object sender, EventArgs e)
        {
            int index = listBoxPhones.SelectedIndex;
            if (index < 0)
            {
                return;
            }
            try
            {
                phones[index].EndCall();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            GenerPhoneList();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxPhones.SelectedIndex;
            if(index < 0)
            {
                return;
            }
            phones.RemoveAt(index);
            GenerPhoneList();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int index = listBoxPhones.SelectedIndex;
            if (index < 0)
            {
                return;
            }
            double probability = 0;
            double account = 0;
            try
            {
                probability = Convert.ToDouble(txtBoxCallProbability.Text);
                account = Convert.ToDouble(txtBoxAccount.Text);
            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            phones[index].Number = txtBoxNumber.Text;
            phones[index].Account = account;
            phones[index].CallProbability = probability;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncapsulationUsingwinforms
{
    public partial class AccountForms : Form
    {
        //<Access mofifier className>
        public AccountForms()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //How to create object 
        //<className> objVariable=new <className>();
        Account objAccount;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            objAccount = new Account();
            MessageBox.Show("Object has been created");
        }


        private void btnSet_Click(object sender, EventArgs e)
        {
            objAccount.Id = Convert.ToInt32(txtId.Text);
         objAccount.Name = txtName.Text="muni";
        objAccount.Balance =Convert.ToDecimal(txtBalance.Text);
            objAccount = new Account(objAccount.Id,objAccount.Name,objAccount.Balance);
          
            MessageBox.Show("Set the values in Account object");
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (objAccount != null)
            {
                txtId.Text = objAccount.Id.ToString();
                txtName.Text = objAccount.Name;
                txtBalance.Text = objAccount.Balance.ToString();
            }
            else
            {
                MessageBox.Show("Object has been destroy");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Text = "";
            txtBalance.Clear();
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            objAccount = null;

        }

        private void btnGC_Click(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            objAccount.Deposit(Convert.ToInt32(txtAmount.Text));
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            objAccount.Withdraw(Convert.ToInt32(txtAmount.Text));
        }
    }

    
}

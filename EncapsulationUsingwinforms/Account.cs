using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationUsingwinforms
{
    public class Account
    {
        public int Id;
        public string Name;
        public decimal Balance;


        public void Deposit(int amount)
        {
            this.Balance += amount;
            System.Windows.Forms.MessageBox.Show("Deposited");
        }

        public void Withdraw(int amount)
        {
            if(Balance>amount)
            this.Balance -= amount;
            else
                System.Windows.Forms.MessageBox.Show("Insufficient funds");
        }
    }
}

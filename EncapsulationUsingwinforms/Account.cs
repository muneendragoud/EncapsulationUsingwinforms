using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationUsingwinforms
{
    public class Account
    {
        private int _Id;
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if(_Id>=0)
                _Id = value;
                else
                {
                    System.Windows.Forms.MessageBox.Show("Invalid Input");
                }
            }
        }

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

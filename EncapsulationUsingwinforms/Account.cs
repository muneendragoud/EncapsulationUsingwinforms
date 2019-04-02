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

        private string _Name;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if(_Name!="")
                {
                    _Name = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Please einter a Name");
                }
                
            }
        }

        private decimal _Balance;

        public decimal Balance
        {
            get
            {
                return _Balance;
            }
            set
            {
                if (_Balance>0)
                    _Balance = value;
                else
                    System.Windows.Forms.MessageBox.Show("Enter Valid Number");
            }
        }

        public Account()
        {
//default constructor
        }

        public Account(int id,string name,decimal balance)
            :this()
        {
            //parameterized constructor
            _Id = id;
            _Name = name;
            _Balance = balance;
        }

        public static int MinBalance=500;

        public void Deposit(int amount)
        {
            if(MinBalance<amount)
            this.Balance += amount;
            System.Windows.Forms.MessageBox.Show("Deposited");
        }

        public void Withdraw(int amount)
        {
            if(MinBalance<amount)
            this.Balance -= amount;
            else
                System.Windows.Forms.MessageBox.Show("Insufficient funds");
        }
    }
}

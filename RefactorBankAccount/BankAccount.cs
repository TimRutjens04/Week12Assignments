using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorBankAccount
{
    public class BankAccount
    {
        private string clientName { get; set; } //auto-implemented
        private int accountNr { get; } //read only so get
        private double balance //full prop so get/set
        {
            get { return _balance; }
            set
            {
                if (value >= 0)
                {
                    _balance = value;
                }
                else { _balance = 0; }
            }
        }
        private double _balance; //otherwise would get stack overflow
            
        private List<double> transactions { get; set; } 
        /* i think auto-implemented is good because
        it keeps it concise and simple (i dont see a need for added complexity) */

        public BankAccount(string clientName, int accountNr)
        {
            this.clientName = clientName;
            this.accountNr = accountNr;
            transactions = new List<double>();
        }

        public string GetClientName()
        { return this.clientName; }

        public int GetAccountNr()
        { return this.accountNr; }

        public double GetBalance()
        { return this.balance; }
        private void setBalance(double nwBalance)
        {
            if (nwBalance >= 0)
            {
                this.balance = nwBalance;
            }
        }

        public string GetTransactions()
        {
            string label = this.transactions.Count + " transaction(s):" + Environment.NewLine;
            string typeOfTransaction;
            foreach (double t in this.transactions)
            {
                if (t >= 0)
                { typeOfTransaction = " deposited"; }
                else
                { typeOfTransaction = " withdrawn"; }
                label += t + typeOfTransaction + Environment.NewLine;
            }
            return label;
        }

        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                this.setBalance(this.GetBalance() + amount);
                this.transactions.Add(amount);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Withdraw(double amount)
        {
            if (this.GetBalance() - amount > 0)
            {
                this.setBalance(this.GetBalance() - amount);
                this.transactions.Add(-1 * amount);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetInfo()
        {
            return String.Format("{0} (nr. {1}) - {2:0.00}", this.clientName, this.accountNr, this.GetBalance());
        }
    }
}

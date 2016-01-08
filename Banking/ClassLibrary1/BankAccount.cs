using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BankAccount
    {
        // class _fields
        private string _myOwnerLastName;
        private string _myOwnerFirstName;
        private decimal _myBalance;
        // make one static class variable
        private static int _accountCount = 0;

        #region "Constructors"

        /// Default constructor - no parameters
        public BankAccount()
        {
            _myBalance = 0;
            _myOwnerFirstName = "not assigned";
            _myOwnerLastName = "not assigned";
            _accountCount = _accountCount + 1;
        }


        /// parameterized constructor
        public BankAccount(string initialLastName, string initialFirstName, decimal initialBalance)
        {
            _myBalance = initialBalance;
            _myOwnerFirstName = initialFirstName;
            _myOwnerLastName = initialLastName;
            _accountCount = _accountCount + 1;
        }

        #endregion

        #region "Properties“         //public read only property
        public static decimal NumberAccounts
        {
            get
            {
                return _accountCount;
            }
        }

        // public property
        public string OwnerLastName
        {
            get
            {
                return _myOwnerLastName;
            }
            set
            {
                _myOwnerLastName = value;
            }
        }

        // public property
        public string OwnerFirstName
        {
            get
            {
                return _myOwnerFirstName;
            }
            set
            {
                _myOwnerFirstName = value;
            }
        }
        //public read only property
        public string OwnerFullName
        {
            get
            {
                return _myOwnerLastName + ", " + _myOwnerFirstName;
            }
        }

        //public read only property
        public decimal Balance
        {
            get
            {
                return _myBalance;
            }
        }


        #endregion

        #region "Methods"

        // public method
        // <param name="amount">amount to deposit in account</param>
        public void Deposit(decimal amount)
        {
            // code here would check a zillion things before doing the next line
            _myBalance = _myBalance + amount;
        }

        #endregion


    }
}

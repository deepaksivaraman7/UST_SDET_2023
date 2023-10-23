using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class BankDetails
    {
        public BankDetails()
        {
            CustId = 0;
            AccNo = 0;
            Name=string.Empty;
            Status = "Inactive";
        }

        public BankDetails(int custId, long accNo, string? name)
        {
            CustId = custId;
            AccNo = accNo;
            Name = name;
            Status = "Inactive";
        }

        public BankDetails(int custId, long accNo, string? name, string? status)
        {
            CustId = custId;
            AccNo = accNo;
            Name = name;
            Status = status;
        }

        public int CustId {  get; set; }
        public long AccNo { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }
        public virtual void WelcomeMessage() //allowing the method to be overridden using virtual
        {
            Console.WriteLine("Welcome..!");
        }
        public static void ExitMessage()
        {
            Console.WriteLine("Bye..!");
        }
        public void GetAccountDetails(int custid)
        {
            if (CustId == custid)
                Console.WriteLine("Account No: {0}\nName: {1}\nStatus: {2}", AccNo, Name, Status);
            else
                Console.WriteLine("Customer Id doesnot exist");
        }
        public void GetAccountDetails(long accno)
        {
            if (AccNo == accno)
                Console.WriteLine("Customer Id: {0}\nName: {1}\nStatus: {2}", CustId, Name, Status);
            else
                Console.WriteLine("Account Number doesnot exist");
        }
        public void GetAccountDetails(string? name)
        {
            if (Name == name)
                Console.WriteLine("Customer Id: {0}\nAccount No: {1}\nStatus: {2}", CustId, AccNo, Status);
            else
                Console.WriteLine("Name doesnot exist");
        }
    }
}

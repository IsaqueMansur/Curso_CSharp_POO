using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    public class BankCount
    {
        private double balance;
        private string password;
        private string nameClient;

        public BankCount(string pPassword, string pNameClient)
        {
            this.balance = 0;
            this.nameClient = pNameClient;
            this.password = pPassword;
        }
        public BankCount(double pBalance,string pPassword, string pNameClient)
        {
            this.balance = pBalance;
            this.nameClient = pNameClient;
            this.password = pPassword;
        }

        public double Withdraw(double value, string informedPassword)
        {
            if (informedPassword == password)
            {
                if (balance >= value)
                {
                    balance -= value;
                    Console.WriteLine("O valor sacado foi: " + value);
                    Console.WriteLine("O novo saldo é " + balance);
                    return value;
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Senha incorreta");
                return 0;
            }
        }

        public void Deposit(double value)
        {
            balance += value;
            Console.WriteLine("O valor depositado foi: " + value);
        }

        public void ConsultBalance(string informedPassword)
        {
            if (password == informedPassword)
                Console.WriteLine("Saldo atual: " + balance);
            else
                Console.WriteLine("Senha incorreta");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankCount myCount = new BankCount("123456", "Isaque Mansur");
            BankCount myCount2 = new BankCount(1000,"123456", "Isaque 2");

            myCount.Deposit(300);
            myCount2.Deposit(100);
            myCount.Withdraw(10, "123456");
            myCount2.Withdraw(10, "123456");

            Console.ReadKey();
        }
    }
}

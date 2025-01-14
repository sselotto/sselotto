﻿using Tratamento_Excecoes_2.Entities.Exceptions;

namespace Tratamento_Excecoes_2.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double Amount)
        {
            Balance += Amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new DomainExceptions("The amount exceeds withdraw Limit");
            }
            if(amount > Balance)
            {
                throw new DomainExceptions("Not enough balance");
            }

            Balance -= amount;
        }
           
    }
}

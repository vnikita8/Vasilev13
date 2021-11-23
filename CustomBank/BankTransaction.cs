using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBank
{
    public class BankTransaction
    {
        public readonly double TransferMoney;
        public readonly DateTime DateTimeInfo;

        public BankTransaction(double transferSumm)
        {
            TransferMoney = transferSumm;
        }
    }
}

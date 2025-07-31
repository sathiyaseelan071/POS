using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableBox
{
    public static class Account
    {
        // Transaction Types
        public const string TransTypeDebitedFromAccount = "D";  // Money taken (e.g., purchase)
        public const string TransTypeCreditedToAccount = "C";   // Money received (e.g., payment)

        // Payment Method Codes
        public const string PaymentTypeOnCredit = "T";  // Payment pending / to be paid
        public const string PaymentTypeCard = "R";  // Credit/Debit card
        public const string PaymentTypeGPay = "Y";  // Google Pay
        public const string PaymentTypeUpi = "I";  // UPI
        public const string PaymentTypeCash = "H";  // Cash
    }
}

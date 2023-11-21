using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WemaBITCsharp.Models
{
    public class Payment
    {
        private int id;
        private List<Payment> paymentRecord = new List<Payment>();
        public int Id { get { return id; } set { id = new GenerateId().Generate(); } }
        public int UserId { get; set; }
        public decimal Amount { get; set; }

        public List<Payment> PaymentRecord
        {
            get { return this.paymentRecord; }
        }

        //add payment record
        public void AddPayment()
        {
            this.PaymentRecord.Add(new Payment() { Id = Id, UserId = UserId, Amount = Amount });
        }

        //show payment records
        public List<Payment> GetPaymentRecord()
        {
            return this.PaymentRecord;
        }
    }


}

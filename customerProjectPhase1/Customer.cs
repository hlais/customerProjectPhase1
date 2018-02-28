using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleLayer
{
    public class CustomerBase
    {
        public string CusterName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }

        public virtual void Validate()
        {
            throw new Exception("Not Impleted");
        }

    }
    public class Customer: CustomerBase
    {

        public override void Validate()
        {
            if (CusterName.Length == 0)
            {
                throw new Exception("Customer Name is required");
            }

            if (PhoneNumber.Length == 0)
            {
                throw new Exception("Customer Phone Number is required");
            }

            if (BillAmount == 0)
            {
                throw new Exception("Bill Amount is required");
            }
            if (Address.Length == 0)
            {
                throw new Exception("Address is required");
            }
        }
    }
    public class Lead: CustomerBase
    {

        public override void Validate()
        {
            base.Validate();
        }

    }
}

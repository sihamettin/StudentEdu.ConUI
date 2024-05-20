using System;

namespace StudentEdu.Data

{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int StudentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime CreaDate { get; set; }
        public bool IsActive { get; set; }
    }

}

using System;

namespace SRMDataManagerLibrary.Models
{
    public class SaleReportModel
    {
        public DateTime SaleDate { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Tax { get; set; }

        public decimal Total { get; set; }

        public string FirstNane { get; set; }

        public string LastNane { get; set; }

        public string EmailAddress { get; set; }
    }
}

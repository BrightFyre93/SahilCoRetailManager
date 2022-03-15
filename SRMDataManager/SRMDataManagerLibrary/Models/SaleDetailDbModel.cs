namespace SRMDataManagerLibrary.Models
{
    public class SaleDetailDbModel
    {
        public int SaleID { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal Tax { get; set; }
    }
}

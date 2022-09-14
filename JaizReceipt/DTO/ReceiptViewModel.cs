namespace JaizReceipt.DTO
{
    public class ReceiptViewModel
    {
        public Guid Id { get; set; }
        public string MerchantName { get; set; }
        public string Location { get; set; }
        public int TerminalId { get; set; }
        public int Stan { get; set; }
        public DateTime Date_time { get; set; }
        public decimal Amount { get; set; }
        public String CardNo { get; set; }
        public string companyName { get; set; }
        public string expiryDate { get; set; }
        public string AuthorizationCode { get; set; }  
        public int ResponseCode { get; set; }
        public string AID { get; set; }
        public long RRN { get; set; }
        public string PTAD { get; set; }


    }
}

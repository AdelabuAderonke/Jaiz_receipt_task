using JaizReceipt.DTO;
using Microsoft.EntityFrameworkCore;

namespace JaizReceipt.Data
{
    public class ReceiptDBContext:DbContext
    {
        public ReceiptDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ReceiptViewModel> ReceiptViewModels { get; set; }
    }
}
    

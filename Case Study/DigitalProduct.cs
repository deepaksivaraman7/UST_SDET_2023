using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class DigitalProduct : Product
    {
        public DigitalProduct(int productId, string? name, double price, int stockQuantity,string? downloadLink,string? fileFormat) : base(productId, name, price, stockQuantity)
        {
            DownloadLink = downloadLink;
            FileFormat = fileFormat;
        }
        public string? DownloadLink { get; set; }
        public string? FileFormat { get; set; }
    }
}

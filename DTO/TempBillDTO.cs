using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TempBillDTO
    {
        public string ItemName { get; set; }
        public int AmountItem { get; set; }
        public int Price    { get; set; }
        public int TotalPrice { get; set; }
        public TempBillDTO (string ItemName, int AmountItem, int Price, int TotalPrice)
        {
            this.ItemName = ItemName;
            this.AmountItem = AmountItem;
            this.Price = Price;
            this.TotalPrice = TotalPrice;
        }
        public TempBillDTO(DataRow row)
        {
            this.ItemName = row["Name"].ToString();
            this.AmountItem = (int)row["Amount"];
            this.Price = (int)Convert.ToDouble(row["Price"].ToString());
            this.TotalPrice = (int)Convert.ToDouble(row["TotalPrice"].ToString());
        }
    }
}

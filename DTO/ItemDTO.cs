using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ItemDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int IDCategory { get; set; }
        public float Price { get; set; }
        public ItemDTO() { }

        public ItemDTO(int id, string name, int idcategory, float price)
        {
            this.ID = id;
            this.Name = name;
            this.IDCategory = idcategory;
            this.Price = price;
        }
        public ItemDTO(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.IDCategory = (int)row["IDCategory"];
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CategoryDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public CategoryDTO()
        {

        }
        public CategoryDTO(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public CategoryDTO(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
        }
    }
}

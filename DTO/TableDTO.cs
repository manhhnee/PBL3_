using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TableDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public TableDTO() { }
        public TableDTO(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }
        public TableDTO(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.Status = row["Status"].ToString();
        }
    }
}

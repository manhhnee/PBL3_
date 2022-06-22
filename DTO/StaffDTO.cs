using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StaffDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public StaffDTO() { }
        public StaffDTO(int ID, string Name, string Address, int Age, string PhoneNumber)
        {
            this.ID = ID;
            this.Name = Name;
            this.Address = Address;
            this.Age = Age;
            this.PhoneNumber = PhoneNumber;
        }
        public StaffDTO(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.Address = row["Address"].ToString();
            this.Age = (int)row["Age"];
            this.PhoneNumber = row["PhoneNumber"].ToString();
        }
    }
    


}

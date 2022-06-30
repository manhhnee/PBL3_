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
        public int WorkingDays { get; set; }
        public double SalaryCoefficient { get; set; }

        public StaffDTO() { }
        public StaffDTO(int ID, string Name, string Address, int Age, string PhoneNumber, int WorkingDays, double SalaryCoefficient)
        {
            this.ID = ID;
            this.Name = Name;
            this.Address = Address;
            this.Age = Age;
            this.PhoneNumber = PhoneNumber;
            this.WorkingDays = WorkingDays;
            this.SalaryCoefficient = SalaryCoefficient;
        }
        public StaffDTO(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.Address = row["Address"].ToString();
            this.Age = (int)row["Age"];
            this.PhoneNumber = row["PhoneNumber"].ToString();
            this.WorkingDays = (int)row["WorkingDays"];
            this.SalaryCoefficient = Convert.ToDouble(row["SalaryCoefficient"]);
        }
    }
    


}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public int TypeID { get; set; }
        public int IDStaff { get; set; }
        public AccountDTO()
        { 
        }
        public AccountDTO(int typeID)
        {
            this.TypeID = typeID; 
        }
        public AccountDTO(string username, string password)
        {
            this.UserName = username;
            this.Password = password;
        }
        
        public AccountDTO(string username, string password, string displayname, int typeid,int IDStaff)
        {
            this.UserName = username;
            this.Password = password;
            this.DisplayName = displayname;
            this.TypeID = typeid;
            this.IDStaff = IDStaff;
        }

        public AccountDTO(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.Password = row["Password"].ToString();
            this.DisplayName = row["DisplayName"].ToString();
            this.TypeID = (int)row["TypeID"];
            this.IDStaff = (int)row["IDStaff"];
        }
    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;
        public static StaffDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new StaffDAO();
                return instance;
            }
        }
        public DataTable GetAllStaff()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("Select * from Staff");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddStaffDAO(StaffDTO staff)
        {
            string query = "insert into Staff values( @Name , @Address , @Age , @PhoneNumber )";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new Object[] { staff.Name, staff.Address, staff.Age, staff.PhoneNumber });
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void updateStaffDAO(StaffDTO staff)
        {
            string query = "update Staff set Name = @Name , Address = @Address , Age = @age ,PhoneNumber = @PhoneNumber where ID = @ID";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new Object[] { staff.Name,staff.Address,staff.Age,staff.PhoneNumber,staff.ID });
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void DeleteStaffDAO(int ID)
        {
            string query = "delete from Staff where ID =" + ID;
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new Object[] { ID });
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
   


}

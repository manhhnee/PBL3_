using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BillInforDAO
    {
        private static BillInforDAO instance;
        public static BillInforDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInforDAO();
                return instance;
            }
        }
        public DataTable GetAllBillInfor()
        {
            return DataProvider.Instance.ExecuteQuery("Select * from BillInfor");
        }
        public DataTable GetListBillInfor(int ID)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("Select * from dbo.BillInfor WHERE IDBill = " + ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void InsertBillInfor(int idbill, int iditem, int amount)
        {
            try
            {
                DataProvider.Instance.ExecuteQuery("USP_InsertBillInfor @IDBill , @IDItem , @Amount ", new Object[] { idbill, iditem, amount });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SetBillInforDefault(BillInforDTO bill)
        {
            string query = "Delete BillInfor where IDItem = @IDItem";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new Object[] { bill.IDItem });
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}

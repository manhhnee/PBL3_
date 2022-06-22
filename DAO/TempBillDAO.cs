using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TempBillDAO
    {
        private static TempBillDAO instance;

        public static TempBillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TempBillDAO();
                return TempBillDAO.instance;
            }
        }

        private TempBillDAO() { }
        public DataTable GetListTempBillByTableID(int id)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SELECT i.Name, bi.Amount, i.Price, i.Price * bi.Amount AS TotalPrice FROM dbo.BillInfor bi, dbo.Bill b, dbo.Item i WHERE b.ID = bi.IDBill AND bi.IDItem = i.ID AND b.IDTable = " + id + " and Status = 0");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetListTempBillByID(int id)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("SELECT i.Name, bi.Amount, i.Price, i.Price * bi.Amount AS TotalPrice FROM dbo.BillInfor bi, dbo.Bill b, dbo.Item i WHERE b.ID = bi.IDBill AND bi.IDItem = i.ID AND b.ID = " + id + " AND b.Status = 1");
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}

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
                return DataProvider.Instance.ExecuteQuery("USP_GetListTempBillByTableID @IDTable", new Object[] {id});
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
                return DataProvider.Instance.ExecuteQuery("USP_GetListTempBillByID @ID", new Object[] {id});
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}

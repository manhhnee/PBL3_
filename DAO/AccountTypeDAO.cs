using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AccountTypeDAO
    {
        private static AccountTypeDAO _instance;
        public static AccountTypeDAO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AccountTypeDAO();
                return _instance;
            }
        }
        public DataTable GetAllAccountType()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("select * from AccountType");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

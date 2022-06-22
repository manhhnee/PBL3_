using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class AccountTypeBUS
    {
        private static AccountTypeBUS _instance;
        public static AccountTypeBUS Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AccountTypeBUS();
                return _instance;
            }
        }
        public DataTable GetAllAccountType()
        {
            try
            {
                return AccountTypeDAO.Instance.GetAllAccountType();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

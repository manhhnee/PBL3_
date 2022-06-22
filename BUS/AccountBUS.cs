using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class AccountBUS
    {
        private static AccountBUS _instance;
        public static AccountBUS Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AccountBUS();
                return _instance;
            }
        }
        private AccountBUS() { }
        
        public Object CheckLogin(AccountDTO account)
        {
            try
            {
                return AccountDAO.Instance.CheckLogin(account);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllAccount()
        {
            try
            {
                return AccountDAO.Instance.GetAllAccount();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public AccountDTO GetAccountByUserName(string UserName)
        {
            DataTable data;
            try
            {
                data = AccountDAO.Instance.GetAccountByUserName(UserName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new AccountDTO(data.Rows[0]);
        }
        public void AddAccountBUS(AccountDTO account)
        {
            AccountDAO.Instance.AddAccountDAO(account);
        }
        public void DeleteAcount(int AccountToDelete)
        {
            try
            {
                AccountDAO.Instance.DeleteAccountDAO(AccountToDelete);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool CheckUserName(string username)
        {
            int i = 0;
            bool t = true;
            DataTable data = GetAllAccount();
            foreach(DataRow row in data.Rows)
            {
                if(data.Rows[i]["UserName"].ToString() == username)
                {
                    t = false;
                    break;
                }
                i++;
            }
            return t;
        }
        public void ChangePassAcc(AccountDTO acc)
        {
            try
            {
                AccountDAO.Instance.ChangePassAcc(acc);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public string GetUserNameByIDStaff(int id)
        {
            return AccountDAO.Instance.GetUserNameByIDStaff(id);
        }
    }
}

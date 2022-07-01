using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableDAO();
                return instance;
            }
        }
        private TableDAO() { }
         
           
        public string GetNameTablebyID(int id)
        {
            string a = "";
            foreach (DataRow i in GetListTable().Rows)
            {
                if (Convert.ToInt32(i["ID"].ToString()) == id)
                {
                    a = i["Name"].ToString();
                    break;
                }
            }
            return a;
        }
        public DataTable GetListTable()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_GetListTable");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddTable(TableDTO table)
        {
            string query = "USP_InserTable @Name";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new Object[] { table.Name });
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateTable(int id, string name)
        {
            string query = "USP_UpdateTable @Name , @ID";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new Object[] {name, id});
            }   
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteTable(int id)
        {
            string query = "USP_DeleteTable @ID";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new Object[] { id });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SwapTable(int id1, int id2)
        {
            try
            {
                DataProvider.Instance.ExecuteQuery("USP_SwapTable @IDTable1 , @TableID2 ", new Object[] { id1, id2 });
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        
    }
}

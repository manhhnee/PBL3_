using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryDAO();
                return instance;
            }
        }
        public DataTable GetListCategory()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("Select * from dbo.ItemCategory");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }
        public  int GetIDbyNameCategory(string name)
        {
            foreach(DataRow i in GetListCategory().Rows)
            {
                if (i["Name"].ToString() == name)
                {
                   int a  = Convert.ToInt32(i["ID"].ToString());
                   return a;
                }
                
            }
            return -1;
        }
        public string GetNamebyIDCategory(int id)
        {
            string a = "";
            foreach (DataRow i in GetListCategory().Rows)
            {
                if (Convert.ToInt32(i["ID"].ToString()) == id)
                {
                    a = i["Name"].ToString();
                    break;
                }

            }
            return a;

        }
        public void AddCategory(CategoryDTO ct)
        {
            string query = "insert into ItemCategory values( @Name )";
            DataProvider.Instance.ExecuteNonQuery(query, new Object[] {ct.Name});
            
        }
    }
}

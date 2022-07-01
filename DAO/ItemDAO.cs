using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ItemDAO
    {
        private static ItemDAO instance;
        public static ItemDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ItemDAO();
                return instance;
            }
        }
        public DataTable GetItemByIDCategory(int id)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("select * from Item where IDCategory = " + id);
            }    
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public DataTable GetAllItem()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("Select * from Item Order by IDCategory ASC");
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        
        
        public void AddItemDAO(ItemDTO item)
        {
            string query = "USP_InsertItem @Name , @IDCategory , @Price ";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new Object[] { item.Name, item.IDCategory, item.Price });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public void updateItemDAO(ItemDTO item)
        {
            string query = "USP_UpdateItem @Name , @IDCategory , @Price , @ID";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new Object[] { item.Name, item.IDCategory, item.Price, item.ID});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public void DeleteItemDAO(int ID)
        {
            string query = "USP_DeleteItem @ID";
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

using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return instance;
            }
        }
        private BillDAO() {}
        public int GetUnCheckIDBillByIDTable(int ID)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("GetUnCheckBillIDByTableID @IDTable", new Object[] {ID});

            if (data.Rows.Count > 0)
            {
                BillDTO bill = new BillDTO(data.Rows[0]);
                return bill.ID;
            }

            return -1;
        }
        public DataTable GetListBill()
        {
            return DataProvider.Instance.ExecuteQuery("Select * from Bill");
        }
        public void InsertBill(int id)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery("USP_InsertBill @IDTable", new Object[] {id});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_GetListBillByDate @checkIn , @checkOut", new Object[] { checkIn, checkOut });
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select MAX(ID) from dbo.Bill");
            }
            catch 
            {
                return 1;
            }
        }
        public void CheckOut(int id, int discount, double TotalPrice)
        {
            string query = "USP_CheckOut @Discount , @TotalPrice , @ID";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query , new Object[] {discount, TotalPrice, id});
            }   
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<BillDTO> getAllBill()
        {
            List<BillDTO> list = new List<BillDTO>();
            DataTable a = GetListBill();
            foreach (DataRow dr in a.Rows)
            {
                BillDTO bill = new BillDTO(dr);
                list.Add(bill);
            }
            return list;
        }

        public int GetIDTableByID(int id)
        {

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Bill where ID = " + id, new Object[] { id });

            if (data.Rows.Count > 0)
            {
                BillDTO bill = new BillDTO(data.Rows[0]);
                return bill.IDTable;
            }

            return -1;
        }
    }
}

using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BillInforBUS
    {
        private static BillInforBUS instance;
        public static BillInforBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInforBUS();
                return instance;
            }
        }
        public DataTable GetAllBillInfor()
        {
            return BillInforDAO.Instance.GetAllBillInfor();
        }
        public DataTable GetListBillInfor(int id)
        {
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = BillInforDAO.Instance.GetListBillInfor(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dataTable;
        }
        public void InsertBillInfor(int idbill, int iditem, int amount)
        {
            try
            {
                BillInforDAO.Instance.InsertBillInfor(idbill, iditem, amount);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SetBillInforDefault(int id)
        {
            DataTable list = GetAllBillInfor();
            List<BillInforDTO> billInforDTOs = new List<BillInforDTO>();
            foreach(DataRow dr in list.Rows)
            {
                BillInforDTO dto = new BillInforDTO(dr);
                if(dto.IDItem == id)
                {
                    BillInforDAO.Instance.SetBillInforDefault(dto);
                }    
            }    
        }
    }
}

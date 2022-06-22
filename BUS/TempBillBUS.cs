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
    public class TempBillBUS
    {
        private static TempBillBUS instance;
        public static TempBillBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TempBillBUS();
                return instance;
            }
        }
        public List<TempBillDTO> GetListTempBillByTableID(int id)
        {
            DataTable data = new DataTable();
            try
            {
                data = TempBillDAO.Instance.GetListTempBillByTableID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            List<TempBillDTO> list = new List<TempBillDTO>();
            foreach(DataRow dr in data.Rows)
            {
                TempBillDTO tempBillDTO = new TempBillDTO(dr);
                list.Add(tempBillDTO);
            }    
            return list;
        }
        public List<TempBillDTO> GetListTempBillByID(int id)
        {
            DataTable data = new DataTable();
            try
            {
                data = TempBillDAO.Instance.GetListTempBillByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            List<TempBillDTO> list = new List<TempBillDTO>();
            foreach (DataRow dr in data.Rows)
            {
                TempBillDTO tempBillDTO = new TempBillDTO(dr);
                list.Add(tempBillDTO);
            }
            return list;
        }
    }
}

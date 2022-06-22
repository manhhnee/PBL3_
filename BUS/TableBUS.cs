﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class TableBUS
    {
        public static int TableWidth = 97;
        public static int TableHeight = 97;
        private static TableBUS instance;
        public static TableBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableBUS();
                return instance;
            }
        }
        private TableBUS() { }

        public List<TableDTO> GetListTable()
        {
            DataTable table;
            try
            {
                table = TableDAO.Instance.GetListTable();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            List<TableDTO> listTable = new List<TableDTO>();
            foreach(DataRow row in table.Rows)
            {
                TableDTO tb = new TableDTO(row);
                listTable.Add(tb);
            }
            return listTable;
        }
        public void SwapTable(int id1, int id2)
        {
            try
            {
                TableDAO.Instance.SwapTable(id1, id2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GetNameTablebyID(int id)
        {
            return TableDAO.Instance.GetNameTablebyID(id);
        }    
    }
}

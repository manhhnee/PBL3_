﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS
{
    public class ItemBUS
    {
        private static ItemBUS instance;
        public static ItemBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ItemBUS();
                return instance;
            }
        }
        
        public DataTable GetAll()
        {
            return ItemDAO.Instance.GetAllItem();
        }
        public List<ItemDTO> GetAllItem()
        {
            DataTable data;
            try
            {
                data = ItemDAO.Instance.GetAllItem();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            List<ItemDTO> list = new List<ItemDTO>();
            foreach (DataRow dr in data.Rows)
            {
                ItemDTO item = new ItemDTO(dr);
                list.Add(item);
            }
            return list;
        }
        public List<ItemDTO> GetItemByIDCategory(int id)
        {
            DataTable data;
            try
            {
                data = ItemDAO.Instance.GetItemByIDCategory(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            List<ItemDTO> list = new List<ItemDTO>();
            foreach (DataRow dr in data.Rows)
            {
                ItemDTO item = new ItemDTO(dr);
                list.Add(item);
                
            }    
            return list;

        }
        public List<ItemDTO> GetItemByName(string name)
        {
            List<ItemDTO> li = new List<ItemDTO>();
            foreach(ItemDTO i in GetAllItem())

            {
                if(i.Name.Contains(name))
                {
                    li.Add(i);
                }
            }
            return li;
        }
        

        public bool CheckNameItem(string name)
        {
            int i = 0;
            bool t = true;
            DataTable data = GetAll();
            foreach (DataRow dr in data.Rows)
            {
                if(data.Rows[i]["Name"].ToString() == name )
                {
                    t = false;
                    break;
                }
                i++;
            }
            return t;

        }
        public void AddItem(ItemDTO item)
        {
            try
            {
                ItemDAO.Instance.AddItemDAO(item);
            }
            catch(Exception ex)
            {
                throw ex;
            }
               
           
        }
        public void UpdateItem(ItemDTO item)
        {
            try
            {
                ItemDAO.Instance.updateItemDAO(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteItem(int ItemtoDelete)
        {
            try
            {
                ItemDAO.Instance.DeleteItemDAO(ItemtoDelete);
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}

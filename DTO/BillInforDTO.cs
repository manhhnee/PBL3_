using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillInforDTO
    {
        public int ID { get; set; }
        public int IDBill { get; set; }
        public int IDItem { get; set; }
        public int Amount { get; set; }
        public BillInforDTO(int ID, int IDBill, int IDItem, int Amount)
        {
            this.ID = ID;
            this.IDBill = IDBill;
            this.IDItem = IDItem;
            this.Amount = Amount;
        }
        public BillInforDTO(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.IDBill = (int)row["IDBill"];
            this.IDItem = (int)row["IDItem"];
            this.Amount = (int)row["Amount"];
        }
    }
}

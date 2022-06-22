using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountTypeDTO
    {
        public int ID { get; set; }
        public string TypeName { get; set; }
        public AccountTypeDTO(int id, string typename)
        {
            this.ID = id;
            this.TypeName = typename;
        }
    }
}

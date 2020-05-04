using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public interface CTHDBanHangBUS
    {
        DataTable GetData();
    
        bool DelData();
     
    }
}

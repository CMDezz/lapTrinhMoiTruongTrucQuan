using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

using DTO;

namespace BUS
{
   public class CTHDBanHangBUSImpl : CTHDBanHangBUS
    {
        private CTHDBanHangDAL CTHDBanHangDAL = null;
        private static CTHDBanHangBUSImpl instance;

        public CTHDBanHangBUSImpl()
        {
            this.CTHDBanHangDAL = CTHDBanHangDALImpl.Instance;
        }

        public static CTHDBanHangBUSImpl Instance
        {
            get { if (instance == null) instance = new CTHDBanHangBUSImpl(); return CTHDBanHangBUSImpl.instance; }
            private set { CTHDBanHangBUSImpl.instance = value; }
        }

        public DataTable GetData()
        {
            return CTHDBanHangDAL.GetData();
        }
    

        public bool DelData()
        {
            return CTHDBanHangDAL.DelData();
        }

    }
}

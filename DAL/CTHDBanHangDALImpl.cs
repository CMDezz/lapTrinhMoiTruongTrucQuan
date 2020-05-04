using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public  class CTHDBanHangDALImpl : CTHDBanHangDAL
    {

        //private CTHDBanHangDALImpl() { }

        private static CTHDBanHangDALImpl instance;

        public static CTHDBanHangDALImpl Instance
        {
            get { if (instance == null) instance = new CTHDBanHangDALImpl(); return CTHDBanHangDALImpl.instance; }
            private set { CTHDBanHangDALImpl.instance = value; }
        }

        public DataTable GetData()
        {
            string query = "select MaHDB,SanPham,SL,DonGia,CK from CTHDBanHang where TinhTrang = 'True'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

  
        public bool DelData()
        {
            string query = string.Format("UPDATE CTHDBanHang SET TinhTrang= 'False'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}

using MVCDemoDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoDataLibrary.BussinessLogic
{
    public static class KhachHangProcessor
    {
        public static int CreateKhachHang(string s1, string s2)
        {
            Models.KhachHangModel data = new KhachHangModel() { MaKhachHang = s1, HoVaTen = s2};
            string sql = @"insert into dbo.KhachHang (MaKhachHang, HoVaTen) values (@MaKhachHang, @HoVaTen)";

            return DataAccess.DataAccess.SaveData(sql, data);


        }

        public static List<KhachHangModel> LoadKhachHang()
        {
            string sql = @"select * from dbo.KhachHang";
            return DataAccess.DataAccess.LoadData<KhachHangModel>(sql);
        }
    }
}

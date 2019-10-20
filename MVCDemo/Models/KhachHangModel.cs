using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class KhachHangModel
    {
        [Display(Name ="Mã khách hàng ")]
        public string MaKhachHang { get; set; }

        [Display(Name ="Họ và tên ")]
        public string HoVaTen { get; set; }
    }
}
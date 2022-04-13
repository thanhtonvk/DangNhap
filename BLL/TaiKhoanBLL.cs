using System.Collections.Generic;
using System.Linq;
using DangNhap.DAL;
using DangNhap.Models;

namespace DangNhap.BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL _taiKhoanDal = new TaiKhoanDAL();

        public List<TaiKhoan> TaiKhoans()
        {
            return _taiKhoanDal.TaiKhoans();
        }

        public bool DangKy(TaiKhoan taiKhoan)
        {
            List<TaiKhoan> taiKhoans = TaiKhoans();
            var model = taiKhoans.FirstOrDefault(x => x.Username == taiKhoan.Username);
            if (model == null)
            {
                taiKhoans.Add(taiKhoan);
                _taiKhoanDal.SaveChanges(taiKhoans);
                return true;
            }

            return false;

        }

        public bool DangNhap(string username, string password)
        {
            var model = TaiKhoans().FirstOrDefault(x => x.Username == username && x.Password == password);
            if (model == null) return false;
            return true;
        }
    }
}
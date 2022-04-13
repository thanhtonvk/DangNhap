using DangNhap.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace DangNhap.DAL
{
    public class TaiKhoanDAL
    {
        string file = @"D:\taikhoan.txt";
        public List<TaiKhoan> TaiKhoans()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            if (File.Exists(file))
            {
                using(StreamReader sr = new StreamReader(file))
                {
                    string line;
                    while((line= sr.ReadLine()) != null)
                    {
                        string[] arr = line.Split('#');
                        TaiKhoan taiKhoan = new TaiKhoan()
                        {
                            Username = arr[0],
                            Password = arr[1],
                            Name = arr[2],
                            Email = arr[3],
                            PhoneNumber = arr[4]
                        };
                        list.Add(taiKhoan);
                    }
                }
            }
            return list;
        }
        public void SaveChanges(List<TaiKhoan> taiKhoans)
        {
            using(StreamWriter sw = new StreamWriter(file))
            {
                foreach(TaiKhoan taiKhoan in taiKhoans)
                {
                    sw.WriteLine(taiKhoan.ToString());
                }
            }
        }
       
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DangNhap.Models
{
    public class TaiKhoan
    {
        private string username, password, name, email, phoneNumber;

        public TaiKhoan(string username, string password, string name, string email, string phoneNumber)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        public TaiKhoan()
        {
            
        }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public override String ToString()
        {
            return Username + "#" + Password + "#" + Name + "#" + Email + "#" + PhoneNumber;
        }
    }
}
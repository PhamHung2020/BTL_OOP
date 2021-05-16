﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private string _email;
        public string Email
        {
            get => _email;
            set { if (value != null) _email = value; }
        }

        private string _passWord;
        public string PassWord
        {
            get => _passWord;
            set { if (value != null) _passWord = value; }
        }

        public TaiKhoanDTO(string _email, string _passWord)
        {
            this._email = _email;
            this._passWord = _passWord;
        }
    }
}

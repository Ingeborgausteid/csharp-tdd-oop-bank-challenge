﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Bank
{
    public abstract class Account 
    {
        //IAccount _account;
        //public Account(IAccount account) 
        //{
        //    _account = account;
        //}

        public virtual bool CreateAccount()
        {
            return false;
        }

        public string AccountType { get; set; }

        public string Branch { get; set; }


    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.DAL;
using Taxi.BO;
using System.Data;

namespace Taxi.BLL
{
    public class PjesemarresiBLL
    {
        PjesemarresitDAL pjesemarresitDAL;

        public PjesemarresiBLL()
        {
            pjesemarresitDAL = new PjesemarresitDAL();
        }

        public DataTable ShowAdmins()
        {
            return pjesemarresitDAL.GetAllAdmin();
        }

        public bool CreateAdmin(PjesemarresitBO pjesemarresitBO)
        {
            return pjesemarresitDAL.InsertAdmin(pjesemarresitBO);
        }



        public static bool CheckLogin(string username, string password)
        {
            if (PjesemarresitDAL.CheckLogInConfig(username, password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

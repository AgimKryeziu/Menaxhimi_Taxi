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
    public class ShoferiBLL
    {
        ShoferiDAL shoferiDAL;

        public ShoferiBLL()
        {
            shoferiDAL = new ShoferiDAL();
        }

        public DataTable ShowShoferat()
        {
            return shoferiDAL.GetAllShofers();
        }

        public bool CreateShofer(ShoferiBO shoferi)
        {
            return shoferiDAL.InsertShofer(shoferi);
        }

        public ShoferiBO GetItem(int id)
        {
            return shoferiDAL.GetItemById(id);
        }

        public bool UpdateShofer(ShoferiBO shoferi)
        {
            return shoferiDAL.EditShofer(shoferi);
        }

        public bool DeleteShofer(int id)
        {
            return shoferiDAL.DeleteItem(id);
        }

        public static DataTable SelectDrivers()
        {
            return ShoferiDAL.SelectDrivers();
        }
    }
}

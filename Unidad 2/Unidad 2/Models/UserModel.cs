﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Unidad_2.Models
{
    public class UserModel
    {
        [PrimaryKey, AutoIncrement]
        public int UserID { get; set; }

        [MaxLength(40)]
        public string UserName { get; set; }

        [MaxLength(10)]
        public string Password { get; set; }

        [MaxLength(40)]
        public string Nombre { get; set; }



    }
}

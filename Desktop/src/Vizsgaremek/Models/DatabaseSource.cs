﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vizsgaremek.Models
{

    public enum DbSource { NONE, LOCALHOST, DEVOPS}

    class DatabaseSource
    {
        DbSource dbSource;

        public DbSource DbSource { get => dbSource; set => dbSource = value; }

        public DatabaseSource()
        {
            this.dbSource = DbSource.NONE;
        }



    }
}

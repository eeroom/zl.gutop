﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift.Bll
{
    public class UserInfo : Bll<Model.UserInfo>
    {
        public UserInfo(Model.DbContext dbcontext):base(dbcontext)
        {

        }
    }
}
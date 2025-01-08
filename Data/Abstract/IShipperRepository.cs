﻿using Infrastucture.Abstract;
using Northwind.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data.Abstract
{
    public interface IShipperRepository:IRepository<Shipper>
    {
    }
}

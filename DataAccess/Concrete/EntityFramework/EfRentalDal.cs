﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, DatabaseContext>,IRentalDal
    {
        
    }
}

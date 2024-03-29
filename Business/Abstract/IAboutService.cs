﻿using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAboutService
    {
        void Add(About about);
        void Delete(About about);
        void Update(About about);
        About GetById(int id);
        List<About> GetAll();
    }
}


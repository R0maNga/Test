﻿using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Finders
{   //интерфейс по поиску автора
    public interface IAuthorFinder
    {
        Task<List<Author>> Get();
        Task<List<Author>> GetFullInfo();

    }
}

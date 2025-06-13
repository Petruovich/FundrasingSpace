﻿using Fun.Application.IComponentModels;
using Fun.Domain.Fun.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun.Application.Fun.IServices
{
    public interface ICategoryService
    {
        Task<Category> CreateAsync(ICategoryComponentModel category);
        Task<IEnumerable<Category>> GetAllAsync();
    }
}

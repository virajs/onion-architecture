﻿using System.Collections.Generic;
using App.Domain.Entities;

namespace App.Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetProductsByCategoryId(int categoryId);
    }
}

﻿using ShopXPress.Api.Contracts;

namespace ShopXPress.Api.Services.Interfaces;

public interface IProductCategoryService
{
    Task<List<ProductCategoryContract>> GetAllCategories();
    Task<ProductCategoryContract> GetCateGoryById(int id);
    Task CreateCategory();
    Task UpdateCategory();
    Task DeleteCategory(int id);
}

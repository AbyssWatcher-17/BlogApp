﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogApp.Entities.Concrete;
using BlogApp.Entities.Dtos;
using BlogApp.Shared.Utilities.Results.Abstract;

namespace BlogApp.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<CategoryDto>> Get(int categoryId);
        Task <IDataResult<CategoryListDto>> GetAll();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeleted();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActive();
        Task<IResult> Add(CategoryAddDto categoryAddDto,string createdByName);
        Task<IResult> Update(CategoryUpdateDto categoryAddDto, string modifiedByName);
        Task<IResult> Delete(int categoryId);
        Task<IResult> HardDelete(int categoryId);
    }
}

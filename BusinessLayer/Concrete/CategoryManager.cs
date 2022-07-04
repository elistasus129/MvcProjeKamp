﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        

        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal icategorydal)
        {
            _categorydal = icategorydal;
        }

      

        public void CategoryAdd(Category category)
        {
            _categorydal.insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categorydal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categorydal.update(category);
        }

        public Category GetByID(int id)
        {
            return _categorydal.get(x => x.CategoryID == id);
        }

        public List<Category> GetList()
        {
            return _categorydal.List();
        }

        //public void CategoryAddBL(Category p)
        //{
        //    if (p.CategoryName=="" || p.CategoryStatus==false || p.CategoryName.Length<=2) {
        //        //hata mesajı
        //    }
        //    else
        //    {
        //        _categorydal.insert(p);
        //    }
        //}
    }
}

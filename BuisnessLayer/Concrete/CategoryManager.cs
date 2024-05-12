using BuisnessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{
		EfCategoryRepository efCategoryRepository;
		

		public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();

        }
        // YANLIŞ YOLLAR YEŞİLLER 
        /*CategoryRepository categoryRepository = new CategoryRepository();
		GenericRepository<Category> repo = new GenericRepository<Category>();*/
        public void CategoryAdd(Category category)
		{
			/*if (category.CategoryName != ""&&category.CategoryDescrption!=""&&category.CategoryName.Length>=5&&category.CategoryStatus==true)
			{
				categoryRepository.AddCategory(category);
			}
			else
			{
				//hata mesajı 
			}*/
			efCategoryRepository.Insert(category);
		}

		public void CategoryDelete(Category category)
		{
			/*	if (category.CategoryID != 0)
				{
					categoryRepository.DeleteCategory(category);
				}*/
			efCategoryRepository.Delete(category);
		}

		public void CategoryUpdate(Category category)
		{
			efCategoryRepository.Update(category);
		}

		public Category GetById(int id)
		{
			return efCategoryRepository.GetById(id);
		}

		public List<Category> GetList()
		{
			return efCategoryRepository.GetListAll();
		}
	}
}

using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
	public class BlogRepository : IBlogDal
	{
		public void AddBlog(Comment blog)
		{
			using var c = new Context();
			c.Add(blog);
			c.SaveChanges();
		}

		public void DeleteBlog(Comment blog)
		{
			using var c = new Context();
			c.Remove(blog);
			c.SaveChanges();
		}

		public Comment GetById(int id)
		{
			using var c = new Context();
			return c.Blogs.Find(id);
		}

		public List<Comment> ListAllBlog()
		{
			using var c = new Context();
			return c.Blogs.ToList();
		}

		public void UpdateBlog(Comment blog)
		{
			using var c = new Context();
			c.Update(blog);
			c.SaveChanges();
		}
	}
}

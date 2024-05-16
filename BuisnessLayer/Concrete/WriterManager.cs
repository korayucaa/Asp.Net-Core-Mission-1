using BuisnessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{
	public class WriterManager :IWriterSevice
	{
		IWriterDal _writerDal;
		

		public WriterManager(IWriterDal writerDal)
		{
			_writerDal = writerDal;
		}
		public void WriterAdd(Writer writer)
		{
			 _writerDal.Insert(writer);
		}
	}

}

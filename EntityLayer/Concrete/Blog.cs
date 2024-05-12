﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Comment
	{
		[Key]
		public int BlogID { get; set; }
		public string BlogTitle { get; set; }
		public string BlogContent { get; set; }

		public string BlogThumbnailImage { get; set; }
		public string BlogImage { get; set; }
		public DateTime BlogCreateDate { get; set; }
		public string BlogStatus { get; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
		public List<Comment> Comments { get; set; }
    }
}

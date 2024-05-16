using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
	public class CommentsList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentValues = new List<UserComment>
			{
				new UserComment
				{
					ID = 1,
					UserName = "Koray"
				},
				new UserComment
				{
					ID = 2,
					UserName = "Nuray"
				},
				new UserComment
				{
					ID = 3,
					UserName = "Pınar"
				}
			};

			return View(commentValues);
		}
	}
}

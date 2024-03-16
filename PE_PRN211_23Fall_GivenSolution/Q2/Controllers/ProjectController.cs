using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Q2.Models;

namespace Q2.Controllers
{
	public class ProjectController : Controller
	{
		static PE_PRN211_Fall23B5Context context = new PE_PRN211_Fall23B5Context();
		public IActionResult List()
		{
			using (PE_PRN211_Fall23B5Context context = new PE_PRN211_Fall23B5Context())
			{
				List<Project> projects = context.Projects.ToList();

				ViewBag.Projects = projects;

			};

			return View();
		}

		public IActionResult Delete(int id)
		{
			Project project = context.Projects.FirstOrDefault(x => x.Id == id);
			if (project != null)
			{
				if (project.Id == id)
				{
					context.Projects.Remove(project);
					context.SaveChanges();
				}
			}
			return RedirectToAction("List");
		}
	}
}

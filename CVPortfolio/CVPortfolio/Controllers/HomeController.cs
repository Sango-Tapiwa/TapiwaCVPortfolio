using CVPortfolio.Data;
using CVPortfolio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CVPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var profile = await _context.Profiles.FirstOrDefaultAsync();
            var educations = await _context.Educations.OrderBy(e => e.DisplayOrder).ToListAsync();
            var skills = await _context.Skills.OrderBy(s => s.DisplayOrder).ToListAsync();
            var projects = await _context.Projects.OrderBy(p => p.DisplayOrder).ToListAsync();
            var experiences = await _context.Experiences.OrderBy(e => e.DisplayOrder).ToListAsync();
            var certifications = await _context.Certifications.OrderBy(c => c.DisplayOrder).ToListAsync();

            var viewModel = new HomeViewModel
            {
                Profile = profile ?? new Profile(),
                Educations = educations,
                Skills = skills,
                Projects = projects,
                Experiences = experiences,
                Certifications = certifications
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }

    public class HomeViewModel
    {
        public Profile Profile { get; set; } = new Profile();
        public List<Education> Educations { get; set; } = new();
        public List<Skill> Skills { get; set; } = new();
        public List<Project> Projects { get; set; } = new();
        public List<Experience> Experiences { get; set; } = new();
        public List<Certification> Certifications { get; set; } = new();
    }
}

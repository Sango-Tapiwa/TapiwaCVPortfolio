using CVPortfolio.Models;

namespace CVPortfolio.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Profiles.Any())
            {
                return;
            }

            var profile = new Profile
            {
                FullName = "Your Full Name",
                ProfessionalTitle = "Final-Year IT Student · Aspiring Software Developer",
                AboutMe = "Passionate IT student with a strong foundation in software development. Experienced in building web applications using modern frameworks and technologies. Always eager to learn and tackle new challenges.",
                Email = "your.email@example.com",
                LinkedInUrl = "https://linkedin.com/in/yourprofile",
                GitHubUrl = "https://github.com/yourusername",
                Location = "Your City, Country",
                Phone = "+27 XX XXX XXXX"
            };
            context.Profiles.Add(profile);

            var educations = new[]
            {
                new Education
                {
                    Degree = "Bachelor of Computer and Information Science in Application Development",
                    Institution = "Emeris University",
                    Location = "Gauteng, South Africa",
                    StartYear = 2024,
                    EndYear = 2026,
                    Description = "Final year student with focus on cybersecurity, software development, database systems, and web technologies.",
                    DisplayOrder = 1
                }
            };
            context.Educations.AddRange(educations);

            var skills = new[]
            {
                new Skill { Name = "C#", Category = "Languages", DisplayOrder = 1 },
                new Skill { Name = "JavaScript", Category = "Languages", DisplayOrder = 2 },
                new Skill { Name = "Python", Category = "Languages", DisplayOrder = 3 },
                new Skill { Name = "SQL", Category = "Languages", DisplayOrder = 4 },
                new Skill { Name = "ASP.NET MVC", Category = "Frameworks", DisplayOrder = 5 },
                new Skill { Name = "React", Category = "Frameworks", DisplayOrder = 6 },
                new Skill { Name = "Entity Framework", Category = "Frameworks", DisplayOrder = 7 },
                new Skill { Name = "Git", Category = "Tools", DisplayOrder = 8 },
                new Skill { Name = "Visual Studio", Category = "Tools", DisplayOrder = 9 },
                new Skill { Name = "Docker", Category = "Tools", DisplayOrder = 10 },
                new Skill { Name = "Problem Solving", Category = "Soft Skills", DisplayOrder = 11 },
                new Skill { Name = "Team Collaboration", Category = "Soft Skills", DisplayOrder = 12 }
            };
            context.Skills.AddRange(skills);

            var projects = new[]
            {
                new Project
                {
                    Name = "Online CV Portfolio",
                    Description = "A professional CV/Portfolio web application built with ASP.NET MVC and SQLite. Features include responsive design, CRUD operations for managing content, and clean MVC architecture.",
                    TechStack = "C#, ASP.NET MVC, Entity Framework Core, SQLite, Bootstrap, HTML/CSS",
                    GitHubUrl = "https://github.com/yourusername/cv-portfolio",
                    CreatedDate = DateTime.Now,
                    DisplayOrder = 1
                }
            };
            context.Projects.AddRange(projects);

            context.SaveChanges();
        }
    }
}

using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext() // construtor para teste em memória
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core", "Minha Descricao de Projeto", 1 ,1, 10000),
                new Project("Meu projeto ASPNET Core 2", "Minha Descricao de Projeto 2", 1, 1, 20000),
                new Project("Meu projeto ASPNET Core 3", "Minha Descricao de Projeto 3", 1, 1, 30000)
            };

            Users = new List<User>
            {
                new User("Rodrigo Yuji","tanikawa.rodrigo@gmail.com",new DateTime(1997,10,06)),
                new User("Felipe Melo","carrinho@gmail.com",new DateTime(1997,10,06)),
                new User("Anderson Silva","canelite@gmail.com",new DateTime(1997,10,06)),
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL"),
            };
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<UserSkill> UserSkills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}

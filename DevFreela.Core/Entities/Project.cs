using DevFreela.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class Project : BaseEntity
    {
        public Project() { }

        public Project(string tittle, string description, int idClient, int idFreelancer, decimal totalCost)
        {
            Tittle = tittle;
            Description = description;
            IdClient = idClient;
            IdFreelancer = idFreelancer;
            TotalCost = totalCost;

            CreatedAt = DateTime.Now;
            Comments = new List<ProjectComment>();
            Status = ProjectStatusEnum.Created;
        }

        public string Tittle { get; private set; }
        public string Description { get; private set; }
        public int IdClient { get; private set; }
        public int IdFreelancer { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishAt{ get; private set; }
        public ProjectStatusEnum Status { get; private set; }
        public List<ProjectComment> Comments { get; private set; }

        public void Cancel()
        {
            if(Status == ProjectStatusEnum.InProgress)
                Status = ProjectStatusEnum.Canceled;
        }
        public void Finish()
        {
            if(Status == ProjectStatusEnum.InProgress)
                Status= ProjectStatusEnum.Finished;
                FinishAt = DateTime.Now;
        }
        public void Start()
        {
            if(Status == ProjectStatusEnum.Created)
                Status = ProjectStatusEnum.InProgress;
                StartedAt = DateTime.Now;
        }
        public void Update(string tittle, string description, decimal totalCost)
        {
            Tittle = tittle;
            Description = description;
            TotalCost = totalCost;
        }
    }
}

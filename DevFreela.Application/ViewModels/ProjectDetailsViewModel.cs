using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public ProjectDetailsViewModel(int id, string tittle, string description, decimal totalCost, DateTime? startedAt, DateTime? finishAt)
        {
            Id = id;
            Tittle = tittle;
            Description = description;
            TotalCost = totalCost;
            StartedAt = startedAt;
            FinishAt = finishAt;
        }

        public int Id { get; private set; }
        public string Tittle { get; private set; }
        public string Description { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishAt { get; private set; }
    }
}

using NEXARC.Domain.Common;
using NEXARC.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXARC.Domain.Entities.HumanResource
{
    public class City : AuditableEntity
    {
        public City()
        {
            Sites = new HashSet<Site>();
            Employees = new HashSet<Employee>();
        }

        //public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public RecordStatus Status { get; set; }

        public ICollection<Site> Sites { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}

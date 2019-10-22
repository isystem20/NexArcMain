using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using NEXARC.Domain.Common;
using NEXARC.Domain.Entities.CommonResource;
using NEXARC.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXARC.Domain.Entities.HumanResource
{
    public class Barangay : AuditableEntity
    {

        //public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ZipCode { get; set; }

        public RecordStatus Status { get; set; }

        public Municipality Municipality { get; set; }

        public virtual ICollection<Site> Sites { get; set; } = new HashSet<Site>();
        public ICollection<Employee> Employees { get; set; }

    }
}

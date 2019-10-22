using NEXARC.Domain.Common;
using NEXARC.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXARC.Domain.Entities.HumanResource
{
    public class Municipality : AuditableEntity
    {
        //public Municipality()
        //{
        //    Sites = new HashSet<Site>();
        //    Employees = new HashSet<Employee>();
        //    Barangays = new HashSet<Barangay>();
        //}

        //public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ZipCode { get; set; }
        public RecordStatus Status { get; set; }

        //public ICollection<Barangay> Barangays { get; set; }
        //public ICollection<Site> Sites { get; set; }
        //public ICollection<Employee> Employees { get; set; }

    }
}

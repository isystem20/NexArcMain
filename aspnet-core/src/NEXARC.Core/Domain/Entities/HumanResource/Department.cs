using Abp.Domain.Entities;
using NEXARC.Domain.Common;
using NEXARC.Domain.Entities.CommonResource;
using NEXARC.Domain.Enumerations;
using System.Collections.Generic;

namespace NEXARC.Domain.Entities.HumanResource
{
    public class Department: AuditableEntity
    {
        //public Department()
        //{
        //    EmployeeStates = new HashSet<EmployeeState>();
        //}
        //public string Id { get; set; }
        public int CompanyId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public RecordStatus Status { get; set; }
        public string Description { get; set; }

        //public Company Companies { get; set; }
        //public ICollection<EmployeeState> EmployeeStates { get; set; }
    }
}

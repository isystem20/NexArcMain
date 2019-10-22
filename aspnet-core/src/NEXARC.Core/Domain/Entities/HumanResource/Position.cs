using NEXARC.Domain.Common;
using NEXARC.Domain.Entities.CommonResource;
using NEXARC.Domain.Enumerations;
using System;
using System.Collections.Generic;

namespace NEXARC.Domain.Entities.HumanResource
{
    public class Position: AuditableEntity
    {
        //public Position()
        //{
        //    EmployeeStates = new HashSet<EmployeeState>();
        //}

        //public string Id { get; set; }
        public int CompanyId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public RecordStatus Status { get; set; } //Double Check this record in the Office.
        //public Company Company { get; set; }
        //public ICollection<EmployeeState> EmployeeStates { get; set; }
    }
}

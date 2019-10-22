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
    public class Group : AuditableEntity
    {
        //public Group() {
        //    EmployeeStates = new HashSet<EmployeeState>();
        //}

        //public string Id { get; set; }
        public string Code { get; set; }
        public int ParentGroupId { get; set; }
        public int CompanyId { get; set; }
        public string GroupManager { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public RecordStatus Status { get; set; }


        //public Company Company { get; set; }
        public Employee Employee { get; set; }

        //public ICollection<EmployeeState> EmployeeStates { get; set; }

    }
}

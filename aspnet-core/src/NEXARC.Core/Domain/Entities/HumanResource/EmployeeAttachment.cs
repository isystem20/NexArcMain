using NEXARC.Domain.Common;
using NEXARC.Domain.Entities.CommonResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXARC.Domain.Entities.HumanResource
{
    public class EmployeeAttachment : AuditableEntity
    {
        //public string Id { get; set; }
        public int CompanyId { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] AttachmentFile { get; set; }

        //public Company Company { get; set; }
        public Employee Employee { get; set; }

    }
}

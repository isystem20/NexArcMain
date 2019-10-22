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
    public class CompanyAttachment : AuditableEntity
    {
        //public string Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] AttachmentFile { get; set; }
        public bool RemindMe { get; set; }
        public DateTime? ReminderDateTime { get; set; }
        public string ReminderCaption { get; set; }
        public RecordStatus Status { get; set; }

        public Company Company { get; set; }
    }
}

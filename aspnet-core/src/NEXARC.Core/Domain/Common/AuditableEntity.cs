using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;

namespace NEXARC.Domain.Common
{
    public class AuditableEntity : Entity, IFullAudited
    {
        public int VersionNo { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public bool IsDeleted { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }

        public AuditableEntity()
        {
            CreationTime = Clock.Now;
            LastModificationTime = Clock.Now;
            VersionNo = 1;
        }
    }
}

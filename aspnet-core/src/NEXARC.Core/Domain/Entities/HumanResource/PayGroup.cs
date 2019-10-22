using Abp.Domain.Entities;
using NEXARC.Domain.Entities.CommonResource;
using NEXARC.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace NEXARC.Domain.Entities.HumanResource
{
    public class PayGroup : Entity
    {
        //public string Id { get; set; }
        public int CompanyId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public RecordStatus Status { get; set; }
        public int CreatedById { get; set; }
        public int LastModifiedById { get; set; }

        //public Company Companies { get; set; }
    }
}

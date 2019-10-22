using NEXARC.Domain.Common;
using NEXARC.Domain.Entities.CommonResource;
using NEXARC.Domain.Enumerations;
using System;
using System.Collections.Generic;

namespace NEXARC.Domain.Entities.HumanResource
{
    public class EmployeeState: AuditableEntity
    {
        //public string Id { get; set; }
        //public ChangeStateType ChangeType { get; set; } //Double check on EmployeeStateChangeType worked by Ollea
        public string Description { get; set; }
        public DateTime EffectivityDate { get; set; }

        public DateTime? HiredDate { get; set; }
        public DateTime? RegularDate { get; set; }
        public DateTime? ResignationDate { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }


        //USE IN HR
        public int CompanyId { get; set; }
        public int SiteId { get; set; }
        public int EmployeeId { get; set; }
        public int DivisionId { get; set; }
        public int DepartmentId { get; set; }
        public int SectionId { get; set; }
        public int CostCenterId { get; set; }
        public int PositionId { get; set; }
        public int EmploymentTypeId { get; set; }
        public int RankId { get; set; }
        public int GroupId { get; set; }


        public RecordStatus Status { get; set; } //Double Check

        //public Company Company { get; set; }
        //public Site Site { get; set; }
        //public Employee Employee { get; set; }
        //public Department Department { get; set; }
        //public Division Division { get; set; }
        //public Section Section { get; set; }
        //public CostCenter CostCenter { get; set; }
        //public Position Position { get; set; }
        //public EmploymentType EmploymentType { get; set; }
        //public Rank Rank { get; set; }
        //public Group Group { get; set; }


    }
}

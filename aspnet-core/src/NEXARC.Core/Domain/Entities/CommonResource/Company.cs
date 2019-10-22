using NEXARC.Domain.Common;
using NEXARC.Domain.Enumerations;
using NEXARC.Domain.Entities.HumanResource;
using System.Collections.Generic;

namespace NEXARC.Domain.Entities.CommonResource
{
    public class Company: AuditableEntity
    {
        public Company()
        {
            //Sites = new HashSet<Site>();
            ////EmployeeStates = new HashSet<EmployeeState>();
            //Departments = new HashSet<Department>();
            //CostCenters = new HashSet<CostCenter>();
            //Positions = new HashSet<Position>();
            //Employees = new HashSet<Employee>();
            //Divisions = new HashSet<Division>();
            //Ranks = new HashSet<Rank>();
            //Sections = new HashSet<Section>();


            CompanyAttachments = new HashSet<CompanyAttachment>();
            //Industries = new HashSet<Industry>();
            //EmployeeOffenseAndViolations = new HashSet<EmployeeOffenseAndViolation>();

        }
        //public string Id { get; set; }
        public string Code { get; set; }
        public string RegiseteredName { get; set; }
        public string RegisteredAddress { get; set; }
        public string ContactPersons { get; set; }
        public byte Logo { get; set; }
        public string Email { get; set; }


        public string MobileNo { get; set; }
        public string TelNo { get; set; }
        public string WebSites { get; set; }

        public string TIN { get; set; }
        public string PHIC { get; set; }
        public string HDMF { get; set; }
        public string SSS { get; set; }

        public int IndustryId { get; set; }
        public string Description { get; set; }

        public RecordStatus Status { get; set; }

        public Industry Industry { get; set; }


        public ICollection<Employee> Employees { get; set; }
        public ICollection<Site> Sites { get; set; }
        //public ICollection<EmployeeState> EmployeeStates { get; set; }
        //public ICollection<Department> Departments { get; set; }
        public ICollection<CostCenter> CostCenters { get; set; }
        public ICollection<Position> Positions { get; set; }
        public ICollection<Division> Divisions { get; set; }
        public ICollection<Rank> Ranks { get; set; }
        public ICollection<Section> Sections { get; set; }


        public ICollection<CompanyAttachment> CompanyAttachments { get; set; }
        //public ICollection<Industry> Industries { get; set; }
        //public ICollection<EmployeeOffenseAndViolation> EmployeeOffenseAndViolations { get; set; }

    }
}

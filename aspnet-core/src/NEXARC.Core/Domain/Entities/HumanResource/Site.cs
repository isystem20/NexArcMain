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
    public class Site : AuditableEntity
    {
        //public Site()
        //{
        //    EmployeeStates = new HashSet<EmployeeState>();
        //}

        //public string Id { get; set; }
        public string Code { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AddressStreet { get; set; }
        public int BarangayId { get; set; }
        public int MunicipalityId { get; set; }
        public int CityId { get; set; }
        public int ProvinceId { get; set; }
        public int RegionId { get; set; }
        public RecordStatus Status { get; set; }

        //public Company Company { get; set; }
        //public Barangay Barangay { get; set; }
        //public Municipality Municipality { get; set; }
        //public City City { get; set; }
        //public Province Province { get; set; }
        //public Region Region { get; set; }

        //public ICollection<EmployeeState> EmployeeStates { get; set; }

    }
}

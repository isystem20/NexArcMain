using NEXARC.Domain.Common;
using NEXARC.Domain.Entities.CommonResource;
using NEXARC.Domain.Enumerations;
using System;
using System.Collections.Generic;

namespace NEXARC.Domain.Entities.HumanResource
{
    public class EmployeeCertificate: AuditableEntity
    {
        //public string Id { get; set; }
        public int CompanyId { get; set; }
        public int EmployeeId { get; set; }
        public int CertificateId { get; set; }
        public string CertificateCustomName { get; set; }
        public string IssuedInstitution { get; set; }
        public string IssuedDate { get; set; }
        public string ValidityExpiration { get; set; }
        public string Remarks { get; set; }
        //public Company Companies { get; set; }

        //Provide property for attachments this is blob in db

        public Employee Employee { get; set; }
        public Certificate Certificate { get; set; }
    }
}

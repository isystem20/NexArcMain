using Abp.Domain.Entities;
using NEXARC.Domain.Entities.CommonResource;
using NEXARC.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace NEXARC.Domain.Entities.HumanResource
{
    //This is the default schedule of employee
    public class EmployeeScheduleState : Entity
    {
        public int EmployeeId { get; set; }
        public int CompanyId { get; set; }
        public int ShiftScheduleId { get; set; }
        public WeekDay WeekDay { get; set; }
        public int DayTypeId { get; set; }

        //public Employee Employee { get; set; }
        //public Company Companies { get; set; }
    }
}

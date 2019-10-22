using NEXARC.Domain.Common;
using NEXARC.Domain.Entities.CommonResource;
using NEXARC.Domain.Enumerations;
using System;
using System.Collections.Generic;

namespace NEXARC.Domain.Entities.HumanResource
{
    public class EmployeePayrollState: AuditableEntity
    {
        //public string Id { get; set; }
        public int CompanyId { get; set; }
        //public ChangeStateType ChangeType { get; set; } //Double check on EmployeeStateChangeType worked by Ollea
        public string Description { get; set; }
        public DateTime EffectivityDate { get; set; }

        //Use in Payroll
        public decimal MonthlyRate { get; set; }
        public decimal DailyRate { get; set; }
        public decimal HourlyRate { get; set; }

        public decimal MonthlyAllowance { get; set; }
        public decimal DailyAllowance { get; set; }
        public decimal HourlyAllowance { get; set; }

        //Check if employee is subject for computation of contrib
        public bool IsComputeSSS { get; set; }
        public bool IsComputePHIC { get; set; }
        public bool IsComputeHDMF { get; set; }
        public bool IsComputeWTAX { get; set; }


        public int RegionId { get; set; }
        public int PayGroupId { get; set; }
        public int ParameterId { get; set; } // need objects // multiplier of employee's rate, setup number of days in a year
        public int PayrollPeriodId { get; set; } // need objects // if employee's computation is daily, semi-monthly, hourly, monthly, every two weeks
        public int PayrollFrequencyId { get; set; } // need objects//if his/her payroll is every 1st period, 2nd Period
        public int TaxCodeId { get; set; } //Need Tax Code clas e.g. S - Single, M - Married, M1

        public RecordStatus Status { get; set; }

        //public Company Company { get; set; }
        public PayGroup PayGroup { get; set; }
        public Region Region { get; set; }
    }
}

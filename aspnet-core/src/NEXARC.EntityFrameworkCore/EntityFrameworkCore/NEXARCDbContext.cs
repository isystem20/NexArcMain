using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using NEXARC.Authorization.Roles;
using NEXARC.Authorization.Users;
using NEXARC.MultiTenancy;
using NEXARC.Domain.Entities.CommonResource;
using NEXARC.Domain.Entities.HumanResource;

namespace NEXARC.EntityFrameworkCore
{
    public class NEXARCDbContext : AbpZeroDbContext<Tenant, Role, User, NEXARCDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Company> Companies { get; set; }
        public DbSet<Barangay> Barangays { get; set; }
        public DbSet<BloodType> BloodTypes { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CompanyAttachment> CompanyAttachments { get; set; }
        public DbSet<CostCenter> CostCenters { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAttachment> EmployeeAttachments { get; set; }
        public DbSet<EmployeeCertificate> EmployeeCertificates { get; set; }
        public DbSet<EmployeeOffenseAndViolation> EmployeeOffenseAndViolations { get; set; }
        public DbSet<EmployeePayrollState> EmployeePayrollStates { get; set; }
        public DbSet<EmployeeScheduleState> EmployeeScheduleStates { get; set; }
        public DbSet<EmployeeState> EmployeeStates { get; set; }
        public DbSet<EmployeeWorkHistory> EmployeeWorkHistories { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Industry> industries { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<PayGroup> PayGroupz { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Religion> Religiona { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Site> Sites { get; set; }

        public NEXARCDbContext(DbContextOptions<NEXARCDbContext> options)
            : base(options)
        {
        }

    }
}

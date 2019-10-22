using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace NEXARC.Authorization
{
    public class NEXARCAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            context.CreatePermission(PermissionNames.Pages_BarangayAuth, L("Barangays"));
            context.CreatePermission(PermissionNames.Pages_BloodTypeAuth, L("BloodTypes"));
            context.CreatePermission(PermissionNames.Pages_CertificateAuth, L("Certificates"));
            context.CreatePermission(PermissionNames.Pages_CompanyAttachmentAuth, L("CompanyAttachments"));

            context.CreatePermission(PermissionNames.Pages_DepartmentAuth, L("Departments"));
            context.CreatePermission(PermissionNames.Pages_CostCenterAuth, L("CostCenters"));
            context.CreatePermission(PermissionNames.Pages_DivisionAuth, L("Divisions"));
            context.CreatePermission(PermissionNames.Pages_EmployeeAuth, L("Employees"));
            context.CreatePermission(PermissionNames.Pages_EmployeeAttachmentAuth, L("EmployeeAttachments"));
            context.CreatePermission(PermissionNames.Pages_EmployeeCertificateAuth, L("EmployeeCertificates"));
            context.CreatePermission(PermissionNames.Pages_EmployeeOffenseAndViolationAuth, L("EmployeeOffenseAndViolations"));
            context.CreatePermission(PermissionNames.Pages_EmployeePayrollStateAuth, L("EmployeePayrollStates"));

            context.CreatePermission(PermissionNames.Pages_RankAuth, L("Ranks"));
            context.CreatePermission(PermissionNames.Pages_RegionAuth, L("Regions"));
            context.CreatePermission(PermissionNames.Pages_ReligionAuth, L("Religions"));
            context.CreatePermission(PermissionNames.Pages_SectionAuth, L("Sections"));
            context.CreatePermission(PermissionNames.Pages_SiteAuth, L("Sites"));
            context.CreatePermission(PermissionNames.Pages_IndustryAuth, L("Industries"));
            context.CreatePermission(PermissionNames.Pages_MunicipalityAuth, L("Municipalities"));
            context.CreatePermission(PermissionNames.Pages_NationalityAuth, L("Nationalities"));
            context.CreatePermission(PermissionNames.Pages_PayGroupAuth, L("PayGroups"));
            context.CreatePermission(PermissionNames.Pages_PositionAuth, L("Positions"));
            context.CreatePermission(PermissionNames.Pages_ProvinceAuth, L("Provinces"));
            context.CreatePermission(PermissionNames.Pages_EmployeeScheduleStateAuth, L("EmployeeScheduleStates"));
            context.CreatePermission(PermissionNames.Pages_EmployeeStateAuth, L("EmployeeStates"));
            context.CreatePermission(PermissionNames.Pages_EmployeeWorkHistoryAuth, L("EmployeeWorkHistories"));
            context.CreatePermission(PermissionNames.Pages_EmploymentTypeAuth, L("EmploymentTypes"));
            context.CreatePermission(PermissionNames.Pages_GroupAuth, L("Groups"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, NEXARCConsts.LocalizationSourceName);
        }
    }
}

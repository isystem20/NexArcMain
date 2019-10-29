using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NEXARC.Migrations
{
    public partial class UpdatedEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePayrollStates_PayGroupz_PayGroupId1",
                table: "EmployeePayrollStates");

            migrationBuilder.DropForeignKey(
                name: "FK_PayGroupz_Companies_CompanyId",
                table: "PayGroupz");

            migrationBuilder.DropForeignKey(
                name: "FK_Sites_Municipalities_MunicipalityId",
                table: "Sites");

            migrationBuilder.DropForeignKey(
                name: "FK_Sites_Provinces_ProvinceId",
                table: "Sites");

            migrationBuilder.DropForeignKey(
                name: "FK_Sites_Regions_RegionId",
                table: "Sites");

            migrationBuilder.DropIndex(
                name: "IX_Sites_MunicipalityId",
                table: "Sites");

            migrationBuilder.DropIndex(
                name: "IX_Sites_ProvinceId",
                table: "Sites");

            migrationBuilder.DropIndex(
                name: "IX_Sites_RegionId",
                table: "Sites");

            migrationBuilder.DropIndex(
                name: "IX_PayGroupz_CompanyId",
                table: "PayGroupz");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePayrollStates_PayGroupId1",
                table: "EmployeePayrollStates");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Religiona");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "Religiona");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Rank");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "Rank");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Nationalities");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "Nationalities");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Municipalities");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "Municipalities");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "industries");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "industries");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "EmploymentTypes");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "EmploymentTypes");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "EmployeeWorkHistories");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "EmployeeWorkHistories");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "EmployeeStates");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "EmployeeStates");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "EmployeePayrollStates");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "EmployeePayrollStates");

            migrationBuilder.DropColumn(
                name: "PayGroupId1",
                table: "EmployeePayrollStates");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "EmployeeOffenseAndViolations");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "EmployeeOffenseAndViolations");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "EmployeeCertificates");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "EmployeeCertificates");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "EmployeeAttachments");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "EmployeeAttachments");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Divisions");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "Divisions");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "CostCenters");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "CostCenters");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "CompanyAttachments");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "CompanyAttachments");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "BloodTypes");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "BloodTypes");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Barangays");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "Barangays");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Sites",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Sites",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Sections",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Sections",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Religiona",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Religiona",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Regions",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Regions",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Rank",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Rank",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Provinces",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Provinces",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Positions",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Positions",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Nationalities",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Nationalities",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Municipalities",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Municipalities",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "industries",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "industries",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Groups",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Groups",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "EmploymentTypes",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "EmploymentTypes",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "EmployeeWorkHistories",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "EmployeeWorkHistories",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "EmployeeStates",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "EmployeeStates",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Employees",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Employees",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "EmployeePayrollStates",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "EmployeePayrollStates",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "EmployeeOffenseAndViolations",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "EmployeeOffenseAndViolations",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "EmployeeCertificates",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "EmployeeCertificates",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "EmployeeAttachments",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "EmployeeAttachments",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Divisions",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Divisions",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Departments",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Departments",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "CostCenters",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "CostCenters",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "CompanyAttachments",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "CompanyAttachments",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Companies",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Companies",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Cities",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Cities",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Certificates",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Certificates",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "BloodTypes",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "BloodTypes",
                newName: "DeletionTime");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "Barangays",
                newName: "LastModificationTime");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Barangays",
                newName: "DeletionTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Sites",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Sites",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Sites",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Sites",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Sites",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Sections",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Sections",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Sections",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Sections",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Sections",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Religiona",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Religiona",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Religiona",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Religiona",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Religiona",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Regions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Regions",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Regions",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Regions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Regions",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Rank",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Rank",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Rank",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Rank",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Rank",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Provinces",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Provinces",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Provinces",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Provinces",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Provinces",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Positions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Positions",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Positions",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Positions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Positions",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PayGroupz",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "PayGroupz",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "PayGroupz",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Nationalities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Nationalities",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Nationalities",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Nationalities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Nationalities",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Municipalities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Municipalities",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Municipalities",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Municipalities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Municipalities",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "industries",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "industries",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "industries",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "industries",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "industries",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Groups",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Groups",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Groups",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Groups",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Groups",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "EmploymentTypes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "EmploymentTypes",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "EmploymentTypes",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EmploymentTypes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "EmploymentTypes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "EmployeeWorkHistories",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "EmployeeWorkHistories",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "EmployeeWorkHistories",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EmployeeWorkHistories",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "EmployeeWorkHistories",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "EmployeeStates",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "EmployeeStates",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "EmployeeStates",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EmployeeStates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "EmployeeStates",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "EmployeeScheduleStates",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Employees",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Employees",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "EmployeePayrollStates",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "EmployeePayrollStates",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "EmployeePayrollStates",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EmployeePayrollStates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "EmployeePayrollStates",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "EmployeeOffenseAndViolations",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "EmployeeOffenseAndViolations",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "EmployeeOffenseAndViolations",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EmployeeOffenseAndViolations",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "EmployeeOffenseAndViolations",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "EmployeeCertificates",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "EmployeeCertificates",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "EmployeeCertificates",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EmployeeCertificates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "EmployeeCertificates",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "EmployeeAttachments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "EmployeeAttachments",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "EmployeeAttachments",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EmployeeAttachments",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "EmployeeAttachments",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Divisions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Divisions",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Divisions",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Divisions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Divisions",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Departments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Departments",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Departments",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Departments",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Departments",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "CostCenters",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "CostCenters",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "CostCenters",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CostCenters",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "CostCenters",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "CompanyAttachments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "CompanyAttachments",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "CompanyAttachments",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CompanyAttachments",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "CompanyAttachments",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Companies",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Companies",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Cities",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Cities",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Cities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Cities",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Certificates",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Certificates",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Certificates",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Certificates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Certificates",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "BloodTypes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "BloodTypes",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "BloodTypes",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BloodTypes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "BloodTypes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Barangays",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Barangays",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Barangays",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Barangays",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Barangays",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePayrollStates_PayGroupId",
                table: "EmployeePayrollStates",
                column: "PayGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePayrollStates_PayGroupz_PayGroupId",
                table: "EmployeePayrollStates",
                column: "PayGroupId",
                principalTable: "PayGroupz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePayrollStates_PayGroupz_PayGroupId",
                table: "EmployeePayrollStates");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePayrollStates_PayGroupId",
                table: "EmployeePayrollStates");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Religiona");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Religiona");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Religiona");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Religiona");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Religiona");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Rank");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Rank");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Rank");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Rank");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Rank");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "PayGroupz");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "PayGroupz");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Nationalities");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Nationalities");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Nationalities");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Nationalities");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Nationalities");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Municipalities");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Municipalities");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Municipalities");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Municipalities");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Municipalities");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "industries");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "industries");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "industries");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "industries");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "industries");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "EmploymentTypes");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "EmploymentTypes");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "EmploymentTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EmploymentTypes");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "EmploymentTypes");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "EmployeeWorkHistories");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "EmployeeWorkHistories");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "EmployeeWorkHistories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EmployeeWorkHistories");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "EmployeeWorkHistories");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "EmployeeStates");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "EmployeeStates");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "EmployeeStates");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EmployeeStates");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "EmployeeStates");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "EmployeePayrollStates");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "EmployeePayrollStates");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "EmployeePayrollStates");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EmployeePayrollStates");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "EmployeePayrollStates");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "EmployeeOffenseAndViolations");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "EmployeeOffenseAndViolations");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "EmployeeOffenseAndViolations");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EmployeeOffenseAndViolations");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "EmployeeOffenseAndViolations");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "EmployeeCertificates");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "EmployeeCertificates");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "EmployeeCertificates");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EmployeeCertificates");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "EmployeeCertificates");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "EmployeeAttachments");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "EmployeeAttachments");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "EmployeeAttachments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EmployeeAttachments");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "EmployeeAttachments");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Divisions");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Divisions");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Divisions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Divisions");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Divisions");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "CostCenters");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "CostCenters");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "CostCenters");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CostCenters");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "CostCenters");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "CompanyAttachments");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "CompanyAttachments");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "CompanyAttachments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CompanyAttachments");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "CompanyAttachments");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "BloodTypes");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "BloodTypes");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "BloodTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BloodTypes");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "BloodTypes");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Barangays");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Barangays");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Barangays");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Barangays");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Barangays");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "Sites",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Sites",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "Sections",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Sections",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "Religiona",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Religiona",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "Regions",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Regions",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "Rank",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Rank",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "Provinces",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Provinces",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "Positions",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Positions",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "Nationalities",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Nationalities",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "Municipalities",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Municipalities",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "industries",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "industries",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "Groups",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Groups",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "EmploymentTypes",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "EmploymentTypes",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "EmployeeWorkHistories",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "EmployeeWorkHistories",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "EmployeeStates",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "EmployeeStates",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "Employees",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Employees",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "EmployeePayrollStates",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "EmployeePayrollStates",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "EmployeeOffenseAndViolations",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "EmployeeOffenseAndViolations",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "EmployeeCertificates",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "EmployeeCertificates",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "EmployeeAttachments",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "EmployeeAttachments",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "Divisions",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Divisions",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "Departments",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Departments",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "CostCenters",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "CostCenters",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "CompanyAttachments",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "CompanyAttachments",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "Companies",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Companies",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "Cities",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Cities",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "Certificates",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Certificates",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "BloodTypes",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "BloodTypes",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModificationTime",
                table: "Barangays",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "DeletionTime",
                table: "Barangays",
                newName: "CreatedAt");

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Sites",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "Sites",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Sections",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "Sections",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Religiona",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "Religiona",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Regions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "Regions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Rank",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "Rank",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Provinces",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "Provinces",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Positions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "Positions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "PayGroupz",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Nationalities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "Nationalities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Municipalities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "Municipalities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "industries",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "industries",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Groups",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "Groups",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "EmploymentTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "EmploymentTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "EmployeeWorkHistories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "EmployeeWorkHistories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "EmployeeStates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "EmployeeStates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "EmployeeScheduleStates",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "EmployeePayrollStates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "EmployeePayrollStates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PayGroupId1",
                table: "EmployeePayrollStates",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "EmployeeOffenseAndViolations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "EmployeeOffenseAndViolations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "EmployeeCertificates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "EmployeeCertificates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "EmployeeAttachments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "EmployeeAttachments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Divisions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "Divisions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Departments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "Departments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "CostCenters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "CostCenters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "CompanyAttachments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "CompanyAttachments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Companies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "Companies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Cities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "Cities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Certificates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "Certificates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "BloodTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "BloodTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Barangays",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedById",
                table: "Barangays",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sites_MunicipalityId",
                table: "Sites",
                column: "MunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Sites_ProvinceId",
                table: "Sites",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Sites_RegionId",
                table: "Sites",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_PayGroupz_CompanyId",
                table: "PayGroupz",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePayrollStates_PayGroupId1",
                table: "EmployeePayrollStates",
                column: "PayGroupId1");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePayrollStates_PayGroupz_PayGroupId1",
                table: "EmployeePayrollStates",
                column: "PayGroupId1",
                principalTable: "PayGroupz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PayGroupz_Companies_CompanyId",
                table: "PayGroupz",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sites_Municipalities_MunicipalityId",
                table: "Sites",
                column: "MunicipalityId",
                principalTable: "Municipalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sites_Provinces_ProvinceId",
                table: "Sites",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sites_Regions_RegionId",
                table: "Sites",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientJsonpModule } from '@angular/common/http';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ModalModule } from 'ngx-bootstrap';
import { AbpModule } from '@abp/abp.module';
import { NgxPaginationModule } from 'ngx-pagination';
import { ServiceProxyModule } from '@shared/service-proxies/service-proxy.module';

import { SharedModule } from '@shared/shared.module';



import { HomeComponent } from '@app/home/home.component';
import { AboutComponent } from '@app/about/about.component';

// // tenants
// import { TenantsComponent } from '@app/tenants/tenants.component';
// import { CreateTenantDialogComponent } from './tenants/create-tenant/create-tenant-dialog.component';
// import { EditTenantDialogComponent } from './tenants/edit-tenant/edit-tenant-dialog.component';
// roles
import { RolesComponent } from '@app/roles/roles.component';
import { CreateRoleDialogComponent } from './roles/create-role/create-role-dialog.component';
import { EditRoleDialogComponent } from './roles/edit-role/edit-role-dialog.component';
// users
import { UsersComponent } from '@app/users/users.component';
import { CreateUserDialogComponent } from '@app/users/create-user/create-user-dialog.component';
import { EditUserDialogComponent } from '@app/users/edit-user/edit-user-dialog.component';
import { ChangePasswordComponent } from './users/change-password/change-password.component';
import { ResetPasswordDialogComponent } from './users/reset-password/reset-password.component';





import { HeaderComponent } from './layout/header/header.component';
import { FooterComponent } from './layout/footer/footer.component';
import { SidebarComponent } from './layout/sidebar/sidebar.component';
import { GeneratePayrollComponent } from './component/payroll/generate-payroll/generate-payroll.component';
import { PayAdjustmentComponent } from './component/payroll/pay-adjustment/pay-adjustment.component';
import { GeneratePayrollDetailComponent } from './component/payroll/generate-payroll-detail/generate-payroll-detail.component';
import { GeneratePayrollEmployeeComponent } from './component/payroll/generate-payroll-employee/generate-payroll-employee.component';
import { PayAdjustmentDetailComponent } from './component/payroll/pay-adjustment-detail/pay-adjustment-detail.component';
import { LeftSideBarComponent } from './layout/left-side-bar/left-side-bar.component';
import { RightSideBarComponent } from './layout/right-side-bar/right-side-bar.component';
import { PayrollItemComponent } from './component/payroll/maintenance/payroll-item/payroll-item.component';
import { PayrollPeriodComponent } from './component/payroll/maintenance/payroll-period/payroll-period.component';
import { LoanComponent } from './component/payroll/loan/loan.component';
import { LeaveConversionComponent } from './component/payroll/leave-conversion/leave-conversion.component';
import { PayrollRegisterComponent } from './component/payroll/reports/payroll-register/payroll-register.component';
import { LoanRegisterComponent } from './component/payroll/reports/loan-register/loan-register.component';
import { Rpt13thMonthPayComponent } from './component/payroll/reports/rpt13th-month-pay/rpt13th-month-pay.component';
import { LoanDetailComponent } from './component/payroll/loan-detail/loan-detail.component';

@NgModule({
  declarations: [
    AppComponent,

    HomeComponent,
    AboutComponent,
    // // tenants
    // TenantsComponent,
    // CreateTenantDialogComponent,
    // EditTenantDialogComponent,
    // roles
    RolesComponent,
    CreateRoleDialogComponent,
    EditRoleDialogComponent,
    // users
    UsersComponent,
    CreateUserDialogComponent,
    EditUserDialogComponent,
    ChangePasswordComponent,
    ResetPasswordDialogComponent,


    HeaderComponent,
    FooterComponent,
    SidebarComponent,
    GeneratePayrollComponent,
    PayAdjustmentComponent,
    GeneratePayrollEmployeeComponent,
    GeneratePayrollDetailComponent,
    PayAdjustmentDetailComponent,
    LeftSideBarComponent,
    RightSideBarComponent,
    PayrollItemComponent,
    PayrollPeriodComponent,
    LoanComponent,
    LeaveConversionComponent,
    PayrollRegisterComponent,
    LoanRegisterComponent,
    Rpt13thMonthPayComponent,
    LoanDetailComponent
  ],
  imports: [

    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    HttpClientJsonpModule,
    ModalModule.forRoot(),
    AbpModule,
    AppRoutingModule,
    ServiceProxyModule,
    SharedModule,
    NgxPaginationModule,

    BrowserModule,
    AppRoutingModule,

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
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
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

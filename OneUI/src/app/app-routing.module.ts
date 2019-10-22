import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';



// Payroll
import { GeneratePayrollComponent } from './component/payroll/generate-payroll/generate-payroll.component';
import { GeneratePayrollDetailComponent } from './component/payroll/generate-payroll-detail/generate-payroll-detail.component';
import { GeneratePayrollEmployeeComponent } from './component/payroll/generate-payroll-employee/generate-payroll-employee.component';

// Pay Adjustment
import { PayAdjustmentComponent } from './component/payroll/pay-adjustment/pay-adjustment.component';
import { PayAdjustmentDetailComponent } from './component/payroll/pay-adjustment-detail/pay-adjustment-detail.component';

// Loan
import { LoanComponent } from './component/payroll/loan/loan.component';
import { LoanDetailComponent } from './component/payroll/loan-detail/loan-detail.component';

//Payroll Register
import { PayrollRegisterComponent } from './component/payroll/reports/payroll-register/payroll-register.component';
import { LoanRegisterComponent } from './component/payroll/reports/loan-register/loan-register.component';

//maintenance
import { PayrollItemComponent } from './component/payroll/maintenance/payroll-item/payroll-item.component';


const routes: Routes = [
  {path: 'payroll/generate-payroll', component: GeneratePayrollComponent },
  {path: 'payroll/generate-payroll/:PayrollId', component: GeneratePayrollDetailComponent },
  {path: 'payroll/generate-payroll/:PayrollId/:EmployeeId', component: GeneratePayrollEmployeeComponent },

  {path: 'payroll/pay-adjustment', component: PayAdjustmentComponent },
  {path: 'payroll/pay-adjustment/:PayrollId', component: PayAdjustmentDetailComponent },
  {path: 'payroll/loan', component: LoanComponent },
  {path: 'payroll/loan/:Id', component: LoanDetailComponent },

  {path: 'payroll/maintenance/payroll-item', component: PayrollItemComponent},

  {path: 'payroll/reports/payroll-register', component: PayrollRegisterComponent},
  {path: 'payroll/reports/loan-register', component: LoanRegisterComponent}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})


export class AppRoutingModule { }

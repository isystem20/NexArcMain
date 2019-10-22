import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GeneratePayrollEmployeeComponent } from './generate-payroll-employee.component';

describe('GeneratePayrollEmployeeComponent', () => {
  let component: GeneratePayrollEmployeeComponent;
  let fixture: ComponentFixture<GeneratePayrollEmployeeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GeneratePayrollEmployeeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GeneratePayrollEmployeeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

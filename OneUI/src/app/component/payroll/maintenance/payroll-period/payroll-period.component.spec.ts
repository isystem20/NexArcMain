import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PayrollPeriodComponent } from './payroll-period.component';

describe('PayrollPeriodComponent', () => {
  let component: PayrollPeriodComponent;
  let fixture: ComponentFixture<PayrollPeriodComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PayrollPeriodComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PayrollPeriodComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

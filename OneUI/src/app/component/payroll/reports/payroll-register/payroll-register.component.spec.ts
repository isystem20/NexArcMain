import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PayrollRegisterComponent } from './payroll-register.component';

describe('PayrollRegisterComponent', () => {
  let component: PayrollRegisterComponent;
  let fixture: ComponentFixture<PayrollRegisterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PayrollRegisterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PayrollRegisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

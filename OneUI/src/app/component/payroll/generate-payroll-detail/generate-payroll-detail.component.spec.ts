import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GeneratePayrollDetailComponent } from './generate-payroll-detail.component';

describe('GeneratePayrollDetailComponent', () => {
  let component: GeneratePayrollDetailComponent;
  let fixture: ComponentFixture<GeneratePayrollDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GeneratePayrollDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GeneratePayrollDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

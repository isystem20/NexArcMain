import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PayrollItemComponent } from './payroll-item.component';

describe('PayrollItemComponent', () => {
  let component: PayrollItemComponent;
  let fixture: ComponentFixture<PayrollItemComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PayrollItemComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PayrollItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

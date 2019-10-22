import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PayAdjustmentDetailComponent } from './pay-adjustment-detail.component';

describe('PayAdjustmentDetailComponent', () => {
  let component: PayAdjustmentDetailComponent;
  let fixture: ComponentFixture<PayAdjustmentDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PayAdjustmentDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PayAdjustmentDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

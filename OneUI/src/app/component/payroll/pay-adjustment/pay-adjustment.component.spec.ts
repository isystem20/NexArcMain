import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PayAdjustmentComponent } from './pay-adjustment.component';

describe('PayAdjustmentComponent', () => {
  let component: PayAdjustmentComponent;
  let fixture: ComponentFixture<PayAdjustmentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PayAdjustmentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PayAdjustmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

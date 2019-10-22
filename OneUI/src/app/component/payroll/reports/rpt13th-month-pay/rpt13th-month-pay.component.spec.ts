import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Rpt13thMonthPayComponent } from './rpt13th-month-pay.component';

describe('Rpt13thMonthPayComponent', () => {
  let component: Rpt13thMonthPayComponent;
  let fixture: ComponentFixture<Rpt13thMonthPayComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Rpt13thMonthPayComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Rpt13thMonthPayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LeaveConversionComponent } from './leave-conversion.component';

describe('LeaveConversionComponent', () => {
  let component: LeaveConversionComponent;
  let fixture: ComponentFixture<LeaveConversionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LeaveConversionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LeaveConversionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

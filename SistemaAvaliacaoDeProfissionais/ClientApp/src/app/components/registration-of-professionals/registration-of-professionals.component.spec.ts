import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistrationOfProfessionalsComponent } from './registration-of-professionals.component';

describe('RegistrationOfProfessionalsComponent', () => {
  let component: RegistrationOfProfessionalsComponent;
  let fixture: ComponentFixture<RegistrationOfProfessionalsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegistrationOfProfessionalsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RegistrationOfProfessionalsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

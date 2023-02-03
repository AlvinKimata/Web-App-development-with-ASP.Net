import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentStandAloneComponent } from './student-stand-alone.component';

describe('StudentStandAloneComponent', () => {
  let component: StudentStandAloneComponent;
  let fixture: ComponentFixture<StudentStandAloneComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ StudentStandAloneComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StudentStandAloneComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

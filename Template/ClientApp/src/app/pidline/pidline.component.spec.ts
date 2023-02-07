import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PidlineComponent } from './pidline.component';

describe('PidlineComponent', () => {
  let component: PidlineComponent;
  let fixture: ComponentFixture<PidlineComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PidlineComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PidlineComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

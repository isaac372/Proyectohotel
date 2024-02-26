import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormreservaComponent } from './formreserva.component';

describe('FormreservaComponent', () => {
  let component: FormreservaComponent;
  let fixture: ComponentFixture<FormreservaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormreservaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormreservaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

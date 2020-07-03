import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BikeAddingComponent } from './bike-adding.component';

describe('BikeAddingComponent', () => {
  let component: BikeAddingComponent;
  let fixture: ComponentFixture<BikeAddingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BikeAddingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BikeAddingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

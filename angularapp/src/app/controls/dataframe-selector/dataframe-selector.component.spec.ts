import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DataframeSelectorComponent } from './dataframe-selector.component';

describe('DataframeSelectorComponent', () => {
  let component: DataframeSelectorComponent;
  let fixture: ComponentFixture<DataframeSelectorComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DataframeSelectorComponent]
    });
    fixture = TestBed.createComponent(DataframeSelectorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

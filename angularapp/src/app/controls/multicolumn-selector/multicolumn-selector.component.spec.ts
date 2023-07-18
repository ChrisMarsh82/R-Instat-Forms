import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MulticolumnSelectorComponent } from './multicolumn-selector.component';

describe('MulticolumnSelectorComponent', () => {
  let component: MulticolumnSelectorComponent;
  let fixture: ComponentFixture<MulticolumnSelectorComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MulticolumnSelectorComponent]
    });
    fixture = TestBed.createComponent(MulticolumnSelectorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

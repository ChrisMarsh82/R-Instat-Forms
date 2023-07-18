import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ColumnSelectorComponent } from './column-selector.component';

describe('ColumnSelectorComponent', () => {
  let component: ColumnSelectorComponent;
  let fixture: ComponentFixture<ColumnSelectorComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ColumnSelectorComponent]
    });
    fixture = TestBed.createComponent(ColumnSelectorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

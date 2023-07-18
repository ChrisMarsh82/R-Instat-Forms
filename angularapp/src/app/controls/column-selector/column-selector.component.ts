import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-column-selector',
  templateUrl: './column-selector.component.html',
  styleUrls: ['./column-selector.component.css']
})
export class ColumnSelectorComponent {
  @Input() rControl: any
}

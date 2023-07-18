import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-text-selector',
  templateUrl: './text-selector.component.html',
  styleUrls: ['./text-selector.component.css']
})
export class TextSelectorComponent {
  @Input() rControl: any
}

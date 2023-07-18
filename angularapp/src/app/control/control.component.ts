import { Component, Input } from '@angular/core';
import { RControlAndValues, RInstatControl } from '../shared.interface'

@Component({
  selector: 'app-control',
  templateUrl: './control.component.html',
  styleUrls: ['./control.component.css']
})
export class ControlComponent {
  @Input() rControl?: RControlAndValues//RInstatControl | undefined
}



import { Component, OnInit, EventEmitter, Input, Output } from '@angular/core';
import { RControlAndValues } from '../../shared.interface';

@Component({
  selector: 'app-number-selector',
  templateUrl: './number-selector.component.html',
  styleUrls: ['./number-selector.component.css'],


})
export class NumberSelectorComponent {
  @Input() rControl?: RControlAndValues;

  constructor() {
    //this.rControl = {
    //  control: {
    //    id: 0,
    //    controlType: 1,
    //    label: "",
    //    help: "",
    //    controlLink: 0,
    //    min: 0,
    //    max: 0,
    //    defaultValue: "",
    //    possibleValues: [],
    //    controls: []
    //  },
    //  values: {
    //    id: 0, values: ["0"]
    //  }
    //}
  }

  onInputChange(): void {
    if (this.rControl != null) {
      this.rControl.values.values[0] = this.rControl.values.values[0].toString();
    }
  }


  //ngOnInit(): void {

  //  this.min = (this.rControl?.control.min || 0);
  //  this.max = (this.rControl?.control.max || 0);
  //  this.title = (this.rControl?.control.help || "");
  //  this.testing = (this.rControl?.values.values || [""]);
  //}
  //onChange(): void {
  //  this.rControl.values.values[0] = 8;
  ////  this.rControlChange.emit(this.rControl);
  //}
  //updateValue(): void {
  //  this.rControl.values.values[0] = 'new value';
  //}
}

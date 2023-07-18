import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-multicolumn-selector',
  templateUrl: './multicolumn-selector.component.html',
  styleUrls: ['./multicolumn-selector.component.css']
})
export class MulticolumnSelectorComponent implements OnInit {
  @Input() rControl: any
  testColumns : any


  ngOnInit() {
    this.testColumns = ['column1', 'column2', 'column3']
  }
}

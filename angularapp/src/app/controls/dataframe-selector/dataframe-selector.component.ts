import { Component, Input,OnInit } from '@angular/core';

@Component({
  selector: 'app-dataframe-selector',
  templateUrl: './dataframe-selector.component.html',
  styleUrls: ['./dataframe-selector.component.css']
})
export class DataframeSelectorComponent implements OnInit {
  @Input() rControl: any
  testDataFrames: any

  ngOnInit() {
    this.testDataFrames = ['dataframe1' , 'dataframe2', 'dataframe3']
  }

}

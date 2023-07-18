import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { RControlAndValues, RFormValue, RInstatContolValues, RInstatControl } from '../shared.interface';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {
  public rform: RInstatForm = {id:0,name:"undefined",description:"undefined", controls:[]}
  public id: number = 123; // Replace with your desired ID valu
 // public rValues: Array<RInstatContolValues> = [];
  public rScript?: string;
  public rControlAndValues: Array<RControlAndValues> = [];
  public rFormValue?: RFormValue ;





  ngOnInit(): void {
    this.route.params.subscribe(params => {
      const id = +params['id']; // Extract the 'id' parameter from the route
      if (id) {
        this.id = id; // Update the 'id' property
        this.fetchFormData();
        
      }
    });
  }

  //initalizeControlValues(): void {
  //  this.rform.controls?.forEach((control) => {
  //    var contolValues: RInstatContolValues = { id: control.id, values :[] } ;


  //    this.rValues?.push(contolValues) : RInstatContolValues {

  //    }
  //  })
  //}
  addValuesToControls(): void {
    this.rFormValue = {id: this.rform.id,controlValues:[]}
    this.rform.controls?.forEach((control) => {
      var rValue: RInstatContolValues = { id: control.id, values: [] };
      if (control.defaultValue === null) {
        rValue.values = [];
      } else {
        rValue.values = [control.defaultValue]
      };
      this.rFormValue?.controlValues?.push(rValue);
      this.rControlAndValues.push({control:control,values:rValue})
    })
  }

  //getControlValue(rControl: RInstatControl): RControlAndValues {
  //  var rValue: RInstatContolValues = { id: rControl.id, values :[]};
  //  if (rControl.defaultValue === null) {
  //    rValue.values = [];
  //  } else {
  //    rValue.values = [rControl.defaultValue]
  //  };
  //  this.rValues.push(rValue)  
  //  return {
  //    control: rControl, values: rValue
  //  }
  //}


  fetchFormData(): void {

    const url =`/RInstatForm/allforms/${this.id}`;
    this.http.get<RInstatForm>(url).subscribe(
      data => {
        this.rform = data;
        this.addValuesToControls();
      },
      error => {
        console.error(error);
      }  
    );  
  }


  onButtonClick(): void {
    const headers = new HttpHeaders({
      'Content-Type': 'application/json'
    });


    this.http.post('/RInstatForm/rscript', this.rFormValue, {
      headers,
      responseType: 'text' // Set the response type to text
    } ).subscribe(
      (responce: string) => {
        this.rScript = responce;
      },
      (error: any) => {
        // Handle errors
        console.error(error);
      }
    );
   // this.rScript = this.http.post<string>('/RInstatForm/rscript', this.rFormValue);
  }
  constructor(private http: HttpClient, private route: ActivatedRoute) { }
}

interface RInstatForm {
  id: number;
  name: string;
  description: string;
   controls: Array<RInstatControl> | null;
}



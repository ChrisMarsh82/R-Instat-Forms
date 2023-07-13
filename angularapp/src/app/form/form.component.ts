import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {
  public form?: RInstatForm[];
  public id: number = 123; // Replace with your desired ID valu

  ngOnInit(): void {

    const url = `/RInstatForm/forms?id=${this.id}`;
    this.http.get<RInstatForm[]>(url).subscribe(
      result => {
        this.form = result;
      },
      error => {
        console.error(error);
      }
    );
  }

  constructor(private http: HttpClient, private route: ActivatedRoute) { }
}

interface RInstatForm {
  id: number;
  name: string;
  description: string;
  controls: Array<RInstatControl>;
}

interface RInstatControl {
  id: number;
}


import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-form-list',
  templateUrl: './form-list.component.html',
  styleUrls: ['./form-list.component.css']
})
export class FormListComponent implements OnInit {
  public forms?: RInstatForms[];


  ngOnInit(): void {
    this.http.get<RInstatForms[]>('/RInstatForm/allforms').subscribe(
      result => {
        this.forms = result;
      },
      error => {
        console.error(error);
      }
    );
  }

  onButtonClick(id: number): void {
    this.router.navigate(['/forms', id]);
  }

  constructor(private http: HttpClient, private router: Router) { }
}

interface RInstatForms {
  id: number;
  name: string;
  description: string;
}

import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { FormListComponent } from './form-list/form-list.component';
import { FormComponent } from './form/form.component';
/*import { ControlComponent } from './control/control.component';*/

const routes: Routes = [
  { path: 'allForms', component: FormListComponent },
  { path: 'forms/:id', component: FormComponent },
  { path: '', redirectTo: '/allForms', pathMatch: 'full' },
];

@NgModule({
  declarations: [
    AppComponent,
    FormListComponent,
    FormComponent,
    //ControlComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot(routes),
    //RouterModule.forRoot([
    //  { path: 'allForms', component: FormListComponent },
    //  { path: 'form-component', component: FormComponent },
    //  { path: '', redirectTo: '/allForms', pathMatch: 'full'},
    //]),
  ],
  providers: [],
  bootstrap: [AppComponent],
//  exports: [RouterModule]
})


//export class AppRoutingModule { }



export class AppModule { }


//export { FormListComponent };

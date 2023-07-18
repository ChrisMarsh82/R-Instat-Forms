import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { FormListComponent } from './form-list/form-list.component';
import { FormComponent } from './form/form.component';
import { ControlComponent } from './control/control.component'
import { DataframeSelectorComponent } from './controls/dataframe-selector/dataframe-selector.component';
import { ColumnSelectorComponent } from './controls/column-selector/column-selector.component';
import { MulticolumnSelectorComponent } from './controls/multicolumn-selector/multicolumn-selector.component';
import { NumberSelectorComponent } from './controls/number-selector/number-selector.component';
import { TextSelectorComponent } from './controls/text-selector/text-selector.component';
//import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MultiSelectModule } from 'primeng/multiselect';

import { FormsModule } from '@angular/forms'
//import { NgMultiSelectDropDownModule } from 'ng-multiselect-dropdown';
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
    ControlComponent,
    DataframeSelectorComponent,
    ColumnSelectorComponent,
    MulticolumnSelectorComponent,
    NumberSelectorComponent,
    TextSelectorComponent,
    
    //ControlComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot(routes),
    BrowserModule,
    BrowserAnimationsModule,
    MultiSelectModule,
    FormsModule,
   // NgMultiSelectDropDownModule.forRoot(),
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

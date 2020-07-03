import { BrowserModule } from '@angular/platform-browser';
import { FormBuilder, FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';


import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { BikeAddingComponent } from './bike-adding/bike-adding.component';
@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    BikeAddingComponent
  ],
  imports: [
    BrowserModule,FormsModule,
    ReactiveFormsModule,
    
  ],
  providers: [FormBuilder],
  bootstrap: [AppComponent]
})
export class AppModule { }

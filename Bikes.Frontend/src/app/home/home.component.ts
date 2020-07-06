import { Component, OnInit } from '@angular/core';
import{Bike} from '../models/bike';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { BikeType } from '../models/enums/bikeType';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  bikes: Bike[] = [];
  addBikeForm: FormGroup;
  bike: Bike;
  bikeType1=null;
  bikeType = BikeType;
  enumKeys = [];

  
  constructor(    private formBuilder: FormBuilder,
    ) {this.enumKeys = Object.keys(this.bikeType).filter(f=>!isNaN(Number(f))); }
    bikeForm = new FormGroup(
      {
        name : new FormControl(""),
        type : new FormControl(""),
        price: new FormControl("")
  
      }
    )



  ngOnInit(): void {
  }
  public addBike(){
    const newBike:Bike = {
      id : this.bikes.slice(-1).pop() == undefined ? 0 : this.bikes.slice(-1).pop().id,
      name : this.bikeForm.get('name').value,
      type : this.bikeForm.get('type').value,
      price : this.bikeForm.get('price').value
    };
      
    this.bikes.push(newBike);
    console.log(this.bikes);
    
  }
  
}

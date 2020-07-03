import { Component, OnInit } from '@angular/core';
import{Bike} from 'src/app/models/bike';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BikeType } from '../models/enums/bikeType';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  addBikeForm: FormGroup;
  bike: Bike;
  
  constructor(    private formBuilder: FormBuilder,
    ) { }




  ngOnInit(): void {
  }

}

import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { BikeType } from '../models/enums/bikeType';

@Component({
  selector: 'app-bike-adding',
  templateUrl: './bike-adding.component.html',
  styleUrls: ['./bike-adding.component.css']
})
export class BikeAddingComponent implements OnInit {
  bikeType1=null;
  bikeType = BikeType;
  enumKeys = [];
  constructor() {
    this.enumKeys = Object.keys(this.bikeType).filter(f=>!isNaN(Number(f)));
   }
  bikeForm = new FormGroup(
    {
      name : new FormControl(""),
      type : new FormControl(BikeType),
      price: new FormControl(0)

    }
  )

  ngOnInit(): void {
  }

}

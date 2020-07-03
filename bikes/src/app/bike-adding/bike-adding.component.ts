import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { BikeType } from '../models/enums/bikeType';

@Component({
  selector: 'app-bike-adding',
  templateUrl: './bike-adding.component.html',
  styleUrls: ['./bike-adding.component.css']
})
export class BikeAddingComponent implements OnInit {

  constructor() { }
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

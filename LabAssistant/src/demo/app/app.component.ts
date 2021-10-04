import { Component, OnInit } from '@angular/core';
import { LabService } from './Services/lab.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  
  constructor(public labservice: LabService){

  }
  ngOnInit(){
   
  }
}

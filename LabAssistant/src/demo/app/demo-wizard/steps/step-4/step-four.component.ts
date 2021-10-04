import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/demo/app/Model/employee';
import { LabService } from 'src/demo/app/Services/lab.service';

@Component({
  selector: 'app-step-four',
  templateUrl: './step-four.component.html',
  styleUrls: ['./step-four.component.css']
})
export class StepFourComponent implements OnInit {
  public empList: any[];
  constructor(public labservice: LabService
  ) {
  }

  ngOnInit(): void {
    this.labservice.getApiData().subscribe((data)=>{
       this.empList = data as Employee[];
    })
  }
}

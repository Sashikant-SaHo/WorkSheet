import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Employee } from '../Model/employee';

@Injectable({
  providedIn: 'root'
})
export class LabService {

  constructor(public http: HttpClient) { }
  public getApiData(): Observable<Employee[]>{
    return this.http.get<Employee[]>('http://localhost:24710/Api/InstaShield/getdata');  
  }
}

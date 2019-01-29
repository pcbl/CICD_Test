import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent
{
  title = 'angular-client';
  name:string = "Test";
  response:string;

  constructor(private http: HttpClient)
  {
    
  }

  SayHello()
  {
    this.http.get<string>('http://localhost:57499/api/Test/'+this.name).subscribe((data)=>
    {
      this.response=data;
    });
  }
}

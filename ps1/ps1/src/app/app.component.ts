import { Component } from '@angular/core';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'app1';
  value:any =''
  getvalues(x:object)
  {
    console.log(x)
    this.value=x
  }
}

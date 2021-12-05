import { Component } from '@angular/core';

@Component({
  selector: 'sw-welcome',
  templateUrl: './welcome.component.html'
})
export class WelcomeComponent {
  message:string
  constructor(){
    this.message="Welcome to Swabhav"
  }
}

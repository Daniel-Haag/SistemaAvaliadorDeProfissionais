import { Component, OnInit } from '@angular/core';
import { environment } from '../environments/environment';
import { LoginService } from './services/login.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit {
  title = 'app';

  mostrarMenu: boolean = true;

  constructor(private loginService: LoginService) {
    
  }

  ngOnInit() {

    if (environment.loggedUser) {
      this.mostrarMenu = true;
    }

    this.loginService.mostrarMenuEmitter.subscribe(
      mostrar => this.mostrarMenu = mostrar
    );
  }
}



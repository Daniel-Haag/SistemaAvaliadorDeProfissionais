import { EventEmitter } from '@angular/core';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { User } from '../models/user.model';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  private authUser: boolean = false;

  mostrarMenuEmitter = new EventEmitter<boolean>();

  constructor(private router: Router) { }

  exeLogin(user: User): void {

    if (true) {
      this.authUser = true;

      this.mostrarMenuEmitter.emit(true);

      this.router.navigate(['index']);
    }
    else{
      this.mostrarMenuEmitter.emit(false);
    }

  }
}

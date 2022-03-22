import { Component, OnInit } from '@angular/core';
import { User } from '../../models/user.model';
import { LoginService } from '../../services/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  private user: User = {
    userName: '',
    password: ''
  }

  constructor(private loginService: LoginService) { }

  ngOnInit(): void {
  }

  login() {

    this.loginService.exeLogin(this.user);

  }

}

import { HttpClient } from '@angular/common/http';
import { error } from '@angular/compiler/src/util';
import { Inject } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Professional } from '../../models/professional.model';

@Component({
  selector: 'app-registration-of-professionals',
  templateUrl: './registration-of-professionals.component.html',
  styleUrls: ['./registration-of-professionals.component.css']
})
export class RegistrationOfProfessionalsComponent implements OnInit {

  //public professionals: Professional[] = [];

  columnsToDisplay = ['ProfissionalID', 'Nome', 'Admissao', 'Cargo', 'Setor'];
  professionalsDataArray: Professional[] = [];

  constructor(private router: Router, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    http.get<Professional[]>(baseUrl + 'profissionais').subscribe(result => {

      console.log(result);
      this.professionalsDataArray = result;
      //this.professionals = result;
    }, error => console.error(error));
  }

  ngOnInit(): void {

    
    

  }

  

  navigateToCreateProfessional(): void {
    this.router.navigate(["createProfessional"]);
  }

}

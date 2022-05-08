import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Professional } from '../../models/professional.model';

@Component({
  selector: 'app-registration-of-professionals',
  templateUrl: './registration-of-professionals.component.html',
  styleUrls: ['./registration-of-professionals.component.css']
})
export class RegistrationOfProfessionalsComponent implements OnInit {

  professional1: Professional = {
    professionalID: 1,
    name: 'Daniel Haag',
    admission: '01/01/20',
    evaluationStatus: '1',
    office: 'Developer',
    passWord: '123',
    registration: '1621',
    sector: 'ti',
    userName: 'dhaag'
  }

  professional2: Professional = {
    professionalID: 1,
    name: 'Daniel Haag',
    admission: '01/01/20',
    evaluationStatus: '1',
    office: 'Developer',
    passWord: '123',
    registration: '1621',
    sector: 'ti',
    userName: 'dhaag'
  }

  professional3: Professional = {
    professionalID: 3,
    name: 'Jéssica Rigol',
    admission: '01/01/20',
    evaluationStatus: '1',
    office: 'Developer',
    passWord: '123',
    registration: '1622',
    sector: 'ti',
    userName: 'jrigol'
  }

  professionals: Professional[] = [];

  columnsToDisplay = ['professionalID', 'name', 'admission', 'office', 'sector'];
  professionalsDataArray: Professional[] = [this.professional1, this.professional2, this.professional3];

  constructor(private router: Router) { }

  ngOnInit(): void {

    
      //Estou criando a listagem de profissionais no lado do cliente usando a documentação do Angular Material
      //https://material.angular.io/components/table/overview
    

  }

  navigateToCreateProfessional(): void {
    this.router.navigate(["createProfessional"]);
  }

}

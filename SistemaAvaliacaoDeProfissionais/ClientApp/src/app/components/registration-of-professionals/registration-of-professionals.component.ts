import { HttpClient, HttpHeaders } from '@angular/common/http';
import { error } from '@angular/compiler/src/util';
import { Inject } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Cargo } from '../../models/cargo.model';
import { Profissionais } from '../../models/profissionais.model';
import { Setores } from '../../models/setores.model';
import { StatusAvaliacao } from '../../models/statusAvaliacao.model';
import { TipoCargo } from '../../models/tipoCargo.model';

@Component({
  selector: 'app-registration-of-professionals',
  templateUrl: './registration-of-professionals.component.html',
  styleUrls: ['./registration-of-professionals.component.css']
})
export class RegistrationOfProfessionalsComponent implements OnInit {

  columnsToDisplay = ['ProfissionalID', 'Nome', 'Admissao', 'Cargo', 'Setor'];
  professionalsDataArray: Profissionais[] = [];

  tipoCargo: TipoCargo = {
    tipoCargoID: 1,
    nomeTipoCargo: "teste"
  }

  cargo: Cargo = {
    cargoID: 1,
    nomeCargo: "teste",
    tipoCargo: this.tipoCargo
  }

  setor: Setores = {
    setorID: 1,
    nomeSetor: "teste"
  }

  statusAvaliacao: StatusAvaliacao = {
    statusAvaliacaoID: 1,
    nomeStatusAvaliacao: "teste"
  }

  profissional: Profissionais = {
    admissao: "01/11/91",
    cargo: this.cargo,
    gestor: true,
    matricula: "123",
    nome: "ze",
    profissionalID: 1,
    senha: "123",
    setor: this.setor,
    statusAvaliacao: this.statusAvaliacao,
    userName: "bah"
  }

  constructor(private router: Router,
    private httpClient: HttpClient,
    @Inject('BASE_URL') private baseUrl: string)
  {
    
  }

  ngOnInit(): void {

    //this.profissionaisService.CadastrarProfissional(this.profissional);

    //this.professionalsDataArray = this.profissionaisService.ObterProfissionais();
    //console.log(this.profissionaisService.ObterProfissionais());

    //this.professionalsDataArray = this.profissionaisService.ObterProfissionais();

    /*this.professionalsDataArray = */
    //console.log(this.professionalsDataArray);

    this.httpClient.get<Profissionais[]>(this.baseUrl + 'profissionais').subscribe(result => {
      this.professionalsDataArray = result;
    }, error => console.error(error));


  }

  navigateToCreateProfessional(): void {
    this.router.navigate(["createProfessional"]);
  }

  

}

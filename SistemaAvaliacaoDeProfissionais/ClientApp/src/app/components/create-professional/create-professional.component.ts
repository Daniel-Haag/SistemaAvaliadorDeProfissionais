import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Cargo } from '../../models/cargo.model';
import { Profissionais } from '../../models/profissionais.model';
import { Setores } from '../../models/setores.model';
import { StatusAvaliacao } from '../../models/statusAvaliacao.model';
import { TipoCargo } from '../../models/tipoCargo.model';

@Component({
  selector: 'app-create-professional',
  templateUrl: './create-professional.component.html',
  styleUrls: ['./create-professional.component.css']
})
export class CreateProfessionalComponent implements OnInit {

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
    //profissionalID: 0,
    admissao: '',
    cargo: this.cargo,
    gestor: false,
    matricula: '',
    nome: '',
    senha: '',
    setor: this.setor,
    statusAvaliacao: this.statusAvaliacao,
    userName: ''
  }

  constructor(private router: Router, private httpClient: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  ngOnInit(): void {
  }

  CadastrarProfissional(): void {

    const httpHeaders = new HttpHeaders();
    httpHeaders.set('Content-Type', 'application/x-www-form-urlencoded');

    this.httpClient.post(this.baseUrl + 'profissionais', this.profissional, { headers: httpHeaders }).subscribe(result => {

    }, error => console.error(error));
  }

  Cancelar(): void {
    this.router.navigate(["registrationsOfProfessionals"])
  }

}

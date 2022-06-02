import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Cargo } from '../../models/cargo.model';
import { Profissionais } from '../../models/profissionais.model';
import { Setores } from '../../models/setores.model';
import { StatusAvaliacao } from '../../models/statusAvaliacao.model';
import { TipoCargo } from '../../models/tipoCargo.model';
import { NotificacoesService } from '../../services/notificacoes.service';

@Component({
  selector: 'app-cadastrar-profissional',
  templateUrl: './cadastrar-profissional.component.html',
  styleUrls: ['./cadastrar-profissional.component.css']
})
export class CreateProfessionalComponent implements OnInit {

  tipoCargo: TipoCargo = {
    tipoCargoID: 1,
    nomeTipoCargo: "teste"
  }

  cargo: Cargo = {
    cargoID: 1,
    nomeCargo: "",
    tipoCargo: this.tipoCargo
  }

  setor: Setores = {
    setorID: 1,
    nomeSetor: ""
  }

  statusAvaliacao: StatusAvaliacao = {
    statusAvaliacaoID: 1,
    nomeStatusAvaliacao: ""
  }

  profissional: Profissionais = {
    //profissionalID: 2,
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

  constructor(private router: Router, private httpClient: HttpClient, @Inject('BASE_URL') private baseUrl: string, private notificacao: NotificacoesService) { }

  ngOnInit(): void {
  }

  CadastrarProfissional(): void {

    const httpHeaders = new HttpHeaders();
    httpHeaders.set('Content-Type', 'application/x-www-form-urlencoded');

    this.httpClient.post(this.baseUrl + 'profissionais', this.profissional, { headers: httpHeaders }).subscribe(result => {
      this.notificacao.Notificacao("Registro efetuado com sucesso!");
      this.router.navigate(["registrationsOfProfessionals"]);

    }, error => console.error(error));
  }

  Cancelar(): void {
    this.router.navigate(["registrationsOfProfessionals"])
  }

}

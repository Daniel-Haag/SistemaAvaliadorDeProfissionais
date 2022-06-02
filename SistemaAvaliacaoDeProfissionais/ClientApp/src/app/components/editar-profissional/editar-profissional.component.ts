import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Cargo } from '../../models/cargo.model';
import { Profissionais } from '../../models/profissionais.model';
import { Setores } from '../../models/setores.model';
import { StatusAvaliacao } from '../../models/statusAvaliacao.model';
import { TipoCargo } from '../../models/tipoCargo.model';
import { NotificacoesService } from '../../services/notificacoes.service';

@Component({
  selector: 'app-editar-profissional',
  templateUrl: './editar-profissional.component.html',
  styleUrls: ['./editar-profissional.component.css']
})
export class EditarProfissionalComponent implements OnInit {

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


  constructor(private router: Router, private httpClient: HttpClient, @Inject('BASE_URL') private baseUrl: string, private notificacao: NotificacoesService, private activeRoute: ActivatedRoute) { }

  ngOnInit(): void {
    var id = this.activeRoute.snapshot.paramMap.get('id');
    if (id !== null) {
      this.httpClient.get<Profissionais>(this.baseUrl + 'profissionais/' + id).subscribe(result => {
        this.profissional = result;
        console.log(this.profissional);
      })
    }
  }

  EditarProfissional(id: number): void {
    this.httpClient.get(this.baseUrl + 'profissionais/' + id).subscribe(result => { //não é get, é update...
      this.notificacao.Notificacao("Registro atualizado com sucesso!");
      this.router.navigate(["registrationsOfProfessionals"]);

    }, error => console.error(error));
  }

  Cancelar(): void {
    this.router.navigate(["registrationsOfProfessionals"]);
  }
}

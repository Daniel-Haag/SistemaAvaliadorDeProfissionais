import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Inject } from '@angular/core';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Profissionais } from '../models/profissionais.model';

@Injectable({
  providedIn: 'root'
})
export class ProfissionaisService {

  constructor(private httpClient: HttpClient,
              @Inject('BASE_URL') private baseUrl: string) { }

  ObterProfissionais(): any {
    this.httpClient.get<Profissionais>(this.baseUrl + 'profissionais').subscribe(result => {
      return result;
    }, error => console.error(error));
  }

  CadastrarProfissional(profissional: Profissionais): void {

    const httpHeaders = new HttpHeaders();
    httpHeaders.set('Content-Type', 'application/x-www-form-urlencoded');

    this.httpClient.post(this.baseUrl + 'profissionais', profissional, { headers: httpHeaders }).subscribe(result => {
      
    }, error => console.error(error));
  }


}

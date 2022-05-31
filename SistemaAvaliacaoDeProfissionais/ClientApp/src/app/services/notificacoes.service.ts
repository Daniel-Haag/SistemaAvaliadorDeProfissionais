import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';

@Injectable({
  providedIn: 'root'
})
export class NotificacoesService {

  constructor(private snackBar: MatSnackBar) { }

  Notificacao(mensagem: string): void {
    this.snackBar.open(mensagem, "OK");
  }


}



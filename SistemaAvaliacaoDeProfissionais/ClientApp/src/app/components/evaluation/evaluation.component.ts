import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
//import { ResultadoAvaliacao } from '../../models/resultadoAvaliacao.model';

@Component({
  selector: 'app-evaluation',
  templateUrl: './evaluation.component.html',
  styleUrls: ['./evaluation.component.css']
})
export class EvaluationComponent implements OnInit {

  //Aqui deve buscar os questionamentos (operacional, tático, estratégico)
  questions: string[] = ["Questao1", "Questao2", "Questao3", "Questao4", "Questao5"];
  options: string[] = ["1", "2", "3", "4", "5"];

  form = new FormGroup({
    Questao1: new FormControl('', Validators.required),
    Questao2: new FormControl('', Validators.required),
    Questao3: new FormControl('', Validators.required),
    Questao4: new FormControl('', Validators.required),
    Questao5: new FormControl('', Validators.required)
  });

  get f() {
    return this.form.controls;
  }

  submit() {
    console.log(this.form.value);
  }


  constructor() { }

  ngOnInit(): void {

  }

  
}

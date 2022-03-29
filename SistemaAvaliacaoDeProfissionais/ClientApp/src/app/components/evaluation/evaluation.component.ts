import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-evaluation',
  templateUrl: './evaluation.component.html',
  styleUrls: ['./evaluation.component.css']
})
export class EvaluationComponent implements OnInit {

  //Aqui deve buscar os questionamentos (operacional, tático, estratégico)
  questions: string[] = ["Questão 1", "Questão 2", "Questão 3"];
  options: string[] = ["1", "2", "3", "4", "5"];

  constructor() { }

  ngOnInit(): void {
    
  }

}

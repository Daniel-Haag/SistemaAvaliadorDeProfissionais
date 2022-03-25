import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-evaluation',
  templateUrl: './evaluation.component.html',
  styleUrls: ['./evaluation.component.css']
})
export class EvaluationComponent implements OnInit {

  itens: string[] = ["daniel", "rodrigues", "lima", "haag"];

  constructor() { }

  ngOnInit(): void {
  }

}

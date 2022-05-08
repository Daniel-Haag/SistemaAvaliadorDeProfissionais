import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create-professional',
  templateUrl: './create-professional.component.html',
  styleUrls: ['./create-professional.component.css']
})
export class CreateProfessionalComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  create(): void {

  }

  cancel(): void {
    this.router.navigate(["registrationsOfProfessionals"])
  }

}

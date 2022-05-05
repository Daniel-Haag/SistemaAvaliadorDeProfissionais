import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-registrations',
  templateUrl: './registrations.component.html',
  styleUrls: ['./registrations.component.css']
})
export class RegistrationsComponent implements OnInit {

  constructor(private router: Router) {

  }

  ngOnInit(): void {
  }

  navigateToProfessionalCreate(): void {
    console.log('Navegando...');
    this.router.navigate(['registrationsOfProfessionals']);
  }

}

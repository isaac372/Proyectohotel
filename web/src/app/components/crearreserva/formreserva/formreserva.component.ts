import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-formreserva',
  templateUrl: './formreserva.component.html',
  styleUrls: ['./formreserva.component.css']
})
export class FormreservaComponent implements OnInit {

  constructor( private route: ActivatedRoute) { }

  ngOnInit(): void {
   console.log( Number(this.route.snapshot.paramMap.get('id')))
  }

}

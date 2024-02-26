import { Component, OnInit } from '@angular/core';
import { Habitacion } from 'src/app/models/Habitacion';
import { ReservationAppService } from 'src/app/services/reservation-app.service';
import { MatDialog } from '@angular/material/dialog';
import { ModalsComponent } from '../modals/modals.component';
import { Reserva } from 'src/app/models/Reserva';
@Component({
  selector: 'app-crearreserva',
  templateUrl: './crearreserva.component.html',
  styleUrls: ['./crearreserva.component.css'],
})
export class CrearreservaComponent implements OnInit {
  habitacions: Habitacion[] = [];
  Reserva = new Reserva();

  constructor(
    private habitacionService: ReservationAppService,
    public dialog: MatDialog
  ) {}

  ngOnInit(): void {
    this.habitacionService.getAllHabitacion().subscribe((result: any) => {
      this.habitacions = result;
    });
    // console.log(this.setreserva());
  }

  openDialog() {
    debugger;

    const dialogRef = this.dialog.open(ModalsComponent);
    dialogRef.afterClosed().subscribe((res) => {
      if (res) {
        this.Reserva.fechaInicio = new Date();
        this.Reserva.fechaFin = new Date();
        this.Reserva.precio = 1000;
        this.Reserva.idCliente = 2;
        this.Reserva.idTipoHabitacion = 1;
        console.log( this.Reserva);
        this.habitacionService
          .createReservation(this.Reserva)
          .subscribe((result: any) => {
            alert('reservado');
          });
      }
      console.log(res);
    });
  }

  // setreserva() {
  //   this.Reserva.fechaInicio = new Date('20240206');
  //   this.Reserva.fechaFin = new Date('202402010');
  //   this.Reserva.precio = 1000;
  //   this.Reserva.idCliente = 2;
  //   this.Reserva.idTipoHabitacion = 1;
  // }
}

import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Reserva } from '../models/Reserva';



const API = 'https://localhost:7066/api/'
@Injectable({
  providedIn: 'root'
})
export class ReservationAppService {
  constructor(private http: HttpClient) {}

  getAllHabitacion() {
      return this.http.get(API+'TipoHabitacion')
  }
  // getHabitacionId(id: number) {
  //   return this.http.get(API + 'restaurant'+ '/'+ id)
  // }
  createReservation(Resevation: Reserva) {
    return this.http.post(API + 'Reserva', Resevation)
  }

  //cancelar reservations
  cancelReservation(reservationCode: string) {
    const options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    }
    return this.http.delete(API + 'deleteReservation?locator='+ reservationCode, options)
  }

}

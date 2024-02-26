import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HederComponent } from './components/heder/heder.component';
import { CrearreservaComponent } from './components/crearreserva/crearreserva.component';
import {MatToolbarModule} from '@angular/material/toolbar';
import { FormreservaComponent } from './components/crearreserva/formreserva/formreserva.component';
import {MatCardModule} from '@angular/material/card';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatSelectModule} from '@angular/material/select';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HttpClientModule} from '@angular/common/http';
import { Routes, RouterModule } from '@angular/router';
import {MatButtonModule} from '@angular/material/button';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { MatNativeDateModule } from '@angular/material/core';
import {MatInputModule} from '@angular/material/input';
import {MatStepperModule} from '@angular/material/stepper';
import {MatSnackBarModule} from '@angular/material/snack-bar';

// import { ReservaComponent } from './services/components/crearreserva/reserva/reserva.component';

import {MatDialogModule} from '@angular/material/dialog';
import { ReservationComponent } from './components/reservation/reservation.component';
import { ModalsComponent } from './components/modals/modals.component';


const appRoutes: Routes = [
  // {path: '', component: ExploreComponent},
   {path: 'reservation/:id', component: ReservationComponent},
  {path: 'FormReserva', component:FormreservaComponent },
  // {path: 'payment', component: PaymentComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    HederComponent,
    CrearreservaComponent,
    FormreservaComponent,
    // ReservaComponent,
    ReservationComponent,
    ModalsComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatCardModule,
    MatFormFieldModule,
    MatDatepickerModule,
    MatSelectModule,
    NgbModule,
    HttpClientModule,
    MatButtonModule,
    ReactiveFormsModule,
    FormsModule ,
    MatNativeDateModule,
    MatInputModule,
    MatStepperModule,
    MatDialogModule,
    MatSnackBarModule,

    RouterModule.forRoot(
      appRoutes
    ),
  ],
  entryComponents:[ModalsComponent],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

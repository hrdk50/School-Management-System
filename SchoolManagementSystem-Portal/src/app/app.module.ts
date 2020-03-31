import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {ReactiveFormsModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FeesComponent } from './fees/fees.component';
import { AdmissionComponent } from './admission/admission.component';
import { GuardianComponent } from './guardian/guardian.component';
import { OldStudentComponent } from './old-student/old-student.component';
import { HttpClientModule, HttpClient } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    FeesComponent,
    AdmissionComponent,
    GuardianComponent,
    OldStudentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

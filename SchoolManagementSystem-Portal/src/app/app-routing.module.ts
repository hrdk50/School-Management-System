import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FeesComponent } from './fees/fees.component';
import { AdmissionComponent } from './admission/admission.component';
import { GuardianComponent } from './guardian/guardian.component';
import { OldStudentComponent } from './old-student/old-student.component';


const routes: Routes = [
  {path:'' , component: AdmissionComponent},
  {path:'fees', component: FeesComponent},
  {path:'guardian', component: GuardianComponent},
  {path:'oldstudent', component: OldStudentComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

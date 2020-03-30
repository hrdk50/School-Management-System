import { Component, OnInit } from '@angular/core';
import { FormGroup,FormBuilder,Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admission',
  templateUrl: './admission.component.html',
  styleUrls: ['./admission.component.css']
})
export class AdmissionComponent implements OnInit {
  addmissionFormGroup : FormGroup;
  constructor(private formBuilder : FormBuilder, private router : Router) { }

  ngOnInit(): void {
    this.addmissionFormGroup = this.formBuilder.group({
      studentName : ['',Validators.required],
      gender : ['',Validators.required],
      birthDate : ['',Validators.required],
      bloodGroup : ['',Validators.required],
      height : ['',Validators.required],
      weight : ['',Validators.required],
      standard : ['',Validators.required]
    })
  }

  onSubmit(){
    console.log(this.addmissionFormGroup.value);
    alert("You fill the admission form successfully");
    this.router.navigateByUrl("/guardian");
  }

}

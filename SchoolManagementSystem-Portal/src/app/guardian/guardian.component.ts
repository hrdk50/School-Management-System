import { Component, OnInit } from '@angular/core';
import { FormGroup,FormBuilder,Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-guardian',
  templateUrl: './guardian.component.html',
  styleUrls: ['./guardian.component.css']
})
export class GuardianComponent implements OnInit {
  guardianFormGroup : FormGroup;
  constructor(private formBuilder : FormBuilder, private router : Router) { }

  ngOnInit(): void {
    this.guardianFormGroup = this.formBuilder.group({
      fatherName : ['',Validators.required],
      motherName : ['',Validators.required],
      fatherOccupation : ['',Validators.required],
      fatherSalary : ['',Validators.required],
      motherOccupation : ['',Validators.required],
      motherSalary : ['',Validators.required],
      sibling : ['',Validators.required],
      emailId : ['',Validators.required],
      phoneNumber : [''],
      mobileNumber : ['',Validators.required],
      address : ['',Validators.required],
      pinCode : ['',Validators.required]
    })
  }

  onSubmit(){
    console.log(this.guardianFormGroup.value);
    alert("You fill the Guardian form successfully");
    this.router.navigateByUrl("/fees");
  }

}

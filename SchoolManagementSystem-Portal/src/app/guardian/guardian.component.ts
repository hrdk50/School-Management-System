import { Component, OnInit } from '@angular/core';
import { FormGroup,FormBuilder,Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-guardian',
  templateUrl: './guardian.component.html',
  styleUrls: ['./guardian.component.css']
})
export class GuardianComponent implements OnInit {
  guardianFormGroup : FormGroup;
  readonly rootURL = 'http://localhost:58589/api';
  result:any;
  constructor(private formBuilder : FormBuilder, private router : Router,private httpService: HttpClient) { }

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

    this.httpService.post(this.rootURL+'/guardians',{FatherName:this.guardianFormGroup.value.fatherName,MotherName:this.guardianFormGroup.value.motherName,FatherOccupation:this.guardianFormGroup.value.fatherOccupation,FatherSalary:this.guardianFormGroup.value.fatherSalary,MotherOccupation:this.guardianFormGroup.value.motherOccupation,MotherSalary:this.guardianFormGroup.value.motherSalary,SiblingName:this.guardianFormGroup.value.SiblingName,EmailId:this.guardianFormGroup.value.emailId,Address:this.guardianFormGroup.value.address,PinCode:this.guardianFormGroup.value.pinCode,PhoneNumber:this.guardianFormGroup.value.phoneNumber,MobileNumber:this.guardianFormGroup.value.mobileNumber,StudentId:1}).subscribe(res=>{
      this.result=res;
      console.log(this.result);
    })

   this.router.navigateByUrl("/fees");
  }

}

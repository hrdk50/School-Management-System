import { Component, OnInit } from '@angular/core';
import { FormGroup,FormBuilder,Validators } from '@angular/forms';
import { Router } from '@angular/router';
import {  HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-admission',
  templateUrl: './admission.component.html',
  styleUrls: ['./admission.component.css']
})
export class AdmissionComponent implements OnInit {
  admissionFormGroup : FormGroup;
  result:any;
  readonly rootURL = 'http://localhost:58589/api';

  constructor(private formBuilder : FormBuilder, private router : Router,private httpService: HttpClient) { }

  ngOnInit(): void {
    this.admissionFormGroup = this.formBuilder.group({
      studentName : ['',Validators.required],
      gender : ['',Validators.required],
      birthDate : ['',Validators.required],
      bloodGroup : ['',Validators.required],
      height : ['',Validators.required],
      weight : ['',Validators.required],
      standard : ['',Validators.required]
    })

  //   this.httpService.get<any>('http://localhost:58589/api/students').subscribe(res=>{
  //   this.result=res;
  //   console.log(this.result);
  //   this.enquiryList=this.result;
  // })


  }

  onSubmit(){
    console.log(this.admissionFormGroup.value);
    alert("You fill the admission form successfully");

    this.httpService.post(this.rootURL+'/admissionforms',{StudentName:this.admissionFormGroup.value.studentName,BirthDate:this.admissionFormGroup.value.birthDate,ResultStatus:1,StudentTypeId:1,StandardId:1,Gender:this.admissionFormGroup.value.gender,BloodGroup:this.admissionFormGroup.value.bloodGroup,Height:this.admissionFormGroup.value.height,Weight:this.admissionFormGroup.value.weight,StudentId:2}).subscribe(res=>{
      this.result=res;
      console.log(this.result);
    })

  this.router.navigateByUrl("/guardian");
  
}

}

import { Component, OnInit } from '@angular/core';
import { FormBuilder,FormGroup,Validators } from '@angular/forms';
import {  HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fees',
  templateUrl: './fees.component.html',
  styleUrls: ['./fees.component.css']
})
export class FeesComponent implements OnInit {
  feesFormGroup : FormGroup;
  result:any;
  readonly rootURL = 'http://localhost:58589/api';
  constructor(private formBuilder : FormBuilder,private httpService: HttpClient) { }

  firstInstallment = {
    display : 'none'
  }

  secondInstallment = {
    display : 'none'
  }

  fourthInstallment = {
    display : 'none'
  }

  ngOnInit(): void {
    this.feesFormGroup = this.formBuilder.group({
      studentId : ['',Validators.required],
      installment : ['',Validators.required]
    })
  }

  onSubmit(){
    console.log(this.feesFormGroup.value);
     console.log(this.feesFormGroup.controls.installment.value);

    this.httpService.post(this.rootURL+'/fees',{Amount:this.feesFormGroup.value.installment,StudentId:this.feesFormGroup.value.studentId,InstallmentId:1}).subscribe(res=>{
      this.result=res;
      console.log(this.result);
    })
  }

}

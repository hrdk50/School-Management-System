import { Component, OnInit } from '@angular/core';
import { FormGroup,FormBuilder,Validators } from '@angular/forms';
import { Router } from '@angular/router';
import {  HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-old-student',
  templateUrl: './old-student.component.html',
  styleUrls: ['./old-student.component.css']
})
export class OldStudentComponent implements OnInit {
  oldStudentFormGroup : FormGroup;
  result:any;
  readonly rootURL = 'http://localhost:58589/api';
  constructor(private formBuilder : FormBuilder, private router : Router,private httpService: HttpClient) { }

  ngOnInit(): void {
    this.oldStudentFormGroup = this.formBuilder.group({
      studentId : ['',Validators.required],
      studentName : ['',Validators.required],
      standard : ['',Validators.required]
    })
  }

  onSubmit(){
    console.log(this.oldStudentFormGroup.value);
    alert("You fill the admission form successfully");
    
      this.httpService.get<any>('http://localhost:58589/api/admissionforms').subscribe(res=>{
    this.result=res;
    console.log(this.result);
    // this.enquiryList=this.result;
  })

    this.router.navigateByUrl("/fees");


  }

}

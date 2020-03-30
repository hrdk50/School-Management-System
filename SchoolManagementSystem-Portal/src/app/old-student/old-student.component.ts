import { Component, OnInit } from '@angular/core';
import { FormGroup,FormBuilder,Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-old-student',
  templateUrl: './old-student.component.html',
  styleUrls: ['./old-student.component.css']
})
export class OldStudentComponent implements OnInit {
  oldStudentFormGroup : FormGroup;
  constructor(private formBuilder : FormBuilder, private router : Router) { }

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
    this.router.navigateByUrl("/fees");
  }

}

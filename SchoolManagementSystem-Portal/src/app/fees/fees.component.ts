import { Component, OnInit } from '@angular/core';
import { FormBuilder,FormGroup,Validators } from '@angular/forms';

@Component({
  selector: 'app-fees',
  templateUrl: './fees.component.html',
  styleUrls: ['./fees.component.css']
})
export class FeesComponent implements OnInit {
  feesFormGroup : FormGroup;
  constructor(private formBuilder : FormBuilder) { }

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
      installment : ['',Validators.required]
    })
  }

  onSubmit(){
    console.log(this.feesFormGroup.value);
    // console.log(this.feesFormGroup.controls.installment.value);
  }

}

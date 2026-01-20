import { Component } from '@angular/core';
import { Cal } from '../../models/cal';
import { Calserve } from '../../repository/calserve';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-calci',
  imports: [FormsModule],
  templateUrl: './calci.html',
  styleUrl: './calci.css',
})
export class Calci {
  data:Cal ={
    num1:0,
    num2:0,
    result:0
  }
  

  constructor(private calcService: Calserve) {}

  add() {
    this.data.result = this.calcService.add(this.data.num1, this.data.num2);
  }

  sub() {
    this.data.result = this.calcService.sub(this.data.num1, this.data.num2);
  }

  multiply() {
    this.data.result = this.calcService.multiply(this.data.num1, this.data.num2);
  }

  division() {
    this.data.result = this.calcService.division(this.data.num1, this.data.num2);
  }

  modulo(){
    this.data.result=this.calcService.modulo(this.data.num1,this.data.num2);
  }

  power(){
    this.data.result=this.calcService.power(this.data.num1,this.data.num2);
  }
}

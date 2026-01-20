import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class Calserve {
    add(a:number,b:number): number{
      return a+b;
    }
    sub(a:number,b:number): number{
      return a-b;
    }
    multiply(a:number,b:number): number{
      return a*b;
    }
    division(a:number,b:number): number{
      return a/b;
    }
    modulo(a:number,b:number):number{
      return a%b
    }
    power(a:number,b:number):number{
      return a**b
    }
}

import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class MessageService {
   private data=[
    "Hi","Hello","Good Morning", "Good Night"
   ]
   getData(){
     return this.data;
   }
   addData(s:string){
      this.data.push(s);
   }
}

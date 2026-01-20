import { Component } from '@angular/core';
import { MessageService } from '../../repository/services/message-service';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-messages',
  imports: [FormsModule],
  templateUrl: './messages.html',
  styleUrl: './messages.css',
})
export class Messages {
    m='';
    strings:string[]=[];
    constructor(private message:MessageService){}
    getData(){
      this.strings=[...this.message.getData()];
    }
    add(m:string){
       this.message.addData(m);
       this.strings=[...this.message.getData()];
    }
}

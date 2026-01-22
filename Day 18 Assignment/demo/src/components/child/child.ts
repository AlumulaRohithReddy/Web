import { Component, Input, output } from '@angular/core';

@Component({
  selector: 'app-child',
  imports: [],
  templateUrl: './child.html',
  styleUrl: './child.css',
})
export class Child {
  @Input() messagefromparent: string="";
  add=output<string>();
  adddata(){
    this.add.emit("data from child");
  };
}

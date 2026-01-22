import { Component, EventEmitter, Input, Output, } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-products',
  imports: [ FormsModule],
  templateUrl: './products.html',
  styleUrl: './products.css',
})
export class Products {
  @Input() product: string="";
  @Input() star:number=0;
  productRating: number = 0;
  @Output() ratingEvent = new EventEmitter<number>();

  rating = 0;
  stars = [1, 2, 3, 4, 5];
  ratings=[0,0,0]
  rate(value: number, index: number) {
    this.rating = value;
    this.ratingEvent.emit(this.ratings[index]=value);
  }
}

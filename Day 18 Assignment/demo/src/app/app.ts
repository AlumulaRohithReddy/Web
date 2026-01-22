import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Child } from '../components/child/child';
import { Products } from '../components/products/products';
@Component({
  selector: 'app-root',
  imports: [RouterOutlet,Child,Products],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('demo');
  datafromchild:any;
  adddatafromchild(data:any){
    this.datafromchild=data;
    console.log(this.datafromchild)
  }
  productRating: number = 0;

  products = [
    { name: 'One Plus 10T', rating: 0 },
    { name: 'Samsung S22', rating: 0 },
    { name: 'Iphone 13 Pro Max', rating: 0 },
  ];

  receiveRating(index: number, rating: number) {
    this.products[index].rating = rating;
    console.log(this.products);
  }
}

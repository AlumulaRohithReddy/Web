import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Calci } from '../components/calci/calci';
import { Messages } from '../components/messages/messages';
@Component({
  selector: 'app-root',
  imports: [RouterOutlet,Calci,Messages],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('calculator-app');
}

import { Component, signal ,OnInit} from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ListEmployees } from '../employees/list-employees';
import { Employee } from './models/employee.model';
@Component({
  selector: 'app-root',
  imports: [RouterOutlet,ListEmployees],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit{
  protected readonly title = signal('Demo');
  employees: Employee[] = [
 {
 id: 1,
 name: 'Mark',
 gender: 'Male',
 contactPreference: 'Email',
 email: 'mark@pragimtech.com',
 dateOfBirth: new Date('10/25/1988'),
 department: 'IT',
 isActive: true,
 photoPath: './John.jpg'
 },
 {
 id: 2,
 name: 'Mary',
 gender: 'Female',
 contactPreference: 'Phone',
 phoneNumber: 2345978640,
 dateOfBirth: new Date('11/20/1979'),
 department: 'HR',
 isActive: true,
 photoPath: './Mary.avif'
 },
 {
 id: 3,
 name: 'John',
 gender: 'Male',
 contactPreference: 'Phone',
 dateOfBirth: new Date('3/25/1976'),
 department: 'IT',
 isActive: false,
 photoPath: './Mark.jpg'
 },
 ];
 constructor(){

 }
 ngOnInit() {
     
 }
}

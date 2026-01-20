import { Component, OnInit } from '@angular/core';
import { Customer } from '../../models/customer';
import { CustomerRepository } from '../../services/repository/customer-repository';
@Component({
 selector: 'app-customer-list',
 imports: [],
 templateUrl: './customer-list.html',
 styleUrl: './customer-list.css',
})
export class CustomerList implements OnInit {
 customers: Customer[] = [];
 constructor(private customerRepo: CustomerRepository) { }
 ngOnInit(): void {
 this.customers = this.customerRepo.getCustomers();
 }
} 
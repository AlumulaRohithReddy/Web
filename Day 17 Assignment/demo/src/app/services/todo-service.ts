import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root',
})
export class TodoService {
  constructor(private http:HttpClient){}
  getdata(){
    return this.http.get("http://localhost:3000/users");
  }
  getdatabyId(id:number){
    return this.http.get(`http://localhost:3000/users/${id}`)
  }
  adddata(data:object){
    return this.http.post("http://localhost:3000/users", data);
  }
  deleteuser(id:any){
    return this.http.delete(`http://localhost:3000/users/${id}`)
  }
  update(data:object,id:any){
    return this.http.put(`http://localhost:3000/users/${id}`,data);
  }
}

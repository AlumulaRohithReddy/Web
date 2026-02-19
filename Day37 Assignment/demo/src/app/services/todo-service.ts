import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root',
})
export class TodoService {
  constructor(private http:HttpClient){}
  getdata(){
    return this.http.get("https://localhost:7171/api/Users");
  }
  
  getdatabyId(id:number){
    return this.http.get(`https://localhost:7171/api/Users/${id}`)
  }
  adddata(data:object){
    return this.http.post("https://localhost:7171/api/Users", data);
  }
  deleteuser(id:any){
    return this.http.delete(`https://localhost:7171/api/Users/${id}`)
  }
  update(id:any,data:object){
    return this.http.put(`https://localhost:7171/api/Users/${id}`,data);
  }
}

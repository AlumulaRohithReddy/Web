import { ChangeDetectorRef, Component,OnInit } from '@angular/core';
import { TodoService } from '../../services/todo-service';
import { Post } from '../../../models/post';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-todo-component',
  imports: [FormsModule],
  templateUrl: './todo-component.html',
  styleUrl: './todo-component.css',
})
export class TodoComponent implements OnInit{
    users:any=[]
    user:any={}
    data: Post = {
  name: '',
  email: '',
  age: 0,
  role: '',
  isActive: true
};

    constructor(private todo:TodoService,private c:ChangeDetectorRef){}
    
    ngOnInit(): void {
        this.todo.getdata().subscribe(r=>{
          this.users=r;
          console.log(this.users)
        })
        // this.todo.getdatabyId(2).subscribe(r=>{
        //   this.user=r;
        //   console.log(this.user)
        // })
      }
      saveUser() {
  if (this.data.id) {
    this.todo.update(this.data, this.data.id).subscribe((res:any) => {
      const index = this.users.findIndex((u:Post) => u.id === res.id);
      if (index !== -1) {
        this.users[index] = res;
      }
      this.resetForm();
      this.c.detectChanges()
    });
    
  } else {
    this.todo.adddata(this.data).subscribe((res) => {
      this.users = [...this.users, res];
      this.resetForm();
      this.c.detectChanges()
    });
  }
  
}

     resetForm() {
  this.data = {
    name: '',
    email: '',
    age: 0,
    role: '',
    isActive: true
  };
}
      delete(id:any){
          this.todo.deleteuser(id).subscribe(()=> this.todo.getdata());
          this.users=this.users.filter((x:any)=>x.id!==id);
          console.log(id)
          this.c.detectChanges()
      } 

    editUser(user: Post) {
      this.data = { ...user };
    }

}


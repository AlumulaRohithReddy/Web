
let res;
async function poldata() {
    try{
    let d= await fetch("https://696630fdf6de16bde44c81db.mockapi.io/api/policies/policydata")
    res= await d.json()
    console.log(res)
    } catch(e){
        console.log("error"+e)
    }
    filtertype()

}
poldata()
function  filtertype(){
    let con=document.getElementById('policies')
    let t=document.getElementById('type').value
    if (t==='All'){
    con.innerHTML = res.map(x => `<li style="list-style-type:none;width:300px;border:2px solid black;
        border-radius:10px;text-align:center;margin:10px;">
        <h1 class="id">Policy Id : ${x.id} </h1>
        <h3>Policy Name : ${x.name} </h3>
        <h2>Policy Type : ${x.type}</h2>
        <p>Premium Amount : ${x.premium}</p> 
        <p>Duration : ${x.duration} </p>
        <p>Status : ${x.status}</p>
        <button class="bg-yellow-400 w-36 mr-30 rounded-2xl" onClick="Delete(${x.id})" type="button">Delete</button></li>`
    ).join("")
    }
    else{
    let temp=res.filter((x) => x.type===t)
    con.innerHTML = temp.map(x=>`<li style="list-style-type:none;
        width:300px;border:2px solid black;border-radius:10px;
        text-align:center;margin:10px;">
        <h1 class="id">Policy Id : ${x.id} </h1>
        <h3>Policy Name : ${x.name} </h3>
        <h2>Policy Type : ${x.type}</h2>
        <p>Premium Amount : ${x.premium} </p>
         <p>Duration : ${x.duration} </p>
         <p>Status : ${x.status}</p>
         <button class="bg-yellow-400 w-26 mr-30 rounded-2xl" type="button" onClick="Delete(${x.id})" >Delete</button></li>`
    ).join("");
    }
    
}
let ft=document.getElementById('type')
ft.addEventListener('change',filtertype)




let form=document.getElementById('form')
form.addEventListener('submit',async function (e){
    e.preventDefault();
    const pname = document.getElementById("name").value.trim();
    const PolicyT = document.getElementById("policy").value;
    const duration = document.getElementById("duration").value.trim();
    const pamount = document.getElementById("number").value.trim();
    const statusp = document.getElementById("status").value;
    let newpol={
        name:pname,
        type:PolicyT,
        duration:duration,
        premium:pamount,
        status:statusp
    }
    try {
    let resp= await fetch("https://696630fdf6de16bde44c81db.mockapi.io/api/policies/policydata", {
    method: "POST",
    headers: {
    "Content-Type": "application/json"
    },
    body: JSON.stringify(newpol)
    });
    let data = await resp.json();
    console.log("Saved:", data);
    poldata();
    form.reset();
    }
    catch (err) {
        console.log("POST error:", err);
    }
    })

let p=document.getElementById("ID")
p.addEventListener('blur',async function(e){
    e.preventDefault();
    const pname = document.getElementById("namep")
    const duration = document.getElementById("durationp")
    const pamount = document.getElementById("numberp")
    const statusp = document.getElementById("statusp")
    try{
    let d= await fetch(`https://696630fdf6de16bde44c81db.mockapi.io/api/policies/policydata/${this.value}`)
    res= await d.json()
    pname.value=res.name
    duration.value=res.duration
    pamount.value=res.premium
    statusp.value=res.status
    } catch(e){
        console.log("error"+e)
    }
})

let form1=document.getElementById('form1')
form1.addEventListener('submit',async function (e){
    e.preventDefault();
    const pname = document.getElementById("namep").value.trim();
    const duration = document.getElementById("durationp").value.trim();
    const pamount = document.getElementById("numberp").value.trim();
    const statusp = document.getElementById("statusp").value;
    let p=document.getElementById("ID")
    let d= await fetch(`https://696630fdf6de16bde44c81db.mockapi.io/api/policies/policydata/${p.value}`)
    res= await d.json()
    let newpol={
        name:pname,
        type:res.type,
        duration:duration,
        premium:pamount,
        status:statusp
    }
    try {
    let resp= await fetch(`https://696630fdf6de16bde44c81db.mockapi.io/api/policies/policydata/${p.value}`, {
    method: "PUT",
    headers: {
    "Content-Type": "application/json"
    },
    body: JSON.stringify(newpol)
    });
    let data = await resp.json();
    console.log("Saved:", data);
    poldata();
    form.reset();
    }
    catch (err) {
        console.log("POST error:", err);
    }
    })

async function Delete(x){
    let resp= await fetch(`https://696630fdf6de16bde44c81db.mockapi.io/api/policies/policydata/${x}`, {
    method: "DELETE"
    });
    let data =await resp.json();
    console.log("Saved:", data);
    poldata()
}

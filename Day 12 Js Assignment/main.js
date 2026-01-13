// Task 1
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
    diconpre()
    submitPol(res[0].id, function(stat){
        console.log(stat);
    });
    
}
poldata()
// Task 2
function  filtertype(){
    let con=document.getElementById('policies')
    let t=document.getElementById('type').value
    if (t==='All'){
    con.innerHTML = res.map(x => `<li style="list-style-type:none;width:300px;border:2px solid black;
        border-radius:10px;text-align:center;margin:10px;">
        <h3>Policy Name : ${x.name} </h3>
        <h2>Policy Type : ${x.type}</h2>
        <p>Premium Amount : ${x.premium}</p> 
        <p>Duration : ${x.duration} </p>
        <p>Status : ${x.status}</p></li>`
    ).join("")
    tp(res)
    }
    else{
    let temp=res.filter((x) => x.type===t)
    con.innerHTML = temp.map(x=>`<li style="list-style-type:none;
        width:300px;border:2px solid black;border-radius:10px;
        text-align:center;margin:10px;">
        <h3>Policy Name : ${x.name} </h3>
        <h2>Policy Type : ${x.type}</h2>
        <p>Premium Amount : ${x.premium} </p>
         <p>Duration : ${x.duration} </p>
         <p>Status : ${x.status}</p></li>`
    ).join("");
    tp(temp)
    }
    
}

// Task 3
let ft=document.getElementById('type')
ft.addEventListener('change',filtertype)

// Task 4

function tp(res){
    let c=document.getElementById('main')
    let tpc=res.filter((x) => x.status==='Active').reduce((s, c) => s + c.premium, 0)
    c.textContent=`Total premium of active policies is ${tpc}`;
}

// Task 5 
function diconpre(){
    let c=res.map(y=> {
        if (y.premium>10000){
        return {
        ...y,
        premium:y.premium-y.premium*0.1}}
    else{
        return y
    }});
    console.log(c)
}

// Task 6 

function submitPol(policyId, displayres) {
    console.log(`Policy Submitted, ${policyId}`);
    console.log("under verification");
    setTimeout(() => {
        let check=policyId <=res.length? true: false 
        if (check) {
            displayres(`${policyId} Approved`);
        } else {
            displayres(`${policyId} Rejected`);
        }

    }, 2000);
}
submitPol(5, function(stat){
        console.log(stat);
    });
// Task 7

function submitPolPromise(policyId) {
    console.log(`Policy Submitted, ${policyId}`);
    return new Promise((res,rej)=>{
    console.log("under verification");
    setTimeout(() => {
        let check=policyId <=res.length? true: false 
        if (check) {
            res(`${policyId} Approved`);
        } else {
            rej(`${policyId} Rejected`);
        }
    }, 2000);})
}

submitPolPromise(1).then(r=> console.log(r)).catch(e=>console.log(e))

submitPolPromise(5).then(r=> console.log(r)).catch(e=>console.log(e))


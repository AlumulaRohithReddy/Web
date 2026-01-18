let accts = []
function createacc(user) {
    let balance = user.balance
    let transactions=user.transactions 
    const minibal = 5000;
    const penal = 200;
    return {
        get() {
            return { ...user, balance ,transactions}
        },
        depos(amt) {
            if (amt <= 0) return false
            balance += amt
            transactions.push({
                created:new Date(),
                type:"deposit",
                amount:amt
            })
            return true
        },
        withdraw(amt) {
            if (amt <= 0 || amt > balance) return false
            balance -= amt
            transactions.push({
                created:new Date(),
                type:"withdraw",
                amount:amt
            })
            if (balance < minibal) {
                balance -= penal;
                transactions.push({
                    created: new Date(),
                    type: "penalty",
                    amount: penal
                });
                return {
                    success: true,
                    penalty: true
                };
            }
            return { success: true, penalty: false };
        }
    };
}

function save() {
    const data = accts.map(a => a.get()); 
    localStorage.setItem('accounts', JSON.stringify(data));
}
function load() {
    const rawdata = localStorage.getItem("accounts");
    if (!rawdata) return false;
    const data = JSON.parse(rawdata);
    accts = data.map(user => createacc(user));
    return true;
}

function showload() {
    document.getElementById("loader").classList.remove("hidden");
}

function hideload() {
    document.getElementById("loader").classList.add("hidden");
}
async function userdata() {
    showload();
    if (load()) {
        displaydetials(accts.map(a => a.get()));
        hideload();
        return;
    }
    try {
        let d = await fetch("https://696630fdf6de16bde44c81db.mockapi.io/api/userdetails")
        let res = await d.json()
        accts = [];
        for (let u of res) {
            let user = {
                id: u.id,
                accountnumber: u.accountnumber,
                name: u.name,
                email: u.email,
                branch: u.address.city,
                balance: 25000,
                transactions:[]
            };
            accts.push(createacc(user))
            save()
        }
    } catch (e) {
        console.log("error " + e);
    }
    const data = accts.map(a => a.get())
    displaydetials(data)
    totalBalance()
    hideload();
}
userdata()
function displaydetials(data){
    let con=document.getElementById('accounts')
    con.innerHTML = data.map(x => 
        `<li class="
    list-none w-[350px] border-2 rounded-xl m-3 p-3
    ${x.balance < 5000 ? 'border-red-400 bg-red-100' : 'border-black'}"><div class='flex justify-between'><h2 class="id"><b>Account Number</b> : ${x.accountnumber} </h2>
        <a href="#history"><button class="bg-yellow-400 w-36 mr-30 rounded-2xl" onclick="history(${x.id})" type="button">View History</button></a>
        </div>
        <h3><b>Account Holder Name</b> : ${x.name} </h3>
        <h2><b>Email ID</b>: ${x.email}</h2>
        <p><b>Branch</b> : ${x.branch}</p> 
        <p><b>Account Balance</b> : ${x.balance} </p>
        <div class="flex flex-row justify-between">
        <button class="bg-yellow-400 w-20 mr-30 rounded-2xl" onclick="depo(${x.id})" type="button">Deposit</button>
        <button class="bg-yellow-400 w-20 mr-30 rounded-2xl" onclick="withdraw(${x.id})" type="button">Withdraw</button>
        <button class="bg-yellow-400 w-20 mr-30 rounded-2xl" onclick="Delete(${x.id})" type="button">Delete</button></div></li>`
    ).join("")
}

let s = document.getElementById('search');

s.addEventListener('input', function () {
    let st = s.value.toLowerCase();
    let sb = ft.value;
    let data = accts.map(a => a.get());

    let filtered = data.filter(acc => {
        let branchMatch =
            sb === "All" || acc.branch === sb;
        let searchMatch =
            acc.name.toLowerCase().includes(st);

        return branchMatch && searchMatch;
    });

    displaydetials(filtered);
    totalBalance()
});



function filtertype() {
    let t = document.getElementById('branch').value
    let data = accts.map(a => a.get())

    if (t === 'All') {
        displaydetials(data)
        totalBalance()
    } else {
        let filtered = data.filter(x => x.branch === t)
        displaydetials(filtered)
        totalBalance()
    }
}
let ft=document.getElementById('branch')
ft.addEventListener('change',filtertype)

let form=document.getElementById('form')
form.addEventListener('submit', async function (e) {
    e.preventDefault();
    const name = document.getElementById("name").value.trim();
    const email = document.getElementById("email").value;
    const branch = document.getElementById("branch1").value.trim();
    let newacc = {
        accountnumber: 1000 + accts.length + 1,
        name,
        email,
        address: {
            city: branch
        }
    };
    try {
        let resp = await fetch(
            "https://696630fdf6de16bde44c81db.mockapi.io/api/userdetails",
            {
                method: "POST",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify(newacc)
            }
        );
        let data = await resp.json();
        let user = {
            id: data.id,
            accountnumber: newacc.accountnumber,
            name,
            email,
            branch: newacc.address.city,
            balance: 25000,
            transactions:[]
        };
        accts.push(createacc(user));
        save()
        console.log("Saved:", data);
        const dat = accts.map(a => a.get())
        displaydetials(dat)
        totalBalance()
        form.reset();
    }
    catch (err) {
        console.log("POST error:", err);
    }
});
async function Delete(id) {
    await fetch(
        `https://696630fdf6de16bde44c81db.mockapi.io/api/userdetails/${id}`,
        { method: "DELETE" }
    );
    
    accts = accts.filter(a => a.get().id != id);
    save()
    const data = accts.map(a => a.get())
    displaydetials(data)
    totalBalance()
}

function depo(x){
    let amt = Number(prompt("Enter amount"));
    if (!amt || amt <= 0) {
        alert("Invalid amount");
        return;
    }
    let acc = accts.find(a => a.get().id == x);
    acc.depos(amt);
     save()
    alert("Amount Deposited successfully");
    const data = accts.map(a => a.get())
    displaydetials(data)
    totalBalance()
}


function withdraw(x){
    let amt = Number(prompt("Enter amount to withdraw"))
    if (!amt || amt <= 0) {
        alert("Invalid amount")
        return
    }
    let acc = accts.find(a => a.get().id == x)
    let res = acc.withdraw(amt);
    save()
    if (!res.success) {
        alert("Insufficient Balance");
        return;
    }

    if (res.penalty) {
        alert("Minimum balance breached!₹200 penalty.");
    }
    const data = accts.map(a => a.get())
    displaydetials(data)
    totalBalance()
}
function history(id) {
    let acc = accts.find(a => a.get().id == id)
    if (!acc) {
        alert("Account not found");
        return;
    }
    let { transactions } = acc.get();
    let body = document.getElementById("historycon");
    let section = document.getElementById("history");
    if (!transactions.length) {
        body.innerHTML = `
            <tr>
              <td colspan="3" class="p-4 text-gray-600">
                No transactions available
              </td>
            </tr>`;
    } else {
        body.innerHTML = transactions.map(t => `
            <tr>
              <td class="border p-2">${new Date(t.created).toLocaleString()}</td>
              <td class="border p-2 capitalize">${t.type}</td>
              <td class="border p-2">${t.amount}</td>
            </tr>
        `).join("");
    }

    section.classList.remove("hidden");
    section.scrollIntoView({ behavior: "smooth" });
}
let bal = document.getElementById("bal");

bal.addEventListener("change", function () {
    let value = bal.value;
    let st = s.value.toLowerCase();
    let sb = ft.value;
    let data = accts.map(a => a.get());

    let filtered = data.filter(acc => {
        let branchMatch =
            sb === "All" || acc.branch === sb;
        let searchMatch =
            acc.name.toLowerCase().includes(st);

        return branchMatch && searchMatch;
    });
    if (value === "High") {
        filtered.sort((a, b) => b.balance - a.balance);
        displaydetials(filtered);
        totalBalance();
    } 
    else if (value === "Low") {
        filtered.sort((a, b) => a.balance - b.balance);
        displaydetials(filtered);
        totalBalance();
    }else{
        displaydetials(filtered);
        totalBalance();
    }

   
});


function totalBalance() {
    const total = accts
        .map(a => a.get())
        .reduce((sum, acc) => sum + acc.balance, 0);
    document.getElementById("total").innerText =
        `Bank Balance: ₹${total}`;
}
totalBalance()
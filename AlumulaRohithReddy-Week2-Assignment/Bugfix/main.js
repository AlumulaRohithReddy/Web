const customers = [
 { id: 1, name: "Ravi", age: 32, policy: "Health", premium: 4800, active: true },
 { id: 2, name: "Anita", age: 51, policy: "Life", premium: 12000, active: true },
 { id: 3, name: "Kiran", age: 28, policy: "Vehicle", premium: 3500, active: false },
 { id: 4, name: "Meena", age: 45, policy: "Health", premium: 6000, active: true },
 { id: 5, name: "Suresh", age: 60, policy: "Life", premium: 18000, active: false }
]; 

// Bug 1
for (let i = 0; i < customers.length; i++) {
 console.log(customers[i].name);
}

// Bug 2
const activeCustomers = customers.filter((c) => {
 return c.active === true;
});
console.log(activeCustomers)

// Bug 3
const updatedPremiums = customers.map((c) => {
 if (c.age >= 50) {
  return { 
      ...c, 
      premium: c.premium * 1.1 
    };
  }
  return c;
}); 

console.log(updatedPremiums)

//Bug 4
const totalPremium = customers.reduce((total, c) => {
 return total + c.premium;
}, 0); 
console.log(totalPremium)

//Bug 5
console.log(`Customer ${customers[0].name} has policy ${customers[0].policy}`);

//Bug 6
const policyCount = customers.reduce((count, c) => {
 count[c.policy] = (count[c.policy] || 0) + 1;
 return count;
}, {}); 
console.log(policyCount)

//Bug 7 
const customersWithRisk = customers.map((c) => {
 let riskLevel;
 if (c.age < 35) riskLevel = "Low";
 else if (c.age <= 50) riskLevel = "Medium";
 else riskLevel = "High";
 return { ...c, riskLevel };
});
console.log(customersWithRisk)

//Bug 8
let active = 0,inactive = 0;
for (const c of customers) {
 if (c.active) active++;
 else inactive++;
}
console.log(active,inactive)

//Bug 9
const getLifeCustomers = () =>{
 return customers.filter((c) => c.policy === "Life").map((c) =>
c.name); }
console.log(getLifeCustomers())

//Bug 10 
const sortedCustomers = [...customers].sort((a, b) => b.premium - a.premium);
console.log(customers)

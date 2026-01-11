const plans = [
  { name: "Health", base: 6000, cover: "10L" },
  { name: "Life", base: 7000, cover: "20L" },
  { name: "Vehicle", base: 4000, cover: "5L" }
];

const customers = [];

const planscon = document.getElementById("plans");
const form = document.getElementById("form");
const coverage = document.getElementById("coverage");
const covervalue = document.getElementById("covervalue");
const table = document.getElementById("table");
const filter = document.getElementById("filter");
const search = document.getElementById("search");
const totalCustomers = document.getElementById("totalcust");
const totalPremium = document.getElementById("totalpremium");
const error = document.getElementById("error");
function insurance() {
  planscon.innerHTML = plans.map(p => `
    <div class="bg-indigo-300 flex flex-col items-center p-4 rounded shadow">
      <h3 class="text-xl font-bold">${p.name} Insurance</h3>
      <p class="text-md font-bold">Base: ₹${p.base}</p>
      <p class="text-md font-bold" >Coverage: ${p.cover}</p>
      <button class="bg-indigo-600 text-white mt-2 px-4 py-1 rounded"><a href="#formsec"> Enroll </a></button>
    </div>
  `).join("");
}
insurance();

coverage.addEventListener("input", () => {
  covervalue.innerText = `Coverage: ${coverage.value}L`;
});

function calPremium(age, policy, coverage) {
  let base;
  if (policy === "Health") base = 6000;
  else if (policy === "Life") base = 7000;
  else base = 4000;

  let premium = base + (coverage - 1) * 500;

  if (age > 45) premium = premium * 1.2;

  return Math.round(premium);
}

form.addEventListener("submit", function (e) {
  e.preventDefault();

  const name = form.name.value.trim();
  const age = parseInt(form.age.value);
  const email = form.email.value;
  const policy = form.policy.value;
  const cov = parseInt(coverage.value);

  if (name === "" || isNaN(age) || age <= 0 || !email.includes("@")) {
    error.textContent = "Please enter valid data!";
    return;
  }

  error.innerText = "";

  const premium = calPremium(age, policy, cov);

  customers.push({
    id: Date.now(),
    name,
    age,
    policyType: policy,
    coverage: cov,
    premium
  });

  form.reset();
  covervalue.textContent = "Coverage: 1L";
  insurance();
  tablefun();
});

function tablefun() {
  let filtered = customers.filter(c => {
    const policyMatch = filter.value === "All" || c.policyType === filter.value;
    const searchMatch = c.name.toLowerCase().includes(search.value.toLowerCase());
    return policyMatch && searchMatch;
  });

  table.innerHTML = filtered.map(c => `
    <tr class="border-b text-center">
      <td>${c.name}</td>
      <td>${c.age}</td>
      <td>${c.policyType}</td>
      <td>${c.coverage}L</td>
      <td>₹${c.premium}</td>
    </tr>
  `).join("");

  totalCustomers.innerText = customers.length;
  totalPremium.innerText = customers.reduce((sum, c) => sum + c.premium, 0);
}

filter.addEventListener("change", tablefun);
search.addEventListener("input", tablefun);

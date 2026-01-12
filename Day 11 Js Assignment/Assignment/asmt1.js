//Task 1– Select by ID
//Change the dashboard title text to “Customer Insurance Overview”.

let t=document.getElementById('pageTitle')
t.textContent="Customer Insurance Overview"

// Task 2– Select by Tag Name
// Select all <li> elements and:
// Add a border
// Log the total number of customers

let li=document.getElementsByTagName('li')
for(let i=0;i<li.length;i++){
    li[i].style.borderStyle="solid"
    li[i].style.borderWidth="2px"
}
console.log(li.length)

// Task 3– Select by Class Name
// Select all .policy elements and:
// Add highlight class
// Change text color to blue

let s=document.getElementsByClassName('policy')
for(let i=0;i<s.length;i++){
    s[i].classList.add('highlight')
    s[i].style.color="blue"
}

// Task 4– Select using CSS Selectors
// Select the first customer only
// Select all customers
// Mark the last customer as active

let first_customer=document.querySelector('.customer')
let allcustomers=document.querySelectorAll('.customer')
allcustomers[allcustomers.length-1].classList.add('active')
console.log(first_customer,allcustomers)


// Task 5– HTML Object CollecƟons
// Using document collections:
// Count number of forms
// Get number of images
// Change text of all links to “More Info”

let no_of_forms=document.forms.length
let no_of_images=document.images.length
let n=document.links
console.log(no_of_forms)
console.log(no_of_images)
for(let i=0;i<n.length;i++){
    n[i].textContent="More Info"
}

// Task 6– Add a new customer dynamically and observe:
// Which selections update automatically?
// Which don’t?

let ul=document.getElementById('customerList')
let newcust=document.createElement('li')
newcust.textContent="Rohith - Vehicle"
newcust.classList.add('customer')
ul.appendChild(newcust)

//Answer
//The selections updated automatically are live html collections like (getElementsByClassName,getElementsByTagName,getElementById )
//But selections like (querySelector,querySelectorAll) are not updated automatically because they are static collections.


// Task 7 – Attribute-Based Selection
// Select only input fields whose type is "text" using CSS selectors and:
// Add a yellow background
// Add placeholder text: "Enter Full Name"

let inp = document.querySelectorAll('input[type="text"]')
for(let i=0;i<inp.length;i++){
    inp[i].style.backgroundColor="yellow"
    inp[i].setAttribute("placeholder","Enter Full Name")
}


// Task 8 – Multiple Class Selection
// Select all elements that have both customer and active classes and:
// Change text color to dark green
// Add text (Priority Customer) at the end

let cs = document.querySelectorAll('.customer.active')
for(let i=0;i<cs.length;i++){
    cs[i].style.color="darkgreen"
    cs[i].textContent+="(Priority Customer)"
}

// Task 9 – Descendant vs Child Selector
// Select all <li> elements inside #customerList using a descendant selector
// Select only direct child <li> using a child selector
// Log the difference in console.

let ds = document.querySelectorAll("#customerList li")
console.log(ds)
let chs = document.querySelectorAll("#customerList > li")
console.log(chs)

// Task 10 – Even / Odd Selection (CSS Pseudo Selectors)
// Using querySelectorAll():
// Highlight even customers in light gray
// Highlight odd customers in light blue
//  Hint: :nth-child()

let ev = document.querySelectorAll("#customerList li:nth-child(even)")
let od = document.querySelectorAll("#customerList li:nth-child(odd)")

for(let i=0;i<ev.length;i++){
    ev[i].style.backgroundColor="lightgray"
}
for(let i=0;i<od.length;i++){
    od[i].style.backgroundColor="lightblue"
}

// Task 11 – Form Elements Collection
// Using HTML form object model:
// Access the enquiry form
// Log all input field names
// Disable the submit button
//  Hint: document.forms["formId"].elements

let f=document.forms['enquiryForm'].elements
console.log(f)
for(let i=0;i<f.length;i++){
    if (f[i].tagName==='INPUT') console.log(f[i].name)
}
let but=document.querySelector("button[type='submit']")
but.disabled=true

// Task 12 – NodeList vs HTMLCollection
// Select policies using:
// getElementsByClassName
// querySelectorAll
// Dynamically add a new policy
// Observe which collection updates automatically

let pl=document.getElementsByClassName('policy')
console.log(pl)
let p=document.querySelectorAll('.policy')
console.log(p)
let newpol=document.createElement('p')
newpol.textContent="Term life Insurance"
newpol.classList.add('policy')
document.body.appendChild(newpol)
console.log(pl)
console.log(p)

//  Task 13 – Text Content Filtering
//  Select all customers and:
//  Highlight customers whose policy includes "Life"
//  Hide customers whose policy includes "Vehicle"
//  Hint: textContent.includes()

let pol=document.getElementsByClassName('customer')
for(let i=0;i<pol.length;i++){
    if (pol[i].textContent.includes("Life")) pol[i].classList.add('highlight')
    if (pol[i].textContent.includes("Vehicle")) pol[i].style.display="none"
}

// Task 14 – Closest & Parent Traversal
// When clicking any customer <li>:
// Find the nearest <ul>
// Add a border to it
// Hint: closest()

let cl = document.querySelectorAll("#customerList li")
console.log(cl)
for(let i=0;i<cl.length;i++){
    cl[i].addEventListener('click', function(){
        let c=this.closest('ul')
        c.style.borderStyle='solid';
        console.log(this.textContent)
    })
}

// Task 15 – Complex Selector Challenge Select:
// All policy <p> elements except the first one and:
// Change font style to italic
// Prefix text with "✔ "
// Hint: :not() and :first-child

let pp = document.querySelectorAll("p.policy:not(:first-of-type)")
console.log(pp)
for(let i=0;i<pp.length;i++){
    pp[i].style.fontStyle="italic"
    pp[i].textContent="✔ "+pp[i].textContent
}
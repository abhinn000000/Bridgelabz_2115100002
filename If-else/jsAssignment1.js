let a = Math.floor((Math.random()*100)+1)
let b = Math.floor((Math.random()*100)+1)
let c = Math.floor((Math.random()*100)+1)
let d = Math.floor((Math.random()*100)+1)
let e = Math.floor((Math.random()*100)+1)

console.log(a)
console.log(b)
console.log(c)
console.log(d)
console.log(e)

let largest = a;
let smallest = a;
if(b > largest){
    largest = b;
}
if(c > largest){
    largest = c;
}
if(d > largest){
    largest = d;
}
if(e > largest){
    largest = e;
}

if(b < smallest){
    smallest = b;
}
if(c < smallest){
    smallest = c;
}
if(d < smallest){
    smallest = d;
}
if(e < smallest){
    smallest =e;
}
console.log(largest +" is the largest")
console.log(smallest +" is the smallest")




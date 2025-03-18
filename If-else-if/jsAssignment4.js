let a = Math.floor((Math.random()*100)+1)
let b = Math.floor((Math.random()*100)+1)
let c = Math.floor((Math.random()*100)+1)

let firstOperation = a + b * c;
let secondOperation = a % b + c;
let thirdOperation = c + a / b;
let fourthOperation = a * b + c;

console.log(a)
console.log(b)
console.log(c)
console.log(firstOperation)
console.log(secondOperation)
console.log(thirdOperation)
console.log(fourthOperation)

let largest = firstOperation;
let smallest = firstOperation;
if(secondOperation > largest){
    largest = secondOperation;
}
if(thirdOperation > largest){
    largest = thirdOperation;
}
if(fourthOperation > largest){
    largest = fourthOperation;
}


if(secondOperation < smallest){
    smallest = secondOperation;
}
if(thirdOperation < smallest){
    smallest = thirdOperation;
}
if(fourthOperation < smallest){
    smallest = fourthOperation;
}
console.log(largest +" is the largest")
console.log(smallest +" is the smallest")




let num = parseInt(process.argv[2])
if(num){
    console.log("Enter the num")
}
console.log(num)
var flag = 0;
for(var i = 2;i<num/2;i++){
    if(num % i == 0){
        flag = 1;
        break;
    }
}
if(flag == 0){
    console.log(num+" is prime ")
}
else{
    console.log(num+" is not prime ")
}

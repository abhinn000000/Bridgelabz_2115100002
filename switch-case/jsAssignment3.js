let num = parseInt(process.argv[2])
if(num){
    console.log("Enter the num")
}
console.log(num)
switch(num){
    case 10:
        console.log("Ten")
        break;
    case 100:
        console.log("Hundred")
        break;
    case 1000:
        console.log("Thousand")
        break;
    case 10000:
        console.log("Ten Thousand")
        break;    
    case 100000:
        console.log("One Lakh")
        break;
    case 1000000:
        console.log("Ten Lakhs")
        break;
    case 10000000:
        console.log("One Crore")
        break;
}
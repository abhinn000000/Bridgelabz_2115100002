const day = process.argv[2];
const month = process.argv[3];
if(day){
    console.log(`Enter the day:  ${day}`);
}
if(month){
    console.log(`Enter the month: ${month}`);
}
console.log(day);
console.log(month);

if((month == 3 && day >= 20 && day <= 31) ||         // March 20–31
(month == 4 && day >= 1 && day <= 30) ||          // April
(month == 5 && day >= 1 && day <= 31) ||          // May
(month == 6 && day >= 1 && day <= 20)){
    console.log(true);
}
else{
    console.log(false);
}
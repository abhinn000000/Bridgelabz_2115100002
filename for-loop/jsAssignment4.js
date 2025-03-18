let start = parseInt(process.argv[2]);
let end = parseInt(process.argv[3]);

if (start && end) {
    console.log("Enter the range");
}
console.log(`Prime numbers between ${start} and ${end}:`);

for (let num = start; num <= end; num++) {
    if (num < 2) continue; // ignoring numbers less than 2

    let flag = 0;
    for (let i = 2; i <= Math.sqrt(num); i++) {
        if (num % i == 0) {
            flag = 1;
            break;
        }
    }
    if (flag == 0) {
        console.log(num);
    }
}

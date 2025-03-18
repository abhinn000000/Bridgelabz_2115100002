let n = parseInt(process.argv[2]);

if(n){
    console.log("Enter a num")
}
console.log(`Prime factors of ${n} are:`);

// Check for the number of 2s that divide n
while (n % 2 === 0) {
    console.log(2);
    n = Math.floor(n / 2);
}

// Check for odd factors
for (let i = 3; i * i <= n; i += 2) {
    while (n % i === 0) {
        console.log(i);
        n = Math.floor(n / i);
    }
}

// If n is a prime number greater than 2
if (n > 2) {
    console.log(n);
}

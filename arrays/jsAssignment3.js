let n = parseInt(process.argv[2]);

if (!n || n < 2) {
    console.log("Please enter a valid number greater than 1.");
    process.exit(1);
}

console.log(`Finding prime factors of ${n}...`);

function getPrimeFactors(num) {
    let factors = [];

    // Divide by 2 until num becomes odd
    while (num % 2 === 0) {
        factors.push(2);
        num /= 2;
    }

    // Check for odd factors starting from 3
    for (let i = 3; i * i <= num; i += 2) {
        while (num % i === 0) {
            factors.push(i);
            num /= i;
        }
    }

    // If num is still greater than 2, it must be prime
    if (num > 2) {
        factors.push(num);
    }

    return factors;
}

const primeFactors = getPrimeFactors(n);
console.log(`Prime Factors of ${n}: ${primeFactors.join(', ')}`);

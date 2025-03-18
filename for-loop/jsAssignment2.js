let n = parseInt(process.argv[2]);

if (n) {
    console.log("Enter a num");
}
console.log(n);

console.log(`Harmonic numbers up to H(${n}):`);
let harmonic = 0;
for (let i = 1; i <= n; i++) {
    harmonic += 1 / i;
    console.log(`H(${i}) = ${harmonic}`);
}

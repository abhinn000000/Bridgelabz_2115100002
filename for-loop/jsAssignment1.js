let n = parseInt(process.argv[2]);
if(n){
    console.log("Enter a num")
}
console.log(n)

console.log(`Powers of 2 up to 2^${n}:`);
for (let i = 0; i <= n; i++) {
    console.log(`2^${i} = ${Math.pow(2, i)}`);
}
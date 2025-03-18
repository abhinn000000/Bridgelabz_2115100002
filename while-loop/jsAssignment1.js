let n = parseInt(process.argv[2]);

if(n){
    console.log("Enter a num")
}

console.log(`Powers of 2 up to 2^${n} (max 256):`);

let i = 0;
while (i <= n && Math.pow(2, i) <= 256) {
    console.log(`2^${i} = ${Math.pow(2, i)}`);
    i++;
}

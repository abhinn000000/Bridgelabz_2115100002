const readline = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout
});

console.log("Think of a number between 1 to 100.");

let low = 1;
let high = 100;

function findMagicNumber() {
    if (low === high) {
        console.log(`Your magic number is: ${low}`);
        readline.close();
        return;
    }

    let mid = Math.floor((low + high) / 2);
    readline.question(`Is your number less than ${mid}? (yes/no): `, (answer) => {
        if (answer.toLowerCase() === 'yes') {
            high = mid;
        } else {
            low = mid + 1;
        }
        findMagicNumber();
    });
}

findMagicNumber();

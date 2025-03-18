// Function to roll a die and return a number between 1 and 6
function rollDie() {
    return Math.floor(Math.random() * 6) + 1;
}

// Initialize dictionary to store die roll counts
let dieRolls = new Map([
    [1, 0],
    [2, 0],
    [3, 0],
    [4, 0],
    [5, 0],
    [6, 0]
]);

// Repeat die rolls until one number reaches 10 times
while (![...dieRolls.values()].includes(10)) {
    let roll = rollDie();
    dieRolls.set(roll, dieRolls.get(roll) + 1);
}

console.log("Die Roll Results:", Object.fromEntries(dieRolls));

// Finding max and min occurrence
let maxRoll = [...dieRolls.entries()].reduce((a, b) => (a[1] > b[1] ? a : b));
let minRoll = [...dieRolls.entries()].reduce((a, b) => (a[1] < b[1] ? a : b));

console.log(`Number that reached maximum times: ${maxRoll[0]} (Count: ${maxRoll[1]})`);
console.log(`Number that reached minimum times: ${minRoll[0]} (Count: ${minRoll[1]})`);

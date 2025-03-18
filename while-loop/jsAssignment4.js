let money = 100;
let goal = 200;
let wins = 0;
let bets = 0;

while (money > 0 && money < goal) {
    bets++;
    let gamble = Math.floor(Math.random() * 2); // 0 = lose, 1 = win
    if (gamble === 1) {
        money++;
        wins++;
    } else {
        money--;
    }
}

console.log(`Final amount: Rs ${money}`);
console.log(`Total wins: ${wins}`);
console.log(`Total bets made: ${bets}`);

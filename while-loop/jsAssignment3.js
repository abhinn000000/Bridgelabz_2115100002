let headsCount = 0;
let tailsCount = 0;

while (headsCount < 11 && tailsCount < 11) {
    let coin = Math.floor(Math.random() * 2);
    if (coin == 1) {
        headsCount++;
        console.log("Heads");
    } else {
        tailsCount++;
        console.log("Tails");
    }
}

if (headsCount == 11) {
    console.log("Heads wins 11 times!");
} else {
    console.log("Tails wins 11 times!");
}

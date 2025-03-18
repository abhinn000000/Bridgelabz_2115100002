// Function to find numbers with repeated digits
function findRepeatedDigitsInRange(start, end) {
    let repeatedDigits = [];

    for (let i = start; i <= end; i++) {
        let strNum = i.toString();
        if (strNum.length === 2 && strNum[0] === strNum[1]) {
            repeatedDigits.push(i);
        }
    }

    return repeatedDigits;
}

const start = 0;
const end = 100;

const repeatedDigits = findRepeatedDigitsInRange(start, end);

console.log(`Numbers with repeated digits between ${start} and ${end}:`, repeatedDigits);

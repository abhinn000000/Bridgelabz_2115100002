let n = parseInt(process.argv[2]);

if (!n) {
    console.log("Enter a valid number");
    process.exit(1);
}

console.log(`Generating ${n} random 3-digit numbers...`);

let numbers = [];
for (let i = 0; i < n; i++) {
    numbers.push(Math.floor(Math.random() * 900) + 100); // Random 3-digit number
}

console.log("Random Numbers:", numbers);

function findSecondLargestAndSmallest(arr) {
    let largest = -Infinity, secondLargest = -Infinity;
    let smallest = Infinity, secondSmallest = Infinity;

    for (let num of arr) {
        if (num > largest) {
            secondLargest = largest;
            largest = num;
        } else if (num > secondLargest && num !== largest) {
            secondLargest = num;
        }

        if (num < smallest) {
            secondSmallest = smallest;
            smallest = num;
        } else if (num < secondSmallest && num !== smallest) {
            secondSmallest = num;
        }
    }

    return { secondLargest, secondSmallest };
}

const { secondLargest, secondSmallest } = findSecondLargestAndSmallest(numbers);

console.log(`Second Largest Number: ${secondLargest}`);
console.log(`Second Smallest Number: ${secondSmallest}`);

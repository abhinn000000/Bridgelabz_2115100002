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

// Finding 2nd Largest & 2nd Smallest without sorting
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

// Sorting the array
let sortedNumbers = [...numbers].sort((a, b) => a - b);

console.log("Sorted Numbers:", sortedNumbers);

const { secondLargest, secondSmallest } = findSecondLargestAndSmallest(numbers);

console.log(`Second Largest (Without Sorting): ${secondLargest}`);
console.log(`Second Smallest (Without Sorting): ${secondSmallest}`);

console.log(`Second Largest (With Sorting): ${sortedNumbers[sortedNumbers.length - 2]}`);
console.log(`Second Smallest (With Sorting): ${sortedNumbers[1]}`);

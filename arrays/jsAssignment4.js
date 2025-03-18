let n = parseInt(process.argv[2]);

if (!n || n < 3) {
    console.log("Please enter a valid number greater than or equal to 3.");
    process.exit(1);
}

// Generate random integers between -10 and 10
let numbers = Array.from({ length: n }, () => Math.floor(Math.random() * 21) - 10);

console.log("Generated Array:", numbers);

function findTriplets(arr) {
    let triplets = [];

    // Sort the array for easier two-pointer approach
    arr.sort((a, b) => a - b);

    for (let i = 0; i < arr.length - 2; i++) {
        // Skip duplicates
        if (i > 0 && arr[i] === arr[i - 1]) continue;

        let left = i + 1;
        let right = arr.length - 1;

        while (left < right) {
            let sum = arr[i] + arr[left] + arr[right];

            if (sum === 0) {
                triplets.push([arr[i], arr[left], arr[right]]);
                left++;
                right--;

                // Skip duplicates in the sorted array
                while (left < right && arr[left] === arr[left - 1]) left++;
                while (left < right && arr[right] === arr[right + 1]) right--;
            } else if (sum < 0) {
                left++;
            } else {
                right--;
            }
        }
    }

    return triplets;
}

const triplets = findTriplets(numbers);

if (triplets.length > 0) {
    console.log("Triplets that sum to zero:", triplets);
} else {
    console.log("No triplets found that sum to zero.");
}

// Function to generate random birth month (1 to 12)
function getRandomMonth() {
    return Math.floor(Math.random() * 12) + 1;
}

// Generate 50 random birth months
let birthMonths = Array.from({ length: 50 }, () => getRandomMonth());

// Group individuals by month using a Map
let monthGroups = new Map();

// Initialize map with empty arrays for each month
for (let month = 1; month <= 12; month++) {
    monthGroups.set(month, []);
}

// Assign individuals to respective birth month groups
birthMonths.forEach((month, index) => {
    monthGroups.get(month).push(`Person ${index + 1}`);
});

// Display the results
console.log("Individuals grouped by birth month:");
monthGroups.forEach((individuals, month) => {
    console.log(`Month ${month}: ${individuals.length > 0 ? individuals.join(', ') : 'None'}`);
});

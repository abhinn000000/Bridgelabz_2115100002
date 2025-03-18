function convertTemperature(choice, value) {
    if (choice === 1) {
        if (value >= 0 && value <= 100) {
            const degF = (value * 9/5) + 32;
            console.log(`${value}°C = ${degF.toFixed(2)}°F`);
        } else {
            console.log("Please enter a valid Celsius temperature between 0 and 100.");
        }
    } else if (choice === 2) {
        if (value >= 32 && value <= 212) {
            const degC = (value - 32) * 5/9;
            console.log(`${value}°F = ${degC.toFixed(2)}°C`);
        } else {
            console.log("Please enter a valid Fahrenheit temperature between 32 and 212.");
        }
    } else {
        console.log("Invalid choice. Please select 1 or 2.");
    }
}

let choice = parseInt(process.argv[2]);
let value = parseFloat(process.argv[3]);
convertTemperature(choice, value);

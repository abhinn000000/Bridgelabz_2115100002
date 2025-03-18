let num = parseFloat(process.argv[2]);
let choice = parseInt(process.argv[3]);

switch (choice) {
    case 1:
        console.log(`${num} Feet = ${num * 12} Inches`);
        break;
    case 2:
        console.log(`${num} Feet = ${(num * 0.3048)} Meters`);
        break;
    case 3:
        console.log(`${num} Inches = ${(num / 12)} Feet`);
        break;
    case 4:
        console.log(`${num} Meters = ${(num / 0.3048)} Feet`);
        break;
    default:
        console.log("Invalid choice. Choose a number between 1 and 4.");
}

function isPalindrome(num) {
    const str = num.toString();
    return str === str.split('').reverse().join('');
}

function checkPalindromes(num1, num2) {
    if (isPalindrome(num1) && isPalindrome(num2)) {
        console.log(`${num1} and ${num2} are both palindromes.`);
    } else if (isPalindrome(num1)) {
        console.log(`${num1} is a palindrome, but ${num2} is not.`);
    } else if (isPalindrome(num2)) {
        console.log(`${num2} is a palindrome, but ${num1} is not.`);
    } else {
        console.log(`Neither ${num1} nor ${num2} is a palindrome.`);
    }
}

let num1 = parseInt(process.argv[2]);
let num2 = parseInt(process.argv[3]);
checkPalindromes(num1, num2);

function solve(args) {
    var thirdDigit = (+args / 100) | 0;
    thirdDigit %= 10;
    
    if (thirdDigit === 7) {
        console.log("true");
    }
    else {
        console.log("false " + thirdDigit);
    }
}
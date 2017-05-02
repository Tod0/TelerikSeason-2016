function solve(args) {
    var isDivisible = +args % 5 === 0 && +args % 7 === 0;

    if (isDivisible) {
        console.log("true " + args);
    }
    else {
        console.log("false " + args);
    }
}
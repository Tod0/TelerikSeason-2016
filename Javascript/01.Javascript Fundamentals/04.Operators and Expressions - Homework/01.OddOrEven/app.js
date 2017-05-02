function solve(args) {
    var isEven = +args % 2 === 0;

    if (isEven) {
        console.log("even " + args);
    }
    else {
        console.log("odd " + args);
    }
}
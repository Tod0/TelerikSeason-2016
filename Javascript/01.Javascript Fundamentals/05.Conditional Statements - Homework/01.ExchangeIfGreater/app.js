function solve(args) {
    var a = +args[0],
        b = +args[1];

    var temp;

    if (a > b) {
        temp = a;
        a = b;
        b = temp;
    }

    console.log(a + " " + b);
}
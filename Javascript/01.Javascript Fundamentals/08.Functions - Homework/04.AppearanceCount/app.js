function solve(args) {
    var n = +args[0],
        arr = args[1].split(' ').map(Number),
        x = +args[2],
        counter = 0;

    for (var i = 0; i < n; i++) {
        if (x === arr[i]) {
            counter++;
        }
    } 

    console.log(counter);
}

solve([ '8', '28 6 21 6 -7856 73 73 -56', '73' ])
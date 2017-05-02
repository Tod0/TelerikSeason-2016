function solve(args) {
    var min = +args[0],
        max = +args[0],
        sum = +args[0],
        average = 0;

    for (var i = 1; i < args.length; i++) {
        if (min > +args[i]) {
            min = +args[i];
        }

        if (max < +args[i]) {
            max = +args[i];
        }

        sum += +args[i];
    }
    min = min.toFixed(2);
    max = max.toFixed(2);

    sum = sum.toFixed(2)

    average = sum / args.length;
    average = average.toFixed(2);

    console.log("min=" + min);
    console.log("max=" + max);
    console.log("sum=" + sum);
    console.log("avg=" + average);
}
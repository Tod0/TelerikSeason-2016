function solve(args) {
    var n = +args[0],
        k = +args[1],
        arr = args[2].split(' ').map(Number),
        resultArr = [],
        arr1 = [],
        arr2 = [],
        min = 0,
        max = 0;

    for (var i = 0; i <= arr.length - k; i += 1) {
        resultArr.push(Math.min.apply(null, arr.slice(i, i + k)) +
            Math.max.apply(null, arr.slice(i, i + k)));
    }

    console.log(resultArr.join(','));
}

solve(["4", "2", "1 3 1 8"])
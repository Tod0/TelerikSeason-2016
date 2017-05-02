function solve(args) {
    var array = args[0].split("\n"),
        n = +array[0],
        arr = new Array(n),
        counter = 1,
        biggestCounter = 1,
        index = 1;

    for (var i = 0; i < n; i++) {
        arr[i] = +array[index];
        index++;
    }

    for (var i = 0; i < n - 1; i++) {
        if (arr[i] === arr[i + 1]) {
            counter++;
        } else if (arr[i] !== arr[i + 1]) {
            counter = 1;
        }

        if (biggestCounter < counter) {
            biggestCounter = counter;
        }
    }

    console.log(biggestCounter);
}
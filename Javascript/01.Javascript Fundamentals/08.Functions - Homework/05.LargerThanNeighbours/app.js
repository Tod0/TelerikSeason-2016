function solve(args) {
    var n = +args[0],
        arr = args[1].split(' ').map(Number),
        counter = 0;

    for (var i = 1; i < n - 1; i++) {
        if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1]) {
            counter++;
        }
    }

    console.log(counter);
}
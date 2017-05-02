function solve(args) {
    var n = +args[0],
        arr = args[1].split(' ').map(Number);

    for (var i = 1; i < n - 1; i++) {
        if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1]) {
            return i;
        }
    }

    return -1;
}
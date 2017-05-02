function solve(args) {
    var n = +args[0],
        arr = args[1].split(' ').map(Number),
        result = "";

    // converts all elements in the array to integers
    for (var i = 0; i < n; i++) {
        arr[i] = +arr[i];
    }

    arr.sort(function(a, b){return a-b});

    for (var i = 0; i < n; i++) {
        if (i < n - 1) {
            result += arr[i] + " ";
        } else {
            result += arr[i];
        }
    }

    console.log(result);
}

solve(["6\n3 4 1 5 2 6"])

/*var input = args[0].split("\n"),
        n = +input[0],
        arr = input[1].split(' '),
        result = "";
        */
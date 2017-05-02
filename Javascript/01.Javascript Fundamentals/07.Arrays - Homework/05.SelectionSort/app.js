function solve(args) {
    var array = args[0].split("\n"),
        n = +array[0],
        arr = new Array(n),
        index = 1;

    for (var i = 0; i < n; i++) {
        arr[i] = +array[index];
        index++;
    }

    for (var i = 0; i < n - 1; i++) {
        var min = i;
        for (var j = i + 1; j < n; j++) {
            if (arr[j] < arr[min]) {
                min = j;
            }
        }
        if (min !== i) {
            var tmp = arr[i];
            arr[i] = arr[min];
            arr[min] = tmp;
        }
    }

    console.log(arr.join('\n'));
}

solve(["6\n3\n4\n1\n5\n2\n6"])
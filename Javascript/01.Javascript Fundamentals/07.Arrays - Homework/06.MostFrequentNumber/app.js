function solve(args) {
    var array = args[0].split("\n"),
        n = +array[0],
        arr = new Array(n),
        counter = 1,
        biggestCounter = 1,
        mostFreqNumber = 0,
        index = 1;

    for (var i = 0; i < n; i++) {
        arr[i] = +array[index];
        index++;
    }

    for (var i = 0; i < n; i++) {
        for (var j = i + 1; j < n; j++) {
            if (arr[i] === arr[j]) {
                counter++;
            }
        }

        if (biggestCounter < counter) {
            biggestCounter = counter;
            mostFreqNumber = arr[i];
        }

        counter = 1;
    }
    
    console.log(mostFreqNumber + " (" + biggestCounter + " times)");
}

solve(["13\n4\n1\n1\n4\n2\n3\n4\n4\n1\n2\n4\n9\n3"])
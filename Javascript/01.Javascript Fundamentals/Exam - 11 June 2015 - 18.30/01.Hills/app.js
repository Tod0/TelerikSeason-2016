function solve(args) {
    var arr = args[0].split(' ').map(Number),
        rockCounter = 0,
        biggestRockCounter = 0,
        peakCounter = 0,
        secondArr = [];

    secondArr.push(Number(100001));
    for (var i = 1; i < arr.length - 1; i += 1) {
        if (arr[i] < arr[i - 1] && arr[i] < arr[i + 1]) {
           secondArr.push("valley"); 
        }
        else if (arr[i] < arr[i - 1] || arr[i] < arr[i + 1]) {
            secondArr.push(arr[i]);
        } else {
            secondArr.push(Number(100001));
        }
    }
    secondArr.push(Number(100001));

    for (var i = 0; i < secondArr.length; i += 1) {
        if (secondArr[i] === 100001) {
            rockCounter += 1;
            peakCounter += 1;

            if (peakCounter === 2) {
                peakCounter = 1;
                if (biggestRockCounter < rockCounter) {
                    biggestRockCounter = rockCounter;
                }
                rockCounter = 1;
            }
        }
        else if (secondArr[i] !== "valley") {
            rockCounter += 1;
        }
    }

    console.log(biggestRockCounter);
}

solve(["5 2 8"])
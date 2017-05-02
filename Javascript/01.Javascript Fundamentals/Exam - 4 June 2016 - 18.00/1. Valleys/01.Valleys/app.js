function solve(args) {
    var arr = args[0].split(' ').map(Number),
        currentSum = 0,
        biggestSum = -1000000,
        secondArr = [],
        peakCounter = 0;

    // pravq vtori masiv kudeto vseki vruh ot originalniq masiv se kazva "peak"
    secondArr.push("peak");
    for(var i = 1; i < arr.length - 1; i += 1) {
        if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1]) {
            secondArr.push("peak");
        }
        else {
            secondArr.push(arr[i]);
        }
    }
    secondArr.push("peak");
    
    // presmqtam sumata
    for(var i = 0; i < secondArr.length; i += 1) {
        if (secondArr[i] === "peak") {
            peakCounter += 1;
            currentSum += arr[i];

            if (peakCounter === 2) {
                peakCounter = 1;
                if (biggestSum < currentSum) {
                    biggestSum = currentSum;
                }
                currentSum = arr[i];
            }
        }
        else {
            currentSum += arr[i];
        }
    }
    
    console.log(biggestSum);
}

solve(["5 1 7 4 8"])
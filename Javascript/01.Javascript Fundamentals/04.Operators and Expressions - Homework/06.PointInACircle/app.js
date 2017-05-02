function solve(args) {
    var centerX = 0,
        centerY = 0,
        radius = 2,
        pointX = +args[0],
        pointY = +args[1],
        distance = Math.sqrt(pointX * pointX + pointY * pointY);
        distance = distance.toFixed(2);

        if (Math.pow(pointX - centerX, 2) + Math.pow(pointY - centerY, 2) <= radius * radius) {
            console.log("yes " + distance);
        }
        else {
            console.log("no " + distance);
        }
}
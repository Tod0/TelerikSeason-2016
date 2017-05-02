function solve(args) {
    var centerX = 1,
        centerY = 1,
        radius = 1.5,
        topY = 1,
        leftX = -1,
        width = 6,
        height = 2,
        rightX = leftX + width,
        bottomY = topY - height,
        pointX = +args[0],
        pointY = +args[1];

        var isWithinCircle = Math.pow(pointX - centerX, 2) + Math.pow(pointY - centerY, 2) <= radius * radius;
        var isWithinRectangle = pointX >= leftX && pointX <= rightX && pointY <= topY && pointY >= bottomY;

        if (isWithinCircle && isWithinRectangle) {
            console.log("inside circle inside rectangle");
        }
        else if (!isWithinCircle && isWithinRectangle) {
            console.log("outside circle inside rectangle");
        }
        else if (isWithinCircle && !isWithinRectangle) {
            console.log("inside circle outside rectangle");
        }
        else {
            console.log("outside circle outside rectangle");
        }
}
function solve(args) {
    var sideA = +args[0],
        sideB = +args[1],
        height = +args[2];

    var area = ((sideA + sideB) / 2) * height;
    area = area.toFixed(7);

    console.log(area);
}
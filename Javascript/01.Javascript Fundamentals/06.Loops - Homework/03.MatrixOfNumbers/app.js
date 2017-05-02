function solve(args) {
    var n = +args;
    var strMatrix = [];

    for (var row = 0; row < n; row += 1) {
        strMatrix[row] = '';
        var fill = row + 1;

        for (var col = 0; col < n; col += 1) {
            strMatrix[row] += String(fill) + ' ';
            fill += 1;
        }

        strMatrix[row] = String(strMatrix[row]).trim();
        console.log(strMatrix[row]);
    }
}
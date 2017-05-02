function solve(args) {
    var s = +args[0],
        c1 = +args[1],
        c2 = +args[2],
        c3 = +args[3],
        result = 0;

    for (var i = 0; i <= s / c1 + 1; i += 1) {
        for (var j = 0; j <= s / c2 + 1; j += 1) {
            for (var k = 0; k <= s / c3 + 1; k += 1) {
                var price = i * c1 + j * c2 + k * c3;
                if (price <= s) {
                    result = Math.max(result,price);
                }
            }
        }
    }

    console.log(result);
}


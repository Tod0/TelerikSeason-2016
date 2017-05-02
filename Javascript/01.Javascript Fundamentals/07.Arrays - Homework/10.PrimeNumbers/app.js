function solve(args) {
    function isPrime(number) {
        var boundary = +(Math.floor(Math.sqrt(number)));

        if (number === 1) return false;
        if (number === 2) return true;

        for (var i = 2; i <= boundary; ++i) {
            if (number % i === 0) return false;
        }

        return true;
    }

    var n = +args;

    for (var i = n; i >= 1; i--) {
        if (isPrime(i)) {
            console.log(i);;
            break;
        }
    }
}
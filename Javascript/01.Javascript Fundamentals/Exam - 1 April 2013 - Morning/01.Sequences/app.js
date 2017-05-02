function solve(args) {
    var numbers = args.slice(1).map(Number),
        counter = 1;

    for (var i = 0; i < numbers.length; i += 1) {
        if (numbers[i] > numbers[i + 1]) {
            counter += 1;
        }
    }

    return counter;
}

console.log(solve(['7','1','2','-3','4','4','0','1',]))
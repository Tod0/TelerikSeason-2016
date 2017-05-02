function solve(args) {
    var word = args[0].split("\n"),
        first = word[0],
        second = word[1];

    if (first > second) {
        console.log('>'); 
    } else if (first < second) {
        console.log('<'); 
    } else {
        console.log('='); 
    }
}
function solve(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2],
        d = +args[3],
        e = +args[4],
        biggest = a;
    
    if (biggest < b) {
        biggest = b;
    }
    
    if (biggest < c) {
        biggest = c;
    }

    if (biggest < d) {
        biggest = d;
    }

    if (biggest < e) {
        biggest = e;
    }

    console.log(biggest);
}
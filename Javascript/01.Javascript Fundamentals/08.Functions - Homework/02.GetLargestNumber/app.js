function solve(args) {
    function GetMax(a, b) {
        if (+a > +b) {
            return a;
        } else {
            return b;
        }
    }

    var arr = args[0].split(' '),
        a = +arr[0],
        b = +arr[1],
        c = +arr[2];

    console.log(GetMax(GetMax(a, b), c));
}
function solve(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2];

    if (a === 0 || b === 0 || c === 0) {
        console.log('0');
    }

    else if (a < 0) {
        if (b < 0) {
            if (c < 0) {
                console.log('-');
            }
            else {
                console.log('+');
            }
        }
        else if (c < 0) {
            if (b < 0) {
                console.log('-');
            }
            else {
                console.log('+');
            }
        }
        else {
            console.log('-');
        }
    }

    else if (b < 0) {
        if (a < 0) {
            if (c < 0) {
                console.log('-');
            }
            else {
                console.log('+');
            }
        }
        else if (c < 0) {
            if (a < 0) {
                console.log('-');
            }
            else {
                console.log('+');
            }
        }
        else {
            console.log('-');
        }
    }

    else if (c < 0) {
        if (a < 0) {
            if (b < 0) {
                console.log('-');
            }
            else {
                console.log('+');
            }
        }
        else if (b < 0) {
            if (a < 0) {
                console.log('-');
            }
            else {
                console.log('+');
            }
        }
        else {
            console.log('-');
        }
    }

    else {
        console.log('+');
    }
}
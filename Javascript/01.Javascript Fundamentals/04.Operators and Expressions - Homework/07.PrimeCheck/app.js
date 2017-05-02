function solve(args) {
    if (args == 2 || args == 3 || args == 5 || args == 7) {
        console.log("true");
    }
    else if (args <= 1 || args % 2 == 0 || args % 3 == 0 || args % 5 == 0 || args % 7 == 0) {
        console.log("false");
    }
    else {
        console.log("true");
    }
}
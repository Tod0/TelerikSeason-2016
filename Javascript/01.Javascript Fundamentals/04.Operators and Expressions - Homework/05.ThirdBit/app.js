function solve(args) {
    var position = 3,
        mask = 1 << position,
        nAndMask = args & mask,
        bit = nAndMask >> position;

    console.log(bit);
}
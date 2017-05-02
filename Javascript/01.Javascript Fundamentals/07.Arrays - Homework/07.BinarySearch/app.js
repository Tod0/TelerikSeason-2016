function solve(args) {
    function binarySearch(array, key) {
        var lo = 0,
            hi = array.length - 1,
            mid,
            element;
        while (lo <= hi) {
            mid = Math.floor((lo + hi) / 2, 10);
            element = array[mid];
            if (element < key) {
                lo = mid + 1;
            } else if (element > key) {
                hi = mid - 1;
            } else {
                return mid;
            }
        }
        return -1;
    }

    var array = args[0].split("\n"),
        n = +array[0],
        arr = new Array(n),
        x = +array[array.length - 1],
        index = 1;

    for (var i = 0; i < n; i++) {
        arr[i] = +array[index];
        index++;
    }
    
    console.log(binarySearch(arr, x));
}

solve(["10\n1\n2\n4\n8\n16\n31\n32\n64\n77\n99\n32"])
//console.log(1);
//console.log(2);

for (i = 1; i <= 105; i++) {
    let result = [];
    if (i % 3 === 0) {
        result.push("Fizz");
    }
    if (i % 5 === 0) {
        result.push("Buzz");
    }
    if (i % 7 === 0) {
        result.push("Bang");
    }
    if (i % 11 === 0) {
        result.push("Bling");
    }
    console.log(result.toString(), i);
}

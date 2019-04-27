/* 1. */
var Employee = function(first_name, last_name) {
    this.first_name = first_name;
    this.last_name = last_name;
    this.salary = 0;
}

Employee.prototype.increaseSalary = function () {
    this.salary += 1000;
}

Employee.prototype.displayDetails = function(){
    console.log(`The employee ${this.first_name} ${this.last_name} earns ${this.salary}`);
}

var pablo = new Employee('Pablo', 'Ontiveros');
pablo.displayDetails();
pablo.increaseSalary();
pablo.displayDetails();

/* 2. */
const mul = x => y => z => x * y * z;
const MultiplyBy = mul;

console.log(MultiplyBy(2)(3)(4));
console.log(mul(4)(3)(4));

/* 3. */
function Longest_Country_Name(countries){
    let longest = '';
    countries.forEach(element => {
        if (element.length > longest.length){
            longest = element;
        }
    });

    return longest;
}

console.log(Longest_Country_Name(["Australia", "Germany", "United States of America"]));

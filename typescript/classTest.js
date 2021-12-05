var Student = /** @class */ (function () {
    function Student(firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }
    Object.defineProperty(Student.prototype, "FullName", {
        get: function () {
            return "".concat(this.firstName, " - ").concat(this.lastName);
        },
        set: function (value) {
            var values = value.split(" ");
            this.firstName = values[0];
            this.lastName = values[1];
        },
        enumerable: false,
        configurable: true
    });
    return Student;
}());
var s1 = new Student("Sachin", "Tendulkar");
console.log(s1);
s1.firstName = "Rahul";
console.log(s1);
console.log(s1.FullName);
s1.FullName = "Rahul Dravid";
console.log(s1);

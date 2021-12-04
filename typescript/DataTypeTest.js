function sayHello(name) {
    return "Hello " + name;
}
console.log(sayHello("Vinay"));
//console.log(sayHello(1234)); type number to string
var userName = "Vinay";
var cgpa = 9.29;
var isActiveUser = true;
var displayText = "\n                    Showing User Details:\n                    Name : ".concat(userName, "\n                    CGPA : ").concat(cgpa, "\n                    IsActiveUser : ").concat(isActiveUser, "\n                    ");
console.log(displayText);

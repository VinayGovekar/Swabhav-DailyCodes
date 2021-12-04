function sayHello(name:string):string{
    return "Hello "+name;
}

console.log(sayHello("Vinay"));
//console.log(sayHello(1234)); type number to string

let userName:string = "Vinay";
let cgpa:number = 9.29;
let isActiveUser = true;
let displayText =   `
                    Showing User Details:
                    Name : ${userName}
                    CGPA : ${cgpa}
                    IsActiveUser : ${isActiveUser}
                    `
console.log(displayText);


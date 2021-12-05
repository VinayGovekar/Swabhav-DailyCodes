class Student{
    constructor(public firstName:string,public lastName:string){

    }
    get FullName(){
        return `${this.firstName} - ${this.lastName}`;
    }
    set FullName(value:string){
        let values:string[] = value.split(" ");
        this.firstName=values[0];
        this.lastName=values[1];
    }
}

let s1 = new Student("Sachin","Tendulkar");
console.log(s1);
s1.firstName="Rahul";
console.log(s1);
console.log(s1.FullName);

s1.FullName="Rahul Dravid";
console.log(s1);

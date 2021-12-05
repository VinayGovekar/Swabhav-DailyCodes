import {Account,Bank,Customer} from "./bank-module";

let account = new Account(1000);
let customer = new Customer(101,"Sachin","Tendulkar");
let bank = new Bank("icici","mumbai");

console.log({account,customer,bank})

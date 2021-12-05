"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Customer = exports.Bank = exports.Account = void 0;
var Account = /** @class */ (function () {
    function Account(balance) {
        this.balance = balance;
    }
    return Account;
}());
exports.Account = Account;
var Bank = /** @class */ (function () {
    function Bank(name, location) {
        this.name = name;
        this.location = location;
    }
    return Bank;
}());
exports.Bank = Bank;
var Customer = /** @class */ (function () {
    function Customer(cid, firstName, lastName) {
        this.cid = cid;
        this.firstName = firstName;
        this.lastName = lastName;
    }
    return Customer;
}());
exports.Customer = Customer;

var Account = /** @class */ (function () {
    function Account(_accNo, _name, _balance) {
        this._accNo = _accNo;
        this._name = _name;
        this._balance = _balance;
    }
    Account.prototype.balance = function () {
        return this._balance;
    };
    Account.prototype.name = function () {
        return this._name;
    };
    Account.prototype.accNo = function () {
        return this._accNo;
    };
    Account.prototype.deposit = function (amount) {
        this._balance += amount;
    };
    return Account;
}());
var acc1 = new Account(101, "Sachin", 1000);
console.log(acc1);
acc1.deposit(2000);
console.log(acc1);

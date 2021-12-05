class Account{
    constructor(private _accNo:number, private _name:string, private _balance:number){

    }
    public balance(){
        return this._balance;
    }
    public name(){
        return this._name;
    }
    public accNo(){
        return this._accNo;
    }
    public deposit(amount:number){
        this._balance+=amount;
    }
}

let acc1 = new Account(101,"Sachin",1000);
console.log(acc1);

acc1.deposit(2000);

console.log(acc1);
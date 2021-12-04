interface Customers{
    id:number,
    firstName:string,
    lastName:string,
    location ?:string
}

printDetails([{id:101,firstName:"Sachin",lastName:"Tendulkar"},
              {id:102,firstName:"Rahul",lastName:"Dravid",location:"Banglore"}])

function printDetails(customers:Array<Customers>){
    for(let c of customers){
        console.log(c);
    }
}
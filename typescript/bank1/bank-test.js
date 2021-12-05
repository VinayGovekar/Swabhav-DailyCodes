"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var bank_module_1 = require("./bank-module");
var account = new bank_module_1.Account(1000);
var customer = new bank_module_1.Customer(101, "Sachin", "Tendulkar");
var bank = new bank_module_1.Bank("icici", "mumbai");
console.log({ account: account, customer: customer, bank: bank });

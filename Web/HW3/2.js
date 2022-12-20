"use strict";


  
function name_Hello(n_1) {
    if (n_1 == "") {
        alert("Вы, кстати, не представились...");
    }
    else {
    console.log(`Здравствуйте, ${n_1}`);
    }
}
let name_1 = prompt("Введите ваше имя..");
name_Hello(name_1);
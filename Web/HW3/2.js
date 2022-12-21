"use strict";
  
function nameHello(name) {
    if (name == "") {
        alert("Вы, кстати, не представились...");
    }
    else {
        console.log(`Здравствуйте, ${name}`);
    }
}
let nameUser = prompt("Введите ваше имя..");
nameHello(nameUser);

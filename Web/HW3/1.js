function countDecimals(numDecimal) {
  if(Math.floor(numDecimal.valueOf()) === numDecimal.valueOf()) return 0;
  return numDecimal.toString().split(".")[1].length || 0; 
}
  
function celsiumToFahrenheit() {
  let flag = true;
  do { 
    let celsium = Number.parseFloat(prompt("Введите температуру в градусах Цельсия:").replace(',','.'));
      if (isNaN(celsium)) {
        flag = confirm("Неправильно введено число. Посчитать еще раз?");
      } else {
        let decimalPlaces = 10**Math.max(countDecimals(celsium), 1);
        fahrenheit = Math.round(((9 / 5) * celsium + 32 + Number.EPSILON) * decimalPlaces) / decimalPlaces;
        alert("Температура " + celsium + " в градусах Цельсия эквивалентна " + fahrenheit + " в градусах Фаренгейта.");
        flag = confirm("Посчитать еще раз?");
      }
  } while (flag);
}
celsiumToFahrenheit();


      
      
  Number.prototype.countDecimals = function() {
    if(Math.floor(this.valueOf()) === this.valueOf()) return 0;
    return this.toString().split(".")[1].length || 0; 
  }
  
  function cels_To_Far() {
    flag = true;
    do { 
        let cels_1 = parseFloat(prompt("Введите температуру в градусах Цельсия:").replace(',','.'));
        if (isNaN(cels_1)) {
          flag = confirm("Неправильно введено число. Посчитать еще раз?");
        } else {
          dec = 10**Math.max(cels_1.countDecimals(), 1);
          far_1 = Math.round(((9 / 5) * cels_1 + 32 + Number.EPSILON) * dec) / dec;
          alert("Температура " + cels_1 + " в градусах Цельсия эквивалентна " + far_1 + " в градусах Фаренгейта.");
          flag = confirm("Посчитать еще раз?");
        }
    } while (flag == true)
  }
  cels_To_Far();
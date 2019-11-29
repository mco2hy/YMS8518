function Hesapla(operator) {

    var par1 = document.getElementById("Par2").value;
    var par2 = document.getElementById("Par2").value;
    par1 = parseInt(par1);
    par2 = parseInt(par2);
    var result = 0;
    if (operator == "+") {
        result = par1 + par2;
    } 
    else if (operator == "-") {
        result = par1 - par2;
    }
    else if (operator == "*") {
        result = par1 * par2;
    }
    else if (operator == "/") {
        result = par1 / par2;
    }

    operator = "";
    document.getElementById("result").innerHTML = result;
}

var number1 = 0;
var number2 = 0;
var operation = "";
function Values(value) {
    var v = parseInt(value); 

    if (window.operation == "") {
        window.number1 = parseFloat(window.number1);
        window.number1 = (window.number1 * 10) + v;
        document.getElementById("result1").innerHTML = window.number1;
    }
    else {
        window.number2 = parseFloat(window.number2);
        window.number2 = (window.number2 * 10) + v;
        document.getElementById("result1").innerHTML = window.number2;
    }
}
function Operators(operator) {
    
    if (window.number1 !== 0) {
        if (operator == "+") {
            operation = "+";
        } else if (operator == "-") {
            operation = "-";
        } else if (operator == "*") {
            operation = "*";
        } else if (operator == "/") {
            operation = "/";
        }
    } else {
        alert("Bir sayı girmediniz!");
    }
}
function Equals() {
    var y = window.operation;
    if (y == "") {
        alert("Yapılacak herhangi bir işlem seçilmedi.");
    }
    else {
        Hesapla2(y);
    }
}

function Hesapla2(operator) {

    var sonuc;


    if (operator == "+") {
        sonuc = window.number1 + window.number2;
        
    } else if (operator == "-") {
        sonuc = window.number1 - window.number2;
        
    } else if (operator == "*") {
        sonuc = window.number1 * window.number2;
        
    } else if (operator == "/") {
        sonuc = window.number1 / window.number2;
        
    }

    document.getElementById("result1").innerHTML = parseFloat(sonuc);
    window.number1 = 0;
    window.number2 = 0;
    window.operation = "";

}

function Clear() {
    window.operation = "";
    window.number1 = 0;
    window.number2 = 0;
    document.getElementById("result1").innerHTML = "Hesap makineniz yeni işlemler için temizlenmiştir.";
}



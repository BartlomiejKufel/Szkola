const validator = require('validator');
const colors = require('colors')

const param = process.argv[2];

if(validator.isEmail(param))
    console.log(colors.green(param))
else
    console.log(colors.red(param))

//jeśli nie masz folderu node_modules użyj komędy 
//$npm i
//by zainstalować odpowiednie moduły wystarczy plik package.json
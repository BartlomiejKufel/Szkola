const fs =require('fs')
const {pi, sum, subtract}=require('./libs/math')
const podkar = require('./libs/locations/podkarpackie')


//console.log("Ale jesteś",process.argv[2]);
/* 
console.log(`Stała pi: ${pi}`)

let x=5
let y=4

console.log(`${x} + ${y} = ${sum(x,y)}`) 
*/


console.log(`Stolicą podkarpacia jest ${podkar.capital.name} i ma ${podkar.capital.population} mieszkańców.`)
console.log(`Rzeki na podkarpaciu:`)
podkar.rivers().forEach(r => {
	console.log(`-${r}`);
});


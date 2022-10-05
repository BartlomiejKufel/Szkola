const express = require('express')

const router = express.Router()





router.get('/flowers',(req,res)=>{
    res.send('<img src="img/flowers.jpg" alt="flowers"/>')
})


router.get('/day/:device',(req,res)=>{
    const day = req.params.device
    let response = "<h2>Wybierz liczbę od 1 do 7</h2>"

    switch(day){
        case '1': response = "<h2>Poniedziałek</h2>";break;
        case '2': response = "<h2>Wtorek</h2>";break;
        case '3': response = "<h2>Środa</h2>";break;
        case '4': response = "<h2>Czwartek</h2>";break;
        case '5': response = "<h2>Piątek</h2>";break;
        case '6': response = "<h2>Sobota</h2>";break;
        case '7': response = "<h2>Niedziela</h2>";break;
    }

    res.send(response)
})


router.use((req,res)=>{
    res.status(404)
    res.send('<img src="img/404.png" alt="Page not found"/>')
})

module.exports = router
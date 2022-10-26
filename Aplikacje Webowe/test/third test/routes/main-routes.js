const express = require('express')
const app = express()
const router = express.Router()

router.get('/', (req,res)=>{
    res.render('index', {name: "Bartłomiej Kufel"})
})

router.get('/locations',(req, res)=>{
    
    
    res.render('locations', {
        city1: "Warszawa",
        city2: "Kraków",
        city3: "Jasło"
    })
})
module.exports = router
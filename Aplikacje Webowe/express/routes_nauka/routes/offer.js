const express = require('express')
const router = express.Router()


router.get('/services', (req,res)=>{
    res.send('Usługi')
})


//przykład parametru trasy
router.get('/products/:device', (req,res)=>{
    const device = req.params.device
    let response = "<h2>Nie znaleziono sprzętu</h2>"

    switch(device){
        case 'gpu1':response="<h2>Nvidia GeForce RTX 3050</h2>";break;
        case 'gpu2':response="<h2>Nvidia GeForce RTX 3070 Ti</h2>";break;
    }
    
    res.send(response)
})


router.get('/products', (req,res)=>{
    res.send('Produkty')
})

router.get('/prices', (req,res)=>{
    res.send('Cennik usług i produktów')
})


module.exports = router
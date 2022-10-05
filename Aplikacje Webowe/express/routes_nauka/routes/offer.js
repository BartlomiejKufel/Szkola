const express = require('express')
const router = express.Router()


router.get('/services', (req,res)=>{
    res.send('Usługi')
})

router.get('/products', (req,res)=>{
    res.send('Produkty')
})

router.get('/prices', (req,res)=>{
    res.send('Cennik usług i produktów')
})


module.exports = router
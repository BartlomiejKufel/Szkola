const express = require('express')

const router = express.Router()


router.get('/', (req,res)=>{
    res.send('Strona główna')
})

router.get('/contacts', (req,res)=>{
    res.send('Kontakt')
})

router.get('/about', (req,res)=>{
    res.send('O nas')
})



module.exports = router
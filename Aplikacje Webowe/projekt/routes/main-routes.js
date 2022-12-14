const express = require('express')

const router = express.Router()


router.get('/',(req, res)=>{
    res.render('index', {
        pageTitle: "MU | Strona główna"
    })
})

router.get('/about',(req, res)=>{
    res.render('about', {
        pageTitle: "MU | O nas"
    })
})

router.get('/contact',(req, res)=>{
    res.render('contact', {
        pageTitle: "MU | Kontakt"
    })
})

module.exports = router
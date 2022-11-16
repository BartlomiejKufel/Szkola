const express = require('express')

const router = express.Router()

router.get('/',(req, res)=>{
    
    
    res.render('index',{
        pageTitle: "Lista pracowników",
    })
})


router.get('/about',(req, res)=>{
    res.render('about',{
        pageTitle: "O nas",
    })
})

module.exports = router
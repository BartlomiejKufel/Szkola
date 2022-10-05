const express = require('express')

const router = express.Router()



router.use((req,res)=>{
    res.status(404)
    res.send('<img src="img/404.png" alt="Page not found"/>')
})


router.get('/flowers',(req,res)=>{
    res.send('<img src="img/flowers.jpg" alt="flowers"/>')
})

module.exports = router
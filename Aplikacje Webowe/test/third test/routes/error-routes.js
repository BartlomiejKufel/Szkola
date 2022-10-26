const express = require('express')

const router = express.Router()

router.use((err, req, res, next)=>{
    res.status(500)
    res.render('500')
})

router.use((req,res,next) =>{
    res.status(404)
    res.render('404')

})

module.exports = router
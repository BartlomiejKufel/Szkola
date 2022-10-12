const express = require('express')
const app = express()
const router = express.Router()

router.use((req,res)=>{
    res.status(404)
    res.render('404',{message:"Page not Found!"})
})

router.use((err,req,res)=>{
    res.status(500)
    res.render('500',{message:"Internal Server Error"})
})


module.exports = router
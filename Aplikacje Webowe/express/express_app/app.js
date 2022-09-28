const express = require('express')
const app = express()


app.use((req,res,next) =>{
    console.log('Byłem na trasie /')
    next()

})


app.get('/about', (req,res,next)=>{
    res.send('<h1>Jestem Bartek</h1>')
})



app.listen(4000)
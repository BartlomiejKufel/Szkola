const express = require('express')

const app = express()

app.get('/', (req,res,next) =>{
    res.send('<h1>Hello world<h1/>')
})

app.get('/about', (req,res,next) =>{
    res.send('<h1>Uczymy się w technikum<h1/>')
})



app.use((req, res, next)=>{
    res.status(404);
    res.send('<h1>Page not found!</h1>')
})



app.listen(3000)

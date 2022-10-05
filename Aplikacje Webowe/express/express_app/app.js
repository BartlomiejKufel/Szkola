const express = require('express')
const path = require('path')
const app = express()


app.get('/about', (req,res,next)=>{
    res.send('<h1>Jestem Bartek</h1>')
})

app.get('/json',(req,res)=>{
    res.json({
        message: 'Witaj swiecie',
        version: '1.0',
        currentYear: new Date().getFullYear()
    })
})

app.get('/contact',(req,res)=>{
    const filePath = path.join(__dirname,"/views/contact.html")
    res.sendFile(filePath)
})

app.get('/calc',(req,res)=>{
    const filePath = path.join(__dirname,"/views/calc.html")
    res.sendFile(filePath)
    const dane={
        num1: req.query.num1,
        num2: req.query.num2,
        dzialanie: req.query.dzialanie,
    }

    

})

app.get('/greeting',(req,res)=>{
    const firstname = req.query.firstname;
    res.send('<h1>Witam na stronie, '+firstname+'</h1>')
})

//https://umbraco.com/knowledge-base/http-status-codes/
//link do listy błędów 
app.use((req, res, next)=>{
    res.status(500)
    res.send('<h1>Błąd serwera (500)</h1>')
})

app.use((req,res,next) =>{
    res.status(404)
    res.send('<h1>Page Not Found</h1>')

})


app.listen(4000)
const express = require('express')
const app = express()
const path = require('path')

const publicPath = path.join(__dirname, "public")
app.use(express.static(publicPath))

app.get('/services', (req,res)=>{
    res.send('Usługi')
})

app.get('/products', (req,res)=>{
    res.send('Produkty')
})

app.get('/contacts', (req,res)=>{
    res.send('Kontakt')
})

app.get('/about', (req,res)=>{
    res.send('O nas')
})

app.get('/', (req,res)=>{
    res.send('Strona główna')
})

app.get('/flowers',(req,res)=>{
    res.send('<img src="img/flowers.jpg" alt="flowers"/>')
})



app.use((req,res)=>{
    res.send('<img src="img/404.png" alt="Page not found"/>')
})
app.listen(4000)
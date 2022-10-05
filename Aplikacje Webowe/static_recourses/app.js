const express = require('express')
const path = require('path')
const app = express()

const publicPath = path.join(__dirname, "public")
app.use(express.static(publicPath))

app.get('/', (req,res)=>{
    res.send('Working!')
})


app.listen(4000)
const express= require('express')
const { dirname } = require('path')
const app = express()
const path = require('path')

app.get("/home",(req,res)=>{
    res.send("<h1>Sprawdzian</h1><p>Bartłomiej Kufel</p>")
})


app.get("/school", (req, res)=>{
    res.json({
        nazwa: "ZST Jasło",
        adres: "ul. Staszica 30",
        kierunek: "technik programista"
    })
    
})

app.get("/skills", (req, res)=>{
    const skillsPath=path.join(__dirname, "/views/skills.html")
    res.sendFile(skillsPath)
})

app.use((req, res)=>{
    res.status(404)
    res.send('błąd 404')
})


app.use((req, res)=>{
    res.status(500)
    res.send('bład 500')
    
})

app.listen(3000)
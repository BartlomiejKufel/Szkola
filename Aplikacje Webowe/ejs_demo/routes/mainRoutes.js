const express = require('express')
const app = express()
const router = express.Router()

router.get('/', (req,res)=>{
    res.render('home')
})

router.get('/contact',(req,res)=>{
    res.render('contact',{
        title:"Kontakt",
        message: "Skontaktuj sie z nami.",
        email: "kowalski@test.com"
    })
})

router.get('/offer',(req,res)=>{
    const ourOffer = [
        'naprawa sprzętu IT', 
        'projektowanie sieci komputerowych',
        'sprzedaż części komputerowych',
        'szkolenie IT'
        ]


    res.render('offer',{items: ourOffer})
})
module.exports = router
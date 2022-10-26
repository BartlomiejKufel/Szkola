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

router.get('/locations',(req,res)=>{
    const locations =[
        {
            name: "Jasło", 
            street: "ul. Wiśniowa 3", 
            zipCode: "38-200"
        },
        {
            name: "Krosno", 
            street: "ul. Pomarańczowa 14", 
            zipCode: "38-400"
        },
        {
            name: "Gorlice", 
            street: "ul. Kiwi 30", 
            zipCode: "38-400"
        }]

        res.render('locations', {locations: locations})
})

router.get('/team',(req,res)=>{
    res.render('team', {
        pageTitle: "Nasz zespół"
    })
})


module.exports = router
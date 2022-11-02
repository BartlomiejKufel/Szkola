const express = require('express')

const router = express.Router()

router.get('/calc-get',(req, res)=>{
    let n1 = req.query.number1
    let n2 = req.query.number2
    let result

    if(n1 === undefined){
        result = ""     
    }else{
        let sum = parseInt(n1) + parseInt(n2)

        result = `${n1} + ${n2} = ${sum}`
    }
    
    res.render('calc-get',{
        pageTittle: "Kalkuator - metoda GET",
        result: result,
    })
})

router.get('/login-get',(req, res)=>{
    let result ="Nie zalogowano"
    const credentials = [
        {
            email: "a@bazyk.com",
            password:"ab",
        },
        {
            email: "ja@gmail.com",
            password:"123",
        },
        {
            email: "kacper@kiwi.com",
            password:"kiwi123",
        },
    ]

    let enterdEmail = req.query.email
    let enterdPassword = req.query.password

    credentials.forEach(user => {
        if(user.email ==enterdEmail && user.password==enterdPassword)
            result = `Zalogowano ${user.email}`
    });

    res.render('login-gets',{
        result: result,
    })
})

module.exports = router
const express = require('express')
const router = express.Router()

const User = require('../models/Users')

router.get('/users',async(req, res)=>{
    const users = await User.find();
    
    res.render('users', {
        pageTitle: "MU | Użytkownicy",
        users:users
    })
})

router.post('/users',async(req,res)=>{
    const newUser ={
        firstname: req.body.firstname,
        lastname: req.body.lastname,
        birthdate: new Date(req.body.birthdate),
        joinDate: new Date(),
        active: req.body.active ==="on" ? true : false,
    }

    try {
        await new User(newUser).save()
    } catch (error) {
        
    }

    res.redirect('/users')
})



module.exports = router
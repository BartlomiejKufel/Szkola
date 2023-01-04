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
    const sex = req.body.sex;
    let gender = ""
    switch (sex) {
        case "M": gender= "Mężczyzna"; break;
        case "K": gender= "Kobieta"; break;
    
        default: gender = "Inne" 
            break;
    }

    const newUser ={
        firstname: req.body.firstname,
        lastname: req.body.lastname,
        birthdate: new Date(req.body.birthdate),
        joinDate: new Date(),
        active: req.body.active ==="on" ? true : false,
        sex: gender
    }

    try {
        await new User(newUser).save()
    } catch (error) {
        
    }
    res.redirect('/users')
})

router.post('/delete', async(req,res)=>{
    const id = req.body.userId;
    try {
        await User.findByIdAndDelete(id)
    } catch (error) {
        console.log(error.message)
    }


    res.redirect('/users')
})

async function formatDate(date) {
        let month = "" + (date.getMonth()+1),
        day = "" + date.getDate(),
        year = date.getFullYear()

    if (month.length < 2) 
        month = "0" + month
    if (day.length < 2) 
        day = "0" + day

    return year+"-"+month+"-"+day;
}

router.post('/edit', async(req,res)=>{
    const id = req.body.userId;
    

    try {
        const userToEdit = await User.findById(id)
        const birthdateStr = await formatDate(userToEdit.birthdate)
        res.render('edit', {
        pageTitle: "MU | Edycja użytkownika",
        user: userToEdit,
        birthdateStr: birthdateStr
        })
    } catch (err) {
        console.log(err.message);
    }


})



router.post('/update', async(req,res)=>{
    const applyBtn = req.body.applyBtn

    if(applyBtn === undefined){
        res.redirect('/users')
    }
    
    const id = req.body.userId
    const editedUser ={
        firstname: req.body.firstname,
        lastname: req.body.lastname,
        birthdate: new Date(req.body.birthdate),
        active: req.body.active ==="on" ? true : false,
    } 

    try {
        await User.findByIdAndUpdate(id, editedUser)
    } catch (error) {
        console.log(error.message)
    }
    res.redirect('/users')
})


router.post('/details', async(req,res)=>{
    const id = req.body.userId;

    try {
        const userToEdit = await User.findById(id)
        res.render('details', {
        pageTitle: "MU | szczegóły użytkownika",
        user: userToEdit,
        })
    } catch (err) {
        console.log(err.message);
    }


})



module.exports = router
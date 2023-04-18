const User = require('../models/user')

exports.getLogin =  (req,res)=>{
    res.render("login",{
        pageTitle: "Logowanie",
    })
}


exports.getSingup =  (req,res)=>{
    res.render("singup",{
        pageTitle: "Tworzenie konta",
    })
}

exports.postSingup = (req, res) =>{
    let firstname = req.body.firstname
    let email = req.body.email
    let password = req.body.password
    let repetedPassword = req.body.repetedPassword

    if(password !== repetedPassword){
        

        return
    }

}
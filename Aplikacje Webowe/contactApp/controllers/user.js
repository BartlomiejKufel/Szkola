const User = require('../models/user')

exports.getLogin =  (req,res)=>{
    if(req.session.isLoggedIn){
        res.redirect("/profile")
        return
    }


    let msg ="";
    const msgNumber = req.query.msg;
    msg = msgErrors(msgNumber)

    res.render("login",{
        pageTitle: "Logowanie",
        errorMsg: msg,
    })
}


exports.postLogin = async(req,res)=>{
    let email = req.body.email
    let password = req.body.password

    const users = await User.find()
    let isLoggedIn = false;

    users.forEach(u => {
        if(u.email === email && u.password === password)
            isLoggedIn=true
    });

    if(!isLoggedIn){
        res.redirect('/?msg=3')
        return
    }

    req.session.isLoggedIn = true;
    res.redirect('/profile')
}




exports.getSingup = (req,res)=>{
    let msg =""
    const msgNumber = req.query.msg;
    msg = msgErrors(msgNumber)

    res.render("singup",{
        pageTitle: "Tworzenie konta",
        errorMsg: msg,
    })
}


exports.postSingup = async(req, res) =>{
    let firstname = req.body.firstname
    let email = req.body.email
    let password = req.body.password
    let repetedPassword = req.body.repetedPassword

    if(password !== repetedPassword){
        res.redirect('/singup?msg=1')
        return
    }

    const users = await User.find()
    let userExist = false;

    users.forEach(e => {
        if(e.email===email){
            userExist = true
        } 
    });

    if(userExist){
        res.redirect('/singup?msg=2')
        return
    }
    
    const newUser = {
        firstname: firstname,
        email: email,
        password: password,
    }
    
    try {
        await new User(newUser).save()
    } catch (error) {
        console.log(error.message)
    }

    await res.redirect('/singup?msg=0')
}


exports.getProfile = (req,res)=>{
    res.render("profile",{
        pageTitle:"Profil",
    })
}

exports.postLogout = (req,res)=>{
    req.session.destroy(() => {
        res.redirect("/");
    });
}





//przypisywanie treści błędu 
function msgErrors(msgNumber) {
    switch (msgNumber) {
        case "0": return "Konto zostało poprawnie dodane"
        case "1": return "Hasła są różne"
        case "2": return "Podany email jest już używany"
        case "3": return "Błąd w emailu lub haśle"
    }
}
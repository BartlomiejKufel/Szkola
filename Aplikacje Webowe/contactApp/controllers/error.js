exports.get404 = (req,res,next)=>{
    res.status(404)
    res.render("404",{
        pageTitle: "Błąd 404"
    })
}

exports.get500 =(err, req, res, next)=>{
    res.status(500)
    res.render("500",{
        pageTitle: "Błąd 500"
    })
}
const Trips = require("../models/Trips");



exports.getMain = async(req, res) => {
    const trips = await Trips.find()    
    let show = true;
    if(trips.length<=0)
        show = false

    res.render("index",{
        trips:trips,
        IsShow:show
    });
}

exports.postAdd = async(req,res) =>{
    const newTrip = {
        name: req.body.name,
        description: req.body.description,
        rate: req.body.rate,
    }

    try {
        await new Trips(newTrip).save()
    } catch (error) {
        console.log(error.message)
    }
    res.redirect("/")
}


exports.postDelete = async(req,res) => {
    try {
        const idToRemove = req.body.id
        await Trips.findByIdAndDelete(idToRemove)
    } catch (error) {
        console.log(error.message);
    }

    res.redirect("/")
}


exports.postGoEdit = async(req,res) => {
    const idToEdit = req.body.idEdit
    
    res.redirect("/edit?id="+idToEdit)
}

exports.getEdit = async(req,res) =>{
    const id = req.query.id
    const tripToEdit = await Trips.findById(id)
    
    res.render("edit",{
        TripToEdit: tripToEdit 
    })
}

exports.postEdit = async(req,res) =>{
    const id = req.body.id
    const updateTrip = {
        name: req.body.name,
        description: req.body.description,
        rate: req.body.rate,
    }

    try {
        await Trips.findByIdAndUpdate(id, updateTrip)
    } catch (error) {
        console.log(error.message);
    }

    res.redirect("/")
}
const express = require('express')
const router = express.Router()

const Song = require('../models/Song')

router.get('/',async(req, res)=>{
    const songs = await Song.find()


    res.render('index',{
        pageTitle: "Playlista | Ulubione",
        songs: songs
    })
})

router.post('/',async(req, res)=>{
    const newSong ={
        title: req.body.title,
        band: req.body.band,
        publicationYear: req.body.publicationYear,
        country: req.body.country
    }

    try {
        await new Song(newSong).save()
    } catch (error) {
        console.log(error.message)
    }
    res.redirect('/')
})


router.post('/delete', async(req,res)=>{
    const id = req.body.songId;
    try {
        await Song.findByIdAndDelete(id)
    } catch (error) {
        console.log(error.message)
    }

    res.redirect('/')
})

router.post('/edit', async(req,res)=>{
    const id = req.body.songId;
    

    try {
        const songToEdit = await Song.findById(id)
        res.render('edit', {
        pageTitle: "Playlista | Edycja piosenki",
        song: songToEdit,
        })
    } catch (err) {
        console.log(err.message);
    }

})

module.exports = router
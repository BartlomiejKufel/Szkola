const mongoose = require('mongoose')


const songScheme = new mongoose.Schema({
    title: String,
    band: String,
    publicationYear: Number,
    country: String

})

module.exports = mongoose.model('Song', songScheme)
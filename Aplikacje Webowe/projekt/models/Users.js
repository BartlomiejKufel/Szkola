const mongoose = require('mongoose')

const userScheme = mongoose.Schema({
    firstname: String,
    lastname: String,
    birthdate: Date,
    joinDate: Date,
    active: Boolean,

})

module.exports = mongoose.model('User', userScheme)
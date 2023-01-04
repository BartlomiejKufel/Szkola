const mongoose = require('mongoose')


const userScheme = mongoose.Schema({
    firstname: String,
    lastname: String,
    birthdate: Date,
    joinDate: Date,
    active: Boolean,
    sex: String

})

module.exports = mongoose.model('User', userScheme)
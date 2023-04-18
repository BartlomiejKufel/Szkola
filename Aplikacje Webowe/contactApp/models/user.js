const mongoose = require("mongoose")
const userSchema = mongoose.Schema({
    firstname: String,
    email:String,
    password: String,
})

module.exports = mongoose.model("User", userSchema) 
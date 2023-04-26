const mongoose = require("mongoose")
const tripSchema = mongoose.Schema({
    name: String,
    description: String,
    rate: Number,
})

module.exports = mongoose.model("Trip", tripSchema) 
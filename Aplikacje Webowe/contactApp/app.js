const express = require("express");
const app = express()
const path = require('path')
const bodyParser = require('body-parser')
const mongoose = require('mongoose')

const mainRoutes = require('./routes/main-routes')
const errorRoutes = require('./routes/error-routes')



mongoose.set('strictQuery', false)

mongoose.connect("mongodb://127.0.0.1:27017/", () => {
    console.log("Connected to MongoDB");
});


const publicPath = path.join(__dirname, 'public')
app.use(express.static(publicPath))

app.set('view engine', 'ejs')
app.set('views','./views')

app.use(bodyParser.urlencoded({ extended: false }))


app.use(mainRoutes)
app.use(errorRoutes)

app.listen(3000)

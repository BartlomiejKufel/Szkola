const express = require('express')
const app = express()
const path = require('path')
const bodyParser = require('body-parser')
const mongoose = require('mongoose')


const port = 3000;

//ejs
app.set('view engine', 'ejs')
app.set('views','./views')


const mainRoutes = require('./routes/main-routes')
const errorRoutes = require('./routes/error-routes')
const dbRoutes = require('./routes/db-routes')



//połączenie z bazą danych
mongoose.connect('mongodb://localhost:27017/usersManagment')



//zasoby statyczne
const publicPath = path.join(__dirname,'/public')
app.use(express.static(publicPath))

//body-parser
app.use(bodyParser.urlencoded({ extended: false }))


app.use(mainRoutes)
app.use(dbRoutes)
app.use(errorRoutes)


app.listen(port, ()=>{
    console.log(`Server is running on port ${port}.`);
})
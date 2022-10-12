const express = require('express')
const path = require('path')
const mainRoute = require('./routes/mainRoutes')
const newRoute = require('./routes/new')

const app = express()

const publicPath=path.join(__dirname,'public')
app.use(express.static(publicPath))

//konfiguracja ejs
app.set('view engine', 'ejs')
app.set('views','./views')


app.use(mainRoute)
app.use(newRoute)

app.listen(4000)
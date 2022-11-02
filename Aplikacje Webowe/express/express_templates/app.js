const express = require('express')
const app = express()
const path = require('path')

const mainRoutes = require('./routes/main-routes')
const errorRoutes = require('./routes/error-routes')


const publicPath = path.join(__dirname, 'public')
app.use(express.static(publicPath))

app.set('view engine', 'ejs')
app.set('views','./views')


app.use(mainRoutes)
app.use(errorRoutes)

app.listen(4000)
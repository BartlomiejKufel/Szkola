const express = require('express')
const path = require('path')

const companyRoute = require('./routes/company')
const offerRoute = require('./routes/offer')
const maitainceRoute = require('./routes/maitaince')

const app = express()

const publicPath = path.join(__dirname, "public")
app.use(express.static(publicPath))

app.use(companyRoute)
app.use(offerRoute)
app.use(maitainceRoute)



app.listen(4000)
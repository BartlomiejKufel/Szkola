const path = require("path");
const express = require("express");
const bodyParser = require("body-parser");
const mongoose = require('mongoose');
const mainRoutes = require("./routes/main-routes")
const app = express();


//mongoose
mongoose.connect('mongodb://127.0.0.1:27017/trips')
  .then(() => console.log('Connected!'))

// static resources
app.use(express.static(path.join(__dirname, "public")));

// ejs config
app.set("view engine", "ejs");
app.set("views", "./views");

// body parser config
app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());

app.use(mainRoutes)


app.listen(3000);

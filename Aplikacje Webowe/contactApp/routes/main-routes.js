const express = require('express')
const router = express.Router()

const userController = require("../controllers/user")

router.get("/", userController.getLogin)

router.get("/singup", userController.getSingup)
router.post("/singup", userController.postSingup)

module.exports = router
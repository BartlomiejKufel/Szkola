const express = require('express')
const router = express.Router()

const userController = require("../controllers/user")

router.get("/", userController.getLogin)
router.post("/", userController.postLogin)

router.get("/singup", userController.getSingup)
router.post("/singup", userController.postSingup)

router.get("/profile", userController.getProfile)
router.post("/logout", userController.postLogout)

module.exports = router
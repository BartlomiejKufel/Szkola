const express = require('express')
const router = express.Router()

const mainController = require("../controllers/main")

router.get("/", mainController.getMain)
router.post("/add", mainController.postAdd)

router.post("/delete", mainController.postDelete)


router.get("/edit", mainController.getEdit)
router.post("/goEdit", mainController.postGoEdit)
router.post("/edit", mainController.postEdit)

module.exports = router
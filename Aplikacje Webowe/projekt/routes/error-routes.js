const express = require('express')

const router = express.Router()

router.use((req, res, next) => {
    res.send('404 page')
    res.status(404)
})


router.use((err, req, res, next) => {
    res.send('500 page')
    res.status(500)
})

module.exports = router
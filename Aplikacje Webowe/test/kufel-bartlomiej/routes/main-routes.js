const express = require('express')

const router = express.Router()

let array =[
    {
        name: "Sprzątanie pokoju",
        import: false
    },
    {
        name:"Wyprowadzanie psa",
        import: false
    },
    {
        name:"Nauka",
        import: true
    },
]

router.get('/',(req, res)=>{
    res.render('index',{
        array:array,
    })
})

router.post('/',(req, res)=>{

    let reqName = req.body.name
    let reqImport = req.body.important

    array.push({name:reqName, import: reqImport})


    res.render('index',{
        array:array,
    })
})

module.exports = router
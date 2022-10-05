const mat = require('./mat/okrag')
const http = require('http')
const fs = require('fs')


console.log(mat.pole(10))
console.log(mat.obwod(10))


const server = http.createServer((req, res) =>{
    res.setHeader('Content-Type', 'text/html')
    const page = fs.readFileSync('./bartlomiej.html')
    res.write(page)

    res.end()
})
server.listen(3050)
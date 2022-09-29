//uruchomienie przez servera przez konsole: node app1.js

const http = require('http')

const server = http.createServer((request, response) =>{
    response.setHeader('Content-Type','text/html')
    response.write("Hello world")

    response.end()
})

server.listen(3000)

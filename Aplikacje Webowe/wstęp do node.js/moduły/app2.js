const fs = require('fs')
const http = require('http')

const server = http.createServer((req, res) =>{
    const route = req.url
    
    res.setHeader('Content-Type', 'text/html')

    if(route === "/create"){
        fs.appendFileSync('my-rout.txt', new Date().toLocaleTimeString()+'\n')
        
        
        res.end();
        return
    }


    let pagePath= "./404.html"

    switch(route){
        case "/": pagePath="./index.html";break;
        case "/about": pagePath="./about.html";break;
        case "/contact": pagePath="./contact.html";break;
        case "/services": pagePath="./services.html";break;

        
    }

    const page= fs.readFileSync(pagePath)
    
    res.write(page)

    res.end()
})

server.listen(3000)
server.listen();

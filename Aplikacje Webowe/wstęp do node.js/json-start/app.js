const http = require('http')

const user ={
    name: 'Jan',
    age: 30,
    email: 'janmarek@gmail.com',
    isSmoking: false
}
console.log(user)

const userJASON = JSON.stringify(user)
console.log(userJASON)

const userJS = JSON.parse(userJASON)
console.log(userJS);


const server = http.createServer((req, res) =>{
    res.setHeader('Content-Type', 'application/json')
    res.write(userJASON)
    res.end()
})
server.listen(3050)
function sayHello() {
    
    const greetingH1 = document.createElement('h1')
    greetingH1.textContent = "Witaj na mojej stronie!"
    
    const body= document.querySelector('body')
    body.append(greetingH1)
    
}
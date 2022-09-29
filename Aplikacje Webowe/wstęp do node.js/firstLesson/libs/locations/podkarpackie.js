const capital= {
        name: "Rzeszów",
        population: 183901,
        isCity: true,
        web: "www.rzeszow.pl"
    }
const townsArr=["Jasło","Krosno","Lubaczów"]
const riversArr=["Jasiołka", "Ropa", "Wisłoka"]

const towns=()=>{
    return townsArr
}

const rivers = () =>{
    return riversArr
}

module.exports={
    towns: towns,
    rivers: rivers,
    capital: capital,

}
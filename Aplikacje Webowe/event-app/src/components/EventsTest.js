import "./EventsTest.css"




function showAlertHendler(){
    alert("Naciśnięto przycisk")
}

function nameChangeHandler() {
    console.log("Zmieniono pole Imię");
}

function lastnameFocusHandler() {
    console.log("Pole Nazwisko stało się aktywne");
}


function EventsTest() {
    return (
    <>
        <h2>Demo zdażeń</h2>
        Imię: <input type="text" onChange={nameChangeHandler}/> <br/>
        Nazwisko: <input type="text" onFocus={lastnameFocusHandler}/> <br/>
        Wiek: <input type="number"/> <br/>

        <button onClick={showAlertHendler}>Pokaż okno</button>

    </>
    )
}

export default EventsTest
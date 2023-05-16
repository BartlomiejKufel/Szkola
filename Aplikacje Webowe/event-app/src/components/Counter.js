import {useState} from "react"
import "./Counter.css"

function Counter() {
    const [count, setCount] = useState(0)

    function decreaseClickHandler() {
        setCount(count-1)
    }

    function increaseClickHandler(){
        setCount(count+1)
    }


    return (
        <>
            <h2>Licznik</h2>
            <button onClick={decreaseClickHandler}> - </button>
            {count}
            <button onClick={increaseClickHandler}> + </button>
        </>
    )
}

export default Counter
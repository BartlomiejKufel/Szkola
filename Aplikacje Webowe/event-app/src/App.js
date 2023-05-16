import './App.css';
import Counter from './components/Counter';
// import EventsTest from './components/EventsTest';
import {useState} from "react";
import About from './components/About'


function App() {

  const [theme, setTheme] = useState('light-theme')
  const [about, setAbout] = useState(false)

  function aboutClickHandler(params) {
    if(about === false)
      setAbout(true)
    else
     setAbout(false)
  }

  function themeClickHandler(params) {
    if(theme === "light-theme")
      setTheme("dark-theme")
    else
      setTheme("light-theme")
  
  }

  return (
    <>
    <div className={theme}>
      <h1>Lets go</h1>
      {/* <EventsTest></EventsTest> */}
      <Counter/><br/><br/>


      <button onClick={aboutClickHandler}>Credits</button><br/>
      {about && <About/>}

      <br/>
      <button onClick={themeClickHandler}>Zmień motyw</button>
    </div>
    </>
  );
}


export default App;

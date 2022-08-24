import "./App.css";
import JSON from "./mock_data.json";
import {useState} from 'react';

function App() {

  const [searchTerm, setSearchTerm] = useState('');

return(
  <div className="App">
    {/* setting the setSearchTerm to anything that is entered in the input. */}
    <input type = "text" placeholder = "Search..." onChange = {(event) => {setSearchTerm(event.target.value)}}/>
    
    {JSON.filter((obj) => {
      if (searchTerm == ''){
        return obj;
      }else if(obj.first_name.toLowerCase().includes(searchTerm.toLowerCase()) || obj.last_name.toLowerCase().includes(searchTerm.toLowerCase())){
        return obj;
      }
    }).map((obj, key)=>{
      return(
        <div className = "user" key = {key}>
        <p>{obj.first_name} {obj.last_name}</p>
        </div>
      )
    })}
  </div>
)

}

export default App;
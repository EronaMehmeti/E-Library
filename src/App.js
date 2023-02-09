import './App.css';
import {BrowserRouter, Route, Switch} from 'react-router-dom';

import LogIn from './LogIn';



function App() {
  return (
    <>  
    <BrowserRouter>
    <Switch>

   <Route path='/' component={LogIn} exact/>
  
   </Switch>
   </BrowserRouter>


    </>
 );
}

export default App;

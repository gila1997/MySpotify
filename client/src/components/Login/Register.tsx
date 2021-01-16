import React, { Component, useState } from 'react';
import MuiThemeProvider from 'material-ui/styles/MuiThemeProvider';
import AppBar from 'material-ui/AppBar';
import RaisedButton from 'material-ui/RaisedButton';
import TextField from 'material-ui/TextField';
import {registerUser} from '../../api/api'
import { Redirect } from "react-router";
export interface UserInformation {
  firstName: string;
  lastName: string;
  email: string;
  password: string;
  succeedRegister: Boolean;
}
export default function Register() {
  const [firstName,setFirstName] = useState('');
  const [lastName,setLastName] = useState('');
  const [email,setEmail] = useState('');
  const [password,setPassword] = useState('');
  const [succeedRegister,setSucceedRegister] = useState(false);
 function register(){
     registerUser(email,password).then(response=> {
     console.log(response);
     if(response == true){
      setSucceedRegister(true);
     }
     else {
        alert('failure');
     }
   })
   .catch(function (error) {
     console.log(error);
   });
  }
  
    if(succeedRegister === true)
    return  (<Redirect to="/login" />);
    else
    return (
      <div>
        <MuiThemeProvider>
          <div>
          <AppBar
             title="Register"
           />
           <TextField
             hintText="Enter your First Name"
             floatingLabelText="First Name"
             onChange = {(event,newValue) => setFirstName(newValue)}
             />
           <br/>
           <TextField
             hintText="Enter your Last Name"
             floatingLabelText="Last Name"
             onChange = {(event,newValue) => setLastName(newValue)}
             />
           <br/>
           <TextField
             hintText="Enter your Email"
             type="email"
             floatingLabelText="Email"
             onChange = {(event,newValue) => setEmail(newValue)}
             />
           <br/>
           <TextField
             type = "password"
             hintText="Enter your Password"
             floatingLabelText="Password"
             onChange = {(event,newValue) => setPassword(newValue)}
             />
           <br/>
           <RaisedButton label="Submit" primary={true} style={style} onClick={(event) => register()}/>
          </div>
         </MuiThemeProvider>
      </div>
    );
}

const style = {
  margin: 15,
};
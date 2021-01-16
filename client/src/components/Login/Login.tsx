import React, {useState, Component } from 'react';
import MuiThemeProvider from 'material-ui/styles/MuiThemeProvider';
import AppBar from 'material-ui/AppBar';
import RaisedButton from 'material-ui/RaisedButton';
import TextField from 'material-ui/TextField';
import alert from 'alert'
import "./Login.scss";
import { Redirect, Route } from "react-router";
import {authenticateUser} from '../../api/api'
import { MDBContainer, MDBRow, MDBCol, MDBInput, MDBBtn } from 'mdbreact';

export default function Login() {
  const [username,setUsername] = useState('');
  const [password,setPassword] = useState('');
  const [succeedLogin,setSucceedLogin] = useState(false);
  function login(){
    authenticateUser(username,password ).then(response=> {
     console.log(response);
     if(response != null){
      setSucceedLogin(true);
     }
     else {
        alert('Username password do not match,please try again');
     }
   })
   .catch(function (error) {
     console.log(error);
   });
  }
  if(succeedLogin === true)
    return (<Redirect to="/album" />);
  else 
  return (
    <form>
      <h3>Sign In</h3>

                <div className="form-group">
                    <label>Email address</label>
                    <input type="email" className="form-control"  onChange = {(event) => setUsername(event.currentTarget.value)} placeholder="Enter email" />
                </div>

                <div className="form-group">
                    <label>Password</label>
                    <input type="password" className="form-control"  onChange = {(event) => setPassword(event.currentTarget.value)} placeholder="Enter password" />
                </div>

                <div className="form-group">
                    <div className="custom-control custom-checkbox">
                        <input type="checkbox" className="custom-control-input" id="customCheck1" />
                        <label className="custom-control-label" htmlFor="customCheck1">Remember me</label>
                    </div>
                </div>

                <button type="submit" onClick={(event) => login()} className="btn btn-primary btn-block">Submit</button>
                <p className="forgot-password text-right">
                    Forgot <a href="#">password?</a>
                </p>
            </form>
    
    // <div>
    //   <MuiThemeProvider>
    //     <div>
    //     <AppBar
    //        title="Login"
    //      />
    //      <TextField
    //        hintText="Enter your User Name"
    //        floatingLabelText="User Name"
    //        onChange = {(event,newValue) => setUsername(newValue)}
    //        />
    //      <br/>
    //      <TextField
    //        hintText="Enter your Password"
    //        floatingLabelText="Password"
    //        onChange = {(event,newValue) => setPassword(newValue)}
    //        />
    //      <br/>
    //      <RaisedButton label="Submit" primary={true} style={style} onClick={(event) => login()}/>
    //     </div>
    //    </MuiThemeProvider>
    // </div>
 
 );
  }

const style = {
  margin: 15,
};
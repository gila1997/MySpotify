import React from 'react';
import { Switch, Route, Redirect } from 'react-router-dom';

import Main from '../Main/Main';

import Login from '../Login/Login';
import Register from '../Login/Register';
import Albums from '../Albums/Albums';
import Welcome from '../Welcome/Welcome'
const Content = () => (
  <Main>
    <Switch>
      <Route exact path="/Welcome" component={Welcome} />
      <Route exact path="/login" component={Login} />
      <Route exact path="/register" component={Register} />
      <Route exact path="/album" component={Albums} />
      <Redirect from="*" to="/Welcome" />
    </Switch>
  </Main>
);

export default Content;

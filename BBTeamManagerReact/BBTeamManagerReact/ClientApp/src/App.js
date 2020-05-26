import React, { Component } from 'react';
import { Router, Route, Link } from 'react-router-dom';
import { Layout } from './components/Layout';

import { history } from './helpers/history';
import { authenticationService } from './services/authentication.service';
import { PrivateRoute } from './components/PrivateRoute';
import { Home } from './components/Home';
import { LoginPage } from './pages/LoginPage';
import { RegisterPage } from './pages/RegisterPage';



import './custom.css'

export default class App extends Component {
    static displayName = App.name;

    constructor(props) {
        super(props);
        this.state = {
            currentUser: null
        };

    }

    componentDidMount() {
        authenticationService.currentUser.subscribe(x => this.setState({ currentUser: x }));
    }

    logout() {
        authenticationService.logout();
        history.push('/login')
    }

    render() {
        const { currentUser } = this.state;
        return (
                <Router history={history}>
                    <div>
                            <nav className="navbar navbar-expand navbar-dark bg-dark">
                                <div className="navbar-nav">
                                <Link to="/" className="nav-item nav-link">Home</Link>
                                {currentUser &&
                                <Link onClick={this.logout} to="/" className="nav-item nav-link">Logout</Link>
                                }
                            {!currentUser &&
                                <React.Fragment>
                                    <Link onClick={this.logout} to="/" className="nav-item nav-link">Login</Link>
                                    <Link onClick={this.logout} to="/register" className="nav-item nav-link">Register</Link>
                                </React.Fragment>
                                } 
                                </div>
                            </nav>                        
                        <div className="jumbotron">
                            <div className="container">
                                <div className="row">
                                    <div className="col-md-6 offset-md-3">
                                        <PrivateRoute exact path="/" component={Home} />
                                        <Route exact path="/login" component={LoginPage} />
                                        <Route exact path="/register" component={RegisterPage} />

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </Router>
        );
    }
}

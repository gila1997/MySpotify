import React  from 'react';
import { Link } from 'react-router-dom';
import { Button} from 'react-bootstrap';
import MuiThemeProvider from 'material-ui/styles/MuiThemeProvider';

export default function Welcome () {
    
    return (
        <MuiThemeProvider>
            <div>
                <div className="mb-2">
                <Link to="/login">
                    <Button  type="button">Login</Button>
                    </Link>
                    </div>
                
                    <Link to="/register">
                        <Button type="button">Register</Button>
                        </Link>
            </div>
     </MuiThemeProvider>
    );
}
  
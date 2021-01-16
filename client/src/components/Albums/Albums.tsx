import React from 'react';
import { styled } from '@material-ui/core/styles';
import { makeStyles } from '@material-ui/core/styles';
import {getAlbums} from '../../api/server'
import {withRouter} from "react-router-dom";
const useStyles = makeStyles((theme) => ({
    root: {
        flexGrow: 1,
    },
    paper: {
        padding: theme.spacing(1),
        textAlign: 'center',
        color: theme.palette.text.secondary,
    },
}));

const Container = styled('aside')(({ theme }) => ({
    padding: '0.5em',
    overflowY: 'auto',
    [theme.breakpoints.down('xs')]: {
        overflowY: 'initial',
        overflowX: 'auto',
        padding: 0,
        display: 'flex',
    },
}));

const ScrollContainer = styled('div')(({ theme }) => ({
    [theme.breakpoints.down('xs')]: {
        display: 'flex',
    },
}));

export default function Albums (){
    
    const albums = getAlbums();
    console.log(albums);
        return (
    <Container>
                <ScrollContainer>
                   
                   
                </ScrollContainer>
            </Container>
    );
}



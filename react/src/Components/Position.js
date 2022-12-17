import { useNavigate } from 'react-router-dom'
import React from 'react'
import Button from '@mui/material/Button';
import Nav from '../nav.js'
import List from './ListView'


export default function Position() {
    const navigate = useNavigate();

    const positions = []
    return (
        <div>
            <Nav />
            <div className="position">
                <div id='listPosition'>
                    <List list={positions} onUpdate={() => navigate('/editPosition')}></List>
                </div>
                <br/>
                <div id='buttons'>
                <Button  variant="outlined" onClick={() => navigate('/editPosition')}>מיקום חדש</Button>
                
                </div>
            </div>
        </div>
    )
}
import { useNavigate ,useLocation } from 'react-router-dom'
import React from 'react'
import Form from './Form'
// import FormMDB from './FormMDB'
import Button from '@mui/material/Button';
import Nav from '../nav.js'

export default function EditTask() {
   const location = useLocation()
   const task = location?.state?.task

    const navigate = useNavigate();
    return (
        <div>
            <Nav />
            <div className="newTask">
                <h1>{task?'️עריכת משימה✏️': '✨משימה חדשה✨'}</h1>
                <div id='form'>
                    <Form task={task} />
                    {/* <FormMDB/> */}
                </div>
                <br></br>
                <div id='buttons'>
                 {/* React.useEffect() => async () => { */}
                 
                  {/* setTask(response.data); */}
                {/* <Button variant="outlined" onClick={() => navigate('/position')}>קבע מיקום</Button> */}
                {/* <Button variant="outlined" onClick={() =>navigate('/position')}>{task?'שמור':'קבע מיקום'}</Button> */}
                </div>
            </div>
        </div>
    )
}
/*test*/
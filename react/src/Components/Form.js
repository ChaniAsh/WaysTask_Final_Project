import * as React from 'react';
import Box from '@mui/material/Box';
import TextField from '@mui/material/TextField';
import Button from '@mui/material/Button';
import axios from 'axios'
import { useNavigate } from 'react-router-dom';

export default function Form(props) {
  const [task, setTask] = React.useState({Title: props?.task?.Title ||'', Description: props?.task?.Description ||''});


  const navigate = useNavigate()
  const handleChange = (event) => {
    const {name , value} = event.target
    setTask({...task,[name]: value});
  };

  const handleSave = () => {
   axios.post('https://localhost:44364/api/tasks/UpdateTask' ,{...props.task, ...task})
   .then(()=>navigate('/saveTask'))
  }

  return (
    <Box
      component="form"
      sx={{
        '& .MuiTextField-root': { m: 1, width: '25ch' },
      }}
      noValidate
      autoComplete="off"
    >
      <div id='title'>
        {/* כותרת משימה */}
        <TextField
          name='Title'
          id="outlined-multiline-flexible"
          label="נושא"
          value={task.Title}
          multiline
          maxRows={4}
          onChange={handleChange}
        />
        </div>
        <div id='discription'>
        <TextField
          name='Description'
          id="outlined-multiline-static"
          label="תאור"
          multiline
          rows={4}
          value={task.Description}
          onChange={handleChange}
        />
        </div>
        <div id='buttons'>
        <Button variant="outlined" onClick={props?.task?handleSave:() =>navigate('/position')}>{props?.task?'שמור':'קבע מיקום'}</Button>
        </div>     
    </Box>
  );
}

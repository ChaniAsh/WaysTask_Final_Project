import React from 'react'
import Nav from '../nav'
import ListView from "./ListView";
import axios from "axios";
import {useNavigate} from 'react-router-dom';
export default function SaveTask() {
    const navigate = useNavigate()

    
  const [tasks, setTask] = React.useState([])

  React.useEffect(() => async () => {
    let taskPromise = axios.get("https://localhost:44364/api/tasks/getAllTasks");
    let response = await taskPromise;
    setTask(response.data);
  },
    [])


    const handleEdit = (task) => {
      navigate('/EditTask' ,{state: { task }} ) 
    }

    return (
        <div>
            {/* <div id='logoPage'></div> */}
            <Nav />
            <div id='tasks'>
                <ListView list={tasks} keys={['Title','Description']}  onUpdate={handleEdit}></ListView>
            </div>
        </div>
    )
}

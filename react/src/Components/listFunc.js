import React from 'react';
import axios from "axios";
import List from './List.js';
import {Table} from 'react-bootstrap'

export default function ListFunc() {


  const [tasks, setTask] = React.useState([])

  React.useEffect(() => async () => {
    let taskPromise = axios.get("https://localhost:44364/api/tasks/getAllTasks");
    let response = await taskPromise;
    setTask(response.data);
  },
    [])

  return  <div id="tableTask">
        {/* tasks.length === 0 ? <span>wait....</span> : */}
        <Table striped bordered hover>
          <thead>
            <tr>
              <th></th>
              <th></th>
            </tr>
          </thead>
          <tbody>
            {
              tasks?.map(u => (
                <tr key={u.IdTask}>
                  <td>{u.IdTask}</td>
                  <td>{u.Title}<br/>{u.Description}</td>
                </tr>)
              )
            }
          </tbody>
        </Table></div>

}




import React from 'react';
import List from '@mui/material/List';
import ListItem from '@mui/material/ListItem';
import ListItemButton from '@mui/material/ListItemButton';
import ListItemIcon from '@mui/material/ListItemIcon';
import ListItemText from '@mui/material/ListItemText';
import Checkbox from '@mui/material/Checkbox';
import IconButton from '@mui/material/IconButton';
// import CommentIcon from '@mui/icons-material/Comment';
import EditLocationIcon from '@mui/icons-material/EditLocationAlt';
import Group from './ButtonGroupPosition'

export default function ListView({list,keys,onUpdate}) {
  const [checked, setChecked] = React.useState([0]);

  const handleToggle = (value) => () => {
    const currentIndex = checked.indexOf(value);
    const newChecked = [...checked];

    if (currentIndex === -1) {
      newChecked.push(value);
    } 
    else {
      newChecked.splice(currentIndex, 1);
    }

    setChecked(newChecked);
  };

  return (
    <List sx={{ width: '100%', maxWidth: 360, bgcolor: 'background.paper' }}>
       
      {list.map((item,index) => {
        const labelId = `checkbox-list-label-${index}`;

        return (
          <ListItem
            key={index}
            secondaryAction={
              <IconButton edge="end" aria-label="comments">
                {/* <CommentIcon />אייקון בצד ימין */}
                <Group id='but' handleUpdate={()=>onUpdate (item)}></Group>
              </IconButton>
            }
            disablePadding
          >

            <ListItemButton role={undefined} onClick={handleToggle(item)} dense>
              <ListItemIcon>
                <Checkbox
                  edge="start"
                  checked={checked.indexOf(item) !== -1}
                  tabIndex={-1}
                  disableRipple
                  inputProps={{ 'aria-labelledby': labelId }}
                />
              </ListItemIcon>
              {/* שם המשימה */}
              {keys.map(key=>(
              <ListItemText id='text' /*id={labelId}*/ primary={/*`משימה ${value}`*/`${item[key]}`} />

                    ))}
            </ListItemButton>
          </ListItem>
        );
      })}
    </List>
  );
}





// import React from 'react';
// import { makeStyles } from '@material-ui/core/styles';
// import Input from '@material-ui/core/Input';
// import InputLabel from '@material-ui/core/InputLabel';
// import InputAdornment from '@material-ui/core/InputAdornment';
// import TextField from '@material-ui/core/TextField';
// import Grid from '@material-ui/core/Grid';
// import AccountCircle from '@material-ui/icons/AccountCircle';


// const useStyles = makeStyles((theme) => ({
//   margin: {
//     margin: theme.spacing(1),
//     display: 'flex',
//     flexWrap: 'wrap',
//   },
//   margin: {
//     margin: theme.spacing(1),
//   },
//   withoutLabel: {
//     marginTop: theme.spacing(3),
//   },
//   textField: {
//     width: '25ch',
//   },
// }));

// export default function InputWithIcon() {
  
//   const classes = useStyles();
  


  

//   return (
//     <div>
//       <div className={classes.margin}>
//         <Grid container spacing={1} alignItems="flex-end">
//           <Grid item>
//             <AccountCircle />
//           </Grid>
//           <Grid item>
//             <TextField id="input-with-icon-grid" label="שם משתמש" />
//           </Grid>
//         </Grid>

        
//         {/* <FormControl className={clsx(classes.margin, classes.textField)}>
//           <InputLabel htmlFor="standard-adornment-password">Password</InputLabel>
//           <Input
//             id="standard-adornment-password"
//             type={values.showPassword ? 'text' : 'password'}
//             value={values.password}
//             onChange={handleChange('password')}
//             endAdornment={
//               <InputAdornment position="end">
//                 <IconButton
//                   aria-label="toggle password visibility"
//                   onClick={handleClickShowPassword}
//                   onMouseDown={handleMouseDownPassword}
//                 >
//                   {values.showPassword ? <Visibility /> : <VisibilityOff />}
//                 </IconButton>
//               </InputAdornment>
//             }
//           />
//         </FormControl> */}
//       </div>
//     </div>
//   );
// }



import React from "react";
import Box from '@mui/material/Box';
import IconButton from '@mui/material/IconButton';
import FilledInput from '@mui/material/FilledInput';
import InputLabel from '@mui/material/InputLabel';
import InputAdornment from '@mui/material/InputAdornment';
import FormControl from '@mui/material/FormControl';
import TextField from '@mui/material/TextField';
import Visibility from '@mui/icons-material/Visibility';
import VisibilityOff from '@mui/icons-material/VisibilityOff';
import PersonIcon from '@mui/icons-material/Person';
import PasswordIcon from '@mui/icons-material/Password';



export default () => {
    const [values, setValues] = React.useState({
        amount: '',
        password: '',
        weight: '',
        weightRange: '',
        showPassword: false,
      });
      const handleChange = (prop) => (event) => {
        setValues({ ...values, [prop]: event.target.value });
      };
    
      const handleClickShowPassword = () => {
        setValues({
          ...values,
          showPassword: !values.showPassword,
        });
      };
    
      const handleMouseDownPassword = (event) => {
        event.preventDefault();
      };
    return (
        <>
        <form>
        <div class="body">
            <div class="center">
            <h1>sign in</h1>
            <TextField id="filled-basic" label="שם משתמש" variant="filled" required /> 
            <PersonIcon className="Icon"></PersonIcon>   
            <Box class="password" sx={{ display: 'flex', flexWrap: 'wrap' }} required >
                <div>                 
                    <FormControl sx={{ m: 1, width: '25ch' }} variant="filled" >
                        <InputLabel htmlFor="filled-adornment-password" required>סיסמא</InputLabel>
                        <FilledInput
                            id="filled-adornment-password"
                            type={values.showPassword ? 'text' : 'password'}
                            value={values.password}
                            onChange={handleChange('password')}
                            endAdornment={
                                <InputAdornment position="end">
                                    <IconButton 
                                        aria-label="toggle password visibility"
                                        onClick={handleClickShowPassword}
                                        onMouseDown={handleMouseDownPassword}
                                        edge="end"
                                    >
                                        {values.showPassword ? <VisibilityOff /> : <Visibility />}
                                    </IconButton>
                                </InputAdornment>
                            }
                        />
                    </FormControl>
                    <PasswordIcon className="Icon"></PasswordIcon> 

                </div>
            </Box>
            </div>
            </div>
            </form>
        </>
      
    )
}
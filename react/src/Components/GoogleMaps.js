import {Map, InfoWindow, Marker, GoogleApiWrapper} from 'google-maps-react';

 
 function MapGoogle(props) {
 

    return (
  <>
      <Map google={props.google} zoom={14}
            style={{ width: '80%', height: '70%', position: 'relative' }}
            initialCenter={{
                lat: 32.089870,
                lng: 34.880451
              }}
          >
               <Marker name={"Current location"}
                position={{lat: 32.089870, lng:  34.880451}}
                />
         </Map>
   </>
    );
  }
  
  export default GoogleApiWrapper({
    apiKey: ""
    ,region: 'EB',
    language: 'EB'
  })(MapGoogle);
  

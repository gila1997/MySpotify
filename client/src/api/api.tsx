import axios from 'axios';
const MY_MUSIC_API = "https://localhost:5001/api/music/";

export const authenticateUser = async (userName,userPass) => {
    const { data } = await axios({
      url: MY_MUSIC_API +'authenticate',
      method: 'POST',
      headers: {'Access-Control-Allow-Origin': '*'},
    data: {
      'Name': userName,
      'Password': userPass
    },
    });
  
    return data;
  };
  
  export const registerUser = async (userName,userPass) => {
    const { data } = await axios({
      url: MY_MUSIC_API+'register',
      method: 'POST',
      headers: {'Access-Control-Allow-Origin': '*' },
    data: {
      'Name': userName,
      'Password': userPass
    },
    });
  
    return data;
  };
  

  
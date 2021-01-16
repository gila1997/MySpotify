import React, {useState} from 'react';
import PropTypes from 'prop-types';
import axios from 'axios';

const SearchBtn = () => {
  const [input, setInput] = useState('');
  const endpoint = "https://localhost:44389/weatherforecast";
  async function toggleSearchSong()
  {
    const data = await getSong(input);
    console.log(input);
    console.log("data"+data);
  }
  async function getSong  (songOrArtist) {

    const url = `${endpoint}`;
    const { data } = await axios({
      url: url,
      method: 'GET',
      headers: {'Access-Control-Allow-Origin': '*',
      'Access-Control-Allow-Origin': 'https://localhost:44389/weatherforecast'
    },
    });
    // axios.get(url)
    // .then(function (response) {
    // console.log(response.data);
    // });
    return data;
  }
  return (
    <button type="button" className="like-btn" >
    <img src="/images/menu_search.svg" alt="Search" className="user-panel__search" 
    onClick={() => toggleSearchSong()} />
    <input type="text" value={input} onInput={e => setInput(e.target.value)} className="input"  placeholder="Search..." />
    </button>
  );

};


export default SearchBtn;

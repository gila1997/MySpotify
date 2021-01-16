import axios from 'axios';
import { Component, useState } from 'react';
const MY_MUSIC_API = "https://localhost:5001/api/music/";


const id  = 0;

  export async function getAlbums () {
  const { data } = await axios({
    url: MY_MUSIC_API+'getAlbums',
    method: 'POST',
    headers: {'Access-Control-Allow-Origin': '*'},
    data: {
        'Id': id
    }
});
  return data;
}


  
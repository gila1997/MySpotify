import React, { useState, useEffect } from 'react';

// import Loader from '../../components/Loader';
// import Col from '../../components/Col';
// import Image from '../Image';
// import ContentHeader from '../../components/ContentHeader';
// import Title from '../../components/Title';
// import { ArtistLink } from '../../components/Links';
// import Info from '../../components/Info';
// import { SongList } from '../../components/SongList';
// import { VideoItem } from '../../components/Items';
// import Grid from '../../components/Grid';
// import Inline from '../../components/Inline';

// import './Album.scss';

// import { get} from '../../api/api';

// export default function Album(props) {
//   const { id } = props.match.params;

//   const [album, setAlbum] = useState(null);

//   useEffect(() => {
//     getAlbum(id).then(data => {
//       data = data.results;

//       setAlbum(data);
//     });
//   }, []);

//   const [songs, setSongs] = useState(null);
//   const [videos, setVideos] = useState(null);

//   useEffect(
//     () => {
//       if (album && typeof album === 'object' && album.length > 0) {
//         const songsResults = [];
//         const videosResults = [];

//         album.map((value, index) => {
//           if (value.kind === 'song') {
//             songsResults.push(<SongList key={index} value={value} />);
//           } else if (value.kind === 'music-video') {
//             videosResults.push(
//               <VideoItem key={index} value={value} contentList />
//             );
//           }

//           setSongs(songsResults);

//           if (videosResults.length) setVideos(videosResults);

//           return null;
//         });
//       }

//       return null;
//     },
//     [album, setSongs, setVideos]
//   );

//   return album ? (
//     <article className="album">
//       <Col className="secondary">
//         <aside>
//           <Image
//             className="artwork"
//             src={album[0].artworkUrl100}
//             size="400x400"
//           />
//         </aside>
//       </Col>

//       <Col className="primary">
//         <ContentHeader type="album">
//           <Title
//             title={album[0].collectionName}
//             explicit={album[0].collectionExplicitness}
//           />

//           <ArtistLink value={album[0]} />
//           <Info value={album[0]} />
//         </ContentHeader>

//         <ul>{songs}</ul>

//         {videos && (
//           <Grid>
//             <Inline>
//               <h3 className="grid__title">Music videos</h3>
//             </Inline>

//             <ul>{videos}</ul>
//           </Grid>
//         )}

//       </Col>
//     </article>
//   ) : (
//     <Loader />
//   );
// }

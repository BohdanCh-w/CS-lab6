import logo from './logo.svg';
import './App.css';
import { Container, Typography } from "@material-ui/core";
import Game from "./components/Game";

function App() {
    return (
        <Container maxWidth="md">
            <Typography gutterBottom variant="h2" align="center">
                Register new Game
            </Typography>
            <Game />
        </Container>
    );
}

export default App;

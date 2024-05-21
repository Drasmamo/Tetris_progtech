using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris;

namespace My_Tetris_Test
{
    public class GameStateTests
    {

        //ellenőrzi, hogy a GameState indulásakor helyesen vannak-e beállítva az értékek.
        [Fact]
        public void NewGameState_ShouldInitializeCorrectly()
        {
            var gameState = new GameState();

            Assert.NotNull(gameState.GameGrid);
            Assert.NotNull(gameState.BlockQueue);
            Assert.NotNull(gameState.CurrentBlock);
            Assert.False(gameState.GameOver);
            Assert.Equal(0, gameState.Score);
        }

        //ellenőrzi, hogy a blok mozgatása helyesen frissíti a pozíciót
        [Fact]
        public void MoveBlockLeft_ShouldUpdateBlockPosition()
        {
            var gameState = new GameState();
            var initialPosition = gameState.CurrentBlock.TilePositions();

            gameState.MoveBlockLeft();
            var newPosition = gameState.CurrentBlock.TilePositions();

            Assert.NotEqual(initialPosition, newPosition);
        }

        //ellenőrzi, hogy a blokk forgatása helyesen frissíti a blokk pozícióit.
        [Fact]
        public void RotateBlockCW_ShouldUpdateBlockRotation()
        {
            var gameState = new GameState();
            var initialPosition = gameState.CurrentBlock.TilePositions();

            gameState.RotateBlockCW();
            var newPosition = gameState.CurrentBlock.TilePositions();

            Assert.NotEqual(initialPosition, newPosition);
        }

        //ellenőrzi, hogy a pontszám frissül-e, amikor egy blokk lehelyezésre kerül.
        [Fact]
        public void PlaceBlock_ShouldUpdateScore()
        {
            var gameState = new GameState();
            int initialScore = gameState.Score;

            while (!gameState.GameOver && gameState.BlockFits())
            {
                gameState.MoveBlockDown();
            }
            gameState.MoveBlockDown();

            Assert.Equal(initialScore, gameState.Score);
        }

        //ellenőrzi, hogy a játék helyesen vált-e át a játékvégi állapotba.
        [Fact]
        public void CheckGameOver_ShouldTransitionToGameOverState()
        {
            var gameState = new GameState();

            while (!gameState.GameOver)
            {
                gameState.MoveBlockDown();
            }

            Assert.True(gameState.GameOver);
        }
    }
}

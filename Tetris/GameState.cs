using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Tetris
{
    public class GameState
    {
        private IGameState currentState;

        public Block CurrentBlock { get; private set; }
        public GameGrid GameGrid { get; }
        public BlockQueue BlockQueue { get; }
        public bool GameOver => currentState.CheckGameOver();
        public int Score { get; private set; }

        public GameState()
        {
            GameGrid = new GameGrid(22, 10);
            BlockQueue = new BlockQueue();
            CurrentBlock = BlockQueue.GetAndUpdate();
            currentState = new PlayingState(this);
            InitializeCurrentBlock();
        }

        private void InitializeCurrentBlock()
        {
            CurrentBlock.Reset();
            for (int i = 0; i < 2; i++)
            {
                CurrentBlock.Move(1, 0);
                if (!BlockFits())
                {
                    CurrentBlock.Move(-1, 0);
                }
            }
        }

        public void RotateBlockCW()
        {
            currentState.RotateBlockCW();
        }

        public void RotateBlockCCW()
        {
            currentState.RotateBlockCCW();
        }

        public void MoveBlockLeft()
        {
            currentState.MoveBlockLeft();
        }

        public void MoveBlockRight()
        {
            currentState.MoveBlockRight();
        }

        public void MoveBlockDown()
        {
            currentState.MoveBlockDown();
        }

        public bool BlockFits() // internal volt
        {
            foreach (Position p in CurrentBlock.TilePositions())
            {
                if (!GameGrid.IsEmpty(p.Row, p.Column))
                {
                    return false;
                }
            }
            return true;
        }

        internal void PlaceBlock()
        {
            foreach (Position p in CurrentBlock.TilePositions())
            {
                GameGrid[p.Row, p.Column] = CurrentBlock.Id;
            }

            Score += GameGrid.ClearFullRows();

            if (currentState.CheckGameOver())
            {
                currentState = new GameOverState();
            }
            else
            {
                CurrentBlock = BlockQueue.GetAndUpdate();
                InitializeCurrentBlock();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class PlayingState : IGameState
    {
        private GameState gameState;

        public PlayingState(GameState gameState)
        {
            this.gameState = gameState;
        }

        public void RotateBlockCW()
        {
            gameState.CurrentBlock.RotateCW();
            if (!gameState.BlockFits())
            {
                gameState.CurrentBlock.RotateCCW();
            }
        }

        public void RotateBlockCCW()
        {
            gameState.CurrentBlock.RotateCCW();
            if (!gameState.BlockFits())
            {
                gameState.CurrentBlock.RotateCW();
            }
        }

        public void MoveBlockLeft()
        {
            gameState.CurrentBlock.Move(0, -1);
            if (!gameState.BlockFits())
            {
                gameState.CurrentBlock.Move(0, 1);
            }
        }

        public void MoveBlockRight()
        {
            gameState.CurrentBlock.Move(0, 1);
            if (!gameState.BlockFits())
            {
                gameState.CurrentBlock.Move(0, -1);
            }
        }

        public void MoveBlockDown()
        {
            gameState.CurrentBlock.Move(1, 0);
            if (!gameState.BlockFits())
            {
                gameState.CurrentBlock.Move(-1, 0);
                gameState.PlaceBlock();
            }
        }

        public bool CheckGameOver()
        {
            return !(gameState.GameGrid.IsRowEmpty(0) && gameState.GameGrid.IsRowEmpty(1));
        }
    }
}

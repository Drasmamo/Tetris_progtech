using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class GameOverState : IGameState
    {
        public void RotateBlockCW() { }
        public void RotateBlockCCW() { }
        public void MoveBlockLeft() { }
        public void MoveBlockRight() { }
        public void MoveBlockDown() { }
        public bool CheckGameOver() => true;
    }
}

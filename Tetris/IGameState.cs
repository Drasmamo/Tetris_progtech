using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public interface IGameState
    {
        void RotateBlockCW();
        void RotateBlockCCW();
        void MoveBlockLeft();
        void MoveBlockRight();
        void MoveBlockDown();
        bool CheckGameOver();
    }
}

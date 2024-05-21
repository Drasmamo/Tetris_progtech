using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public abstract class Block  // Sablon
    {
        //Tile + rotáció 4 helyzete
        protected abstract Position[][] Tiles { get; }
        // kezdő pozíció
        protected abstract Position StartOffset { get; }
        //ID
        public abstract int Id { get; }

        //jelenlegi rotációs helyzet és offset
        private int rotationState;
        private Position offset;

        public Block()
        {
            offset = new Position(StartOffset.Row, StartOffset.Column);
        }

        // Forgatás lehetslges-e?
        public IEnumerable<Position> TilePositions()
        {
            foreach (Position p in Tiles[rotationState])
            {
                yield return new Position(p.Row + offset.Row, p.Column + offset.Column);
            }
        }

        // 90 fokkal való forgatás
        public void RotateCW()
        {
            rotationState = (rotationState + 1) % Tiles.Length;
        }

        public void RotateCCW()
        {
            if (rotationState == 0)
            {
                rotationState = Tiles.Length - 1;
            }
            else
            {
                rotationState--;
            }
        }

        // mozgás metódus

        public void Move(int rows, int colums)
        {
            offset.Row += rows;
            offset.Column += colums;
        }

        // pozíció és forgás reset

        public void Reset()
        {
            rotationState = 0;
            offset.Row = StartOffset.Row;
            offset.Column = StartOffset.Column;
        }
    }
}

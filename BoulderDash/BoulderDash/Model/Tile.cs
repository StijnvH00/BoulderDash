﻿namespace BoulderDash
{
    public class Tile
    {
        public Tile(IGameObject content)
        {
            TileContent = content;
        }

        public IGameObject TileContent { get; set; }
        public Tile Up { get; set; }
        public Tile Right { get; set; }
        public Tile Down { get; set; }
        public Tile Left { get; set; }

    }
}
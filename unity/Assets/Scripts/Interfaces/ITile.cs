﻿using Hexxle.CoordinateSystem;
using Hexxle.TileSystem;
using System;

namespace Hexxle.Interfaces
{
    public interface ITile
    {
        #region Events
        event Action TileChangedEvent;
        #endregion
        #region Data
        Coordinate Coordinate { get; set; }
        EState State { get; set; }
        ITileType Type { get; set; }
        ITileBehaviour Behaviour { get; set; }
        ITileNature Nature { get; set; }
        #endregion
    }
}

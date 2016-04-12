using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.GamerServices;
using XRpgLibrary;

namespace RPGDoo.GameScreens
{
        public abstract partial class BaseGameState : GameState
        {
            #region Field Region
            protected Game1 GameRef;
            #endregion

            #region Properties Region
            #endregion

            #region Constructor Region

            public BaseGameState(Game1 game, GameStateManager manager)
                : base(game, manager)
            {
                GameRef = (Game1) game;
            }

            #endregion
        }
}

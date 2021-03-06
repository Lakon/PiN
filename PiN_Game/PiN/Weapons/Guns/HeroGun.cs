﻿#region File Description
//-----------------------------------------------------------------------------
// Enemy.cs
//
// Microsoft XNA Community Program Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace PiN
{

    /// <summary>
    /// Monster A derives from base enemy type
    /// </summary>
    class HeroGun : Gun
    {

        protected GameObject crosshair;

        /// <summary>
        /// Constructs a new Enemy.
        /// </summary>
        public HeroGun(GameCharacter theShooter) : base(theShooter)
        {
            // Set this hero gun to 5 bullets per s in automatic mode.
            attackRate = 5;
        }

        protected override void FireBullet()
        {
            base.FireBullet();
        }

        protected override void LoadContent()
        {
            crosshair = new GameObject();
            crosshair.Texture = weaponWielder.Level.Content.Load<Texture2D>("Sprites/Player/Crosshair");
            base.LoadContent();
        }

        public override void UpdateWeaponState(Vector2 crosshairPosition, GameTime gameTime)
        {
            crosshair.Position = crosshairPosition;
            base.UpdateWeaponState(crosshairPosition, gameTime);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                crosshair.Texture,
                crosshair.Position,
                null,
                Color.White,
                crosshair.Rotation,
                crosshair.Center,
                1.0f,
                weaponWielder.Flip,
                0);

            base.Draw(gameTime, spriteBatch);
        }

    }
}


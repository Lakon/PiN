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
    /// Monster D derives from base enemy type
    /// </summary>
    class MonsterD : Enemy
    {
        public override int MaxHealth
        {
            get { return 10; }
        }

        /// <summary>
        /// Constructs a new Enemy.
        /// </summary>
        public MonsterD(Level level, Vector2 position) : base(level, position)
        {
            moveSpeed = 1.1F;
        }

        protected override void LoadContent()
        {
            // Load animations.
            runAnimation = new Animation(Level.Content.Load<Texture2D>("Sprites/MonsterD/Run"), 0.1f, true);
            idleAnimation = new Animation(Level.Content.Load<Texture2D>("Sprites/MonsterD/Idle"), 0.15f, true);
            dieAnimation = new Animation(Level.Content.Load<Texture2D>("Sprites/MonsterD/Die"), 0.07f, false);
            jumpAnimation = new Animation(Level.Content.Load<Texture2D>("Sprites/MonsterD/Idle"), 0.15f, true); //placeholder

            base.LoadContent();
        }

    }
}


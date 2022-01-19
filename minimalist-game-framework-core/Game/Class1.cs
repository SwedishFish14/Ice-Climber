﻿using System;
using System.Collections.Generic;

class Class1
{
    public static readonly string Title = "Minimalist Game Framework";
    public static readonly Vector2 Resolution = new Vector2(640, 480);

    Player player = new Player();

    float playerVelocity = 0;

    public Class1()
    {
    }

    public void Update()
    {
        Engine.DrawTexture(player.getTexture(), player.getVectorPos());

        if (player.xPos < -63)
        {
            player.xPos = 640;
        }
        if (player.xPos > 640)
        {
            player.xPos = -63;
        }

        if (Engine.GetKeyHeld(Key.Left))
        {
            player.left();
        }

        if (Engine.GetKeyHeld(Key.Right))
        {
            player.right();
            //player.changeTexture(new Texture("pickaxeSprite2.png"));
        }

        if (Engine.GetKeyDown(Key.Up) && player.yPos >= 350)
        {
            playerVelocity = 5;
            player.up(playerVelocity);
        }
        if (player.yPos < 350)
        {
            player.up(playerVelocity);
            playerVelocity -= 0.1f;
        }
    }
}
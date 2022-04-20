using System;
using Raylib_cs;

Raylib.InitWindow(800, 600, "2D-topdow game");

Raylib.SetTargetFPS(60);

while(!Raylib.WindowShouldClose())
{
Raylib.BeginDrawing();

Raylib.EndDrawing();

Raylib.DrawRectangle(100 , 100, 320, 320, Color.DARKGREEN);

Raylib.ClearBackground(Color.DARKBROWN);

Raylib.DrawRectangle(700 , 20, 400, 20, Color.DARKGREEN);

Raylib.ClearBackground(Color.DARKBROWN);

Raylib.DrawRectangle(400 , 10, 100, 500, Color.DARKGREEN);

Raylib.ClearBackground(Color.DARKBROWN);

Raylib.EndDrawing();

}
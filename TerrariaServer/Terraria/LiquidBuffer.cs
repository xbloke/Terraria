﻿// Decompiled with JetBrains decompiler
// Type: Terraria.LiquidBuffer
// Assembly: TerrariaServer, Version=1.3.5.1, Culture=neutral, PublicKeyToken=null
// MVID: 880A80AC-FC6C-4F43-ABDD-E2472DA66CB5
// Assembly location: F:\Steam\steamapps\common\Terraria\TerrariaServer.exe

namespace Terraria
{
  public class LiquidBuffer
  {
    public const int maxLiquidBuffer = 10000;
    public static int numLiquidBuffer;
    public int x;
    public int y;

    public static void AddBuffer(int x, int y)
    {
      if (LiquidBuffer.numLiquidBuffer == 9999 || Main.tile[x, y].checkingLiquid())
        return;
      Main.tile[x, y].checkingLiquid(true);
      Main.liquidBuffer[LiquidBuffer.numLiquidBuffer].x = x;
      Main.liquidBuffer[LiquidBuffer.numLiquidBuffer].y = y;
      ++LiquidBuffer.numLiquidBuffer;
    }

    public static void DelBuffer(int l)
    {
      --LiquidBuffer.numLiquidBuffer;
      Main.liquidBuffer[l].x = Main.liquidBuffer[LiquidBuffer.numLiquidBuffer].x;
      Main.liquidBuffer[l].y = Main.liquidBuffer[LiquidBuffer.numLiquidBuffer].y;
    }
  }
}

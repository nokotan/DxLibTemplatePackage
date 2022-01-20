using System;
using System.Collections.Generic;
using System.Linq;
using DxLibDLL;

namespace $safeprojectname$
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            DX.ChangeWindowMode(DX.TRUE);
            
            if (DX.DxLib_Init() == -1)
            {
                return;
            }

            DX.SetDrawScreen(DX.DX_SCREEN_BACK);

            while (DX.ProcessMessage() != -1)
            {
                DX.ClearDrawScreen();
                DX.ScreenFlip();
            }

            DX.DxLib_End();
        }
    }
}

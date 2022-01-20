#include "DxLib.h"

int WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int) {

	ChangeWindowMode(TRUE);
	DxLib_Init();

	SetDrawScreen(DX_SCREEN_BACK);

	while (ProcessMessage() == 0) {
		ClearDrawScreen();
		ScreenFlip();
	}

	return 0;
}

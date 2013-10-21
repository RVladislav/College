#include <windows.h> 
#include <commctrl.h> 
#include <GdiPlus.h>
#pragma comment (lib, "comctl32.lib") 

#define ID_STATUS 200 
#define CM_FILE_OPEN 1001 
#define CM_FILE_SAVE 1002 
#define CM_FILE_QUIT 1003 
#define CM_EDIT_FIND 2001 
#define CM_EDIT_REPLC 2002 
#define CM_VIEW_NORM 3001 
#define CM_VIEW_STRC 3002

BOOL RegClass(WNDPROC, LPCTSTR, UINT);
LRESULT	CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);

HINSTANCE hInstance;
TCHAR szClass[]=TEXT("SetMenuInfo");

int WINAPI WinMain(HINSTANCE hInst, HINSTANCE hPrevInst, LPSTR lpszCmdLine, int nCmdShow) 
{ 
	MSG msg; 
	HWND hwnd; 
	hInstance = hInst;
	if (!RegClass(WndProc, szClass, COLOR_WINDOW)) return FALSE;
	hwnd = CreateWindow(szClass, TEXT("Сообщения о строках меню"), WS_OVERLAPPEDWINDOW | WS_VISIBLE, 
		CW_USEDEFAULT, CW_USEDEFAULT, 600, 700, 0,0, hInstance, NULL); 
	if (!hwnd) return FALSE; 
	while(GetMessage(&msg, 0, 0, 0)) 
	{ TranslateMessage(&msg); DispatchMessage(&msg); } 
	return msg.wParam;
}

BOOL RegClass(WNDPROC Proc, LPCTSTR szName, UINT brBackground)
{ 
	WNDCLASS wc; wc.style=wc.cbClsExtra=wc.cbWndExtra = 0; 
	wc.lpfnWndProc = Proc; wc.hInstance=hInstance; 
	wc.hIcon = LoadIcon(NULL, IDI_APPLICATION); 
	wc.hCursor=LoadCursor(NULL, IDC_ARROW);
	wc.hbrBackground = (HBRUSH)(brBackground + 1); 
	wc.lpszMenuName = NULL; 
	wc.lpszClassName = szName; 
	return (RegisterClass(&wc) != 0);
}

BOOL SetMenuItem(HMENU hMenu, UINT uIns, UINT fState, BOOL flag)
{ 
	MENUITEMINFO mii; mii.cbSize = sizeof(MENUITEMINFO); 
	mii.fMask = MIIM_STATE | MIIM_ID;
	mii.fState	= fState; mii.wID = uIns;
	return SetMenuItemInfo( hMenu, uIns, flag, &mii);
}

UINT GetMenuItem(HMENU hMenu, UINT uIns, BOOL flag)
{ 
	MENUITEMINFO mii; mii.cbSize=sizeof(MENUITEMINFO); 
	mii.fMask = MIIM_STATE; 
	GetMenuItemInfo(hMenu, uIns, flag, &mii); 
	return mii.fState;
}

BOOL CreateMenuItem(HMENU hMenu, TCHAR *str, UINT uIns, UINT uCom, HMENU hSubMenu, BOOL flag, UINT fType) 
{ 
	MENUITEMINFO mii; mii.cbSize=sizeof(MENUITEMINFO);
	mii.fMask = MIIM_STATE | MIIM_TYPE | MIIM_SUBMENU | MIIM_ID; 
	mii.fType = fType; mii.fState= MFS_ENABLED;
	mii.dwTypeData = str; mii.cch=sizeof(str); 
	mii.wID=uCom;	mii.hSubMenu=hSubMenu;
	return InsertMenuItem(hMenu, uIns, flag, &mii);
}

LRESULT CALLBACK WndProc( HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam) 
{ 
	static HMENU hMainMenu, hFileMenu, hEditMenu, hViewMenu; 
	static HWND hStatus; 
	static HDC hdc;
	static int pParts[2]; 
	static short cx; 
	static float r1x1 = 10
		, r1y1 = 40
		, r1x2 = 100
		, r1y2 = 130;
	static float r2x1 = 100
		, r2y1 = 200
		, r2x2 = 300
		, r2y2 = 400;
	static float r3x1 = 350
		, r3y1 = 100
		, r3x2 = 500
		, r3y2 = 600;
	switch (msg) 
	{ 
		
	case WM_RBUTTONDOWN:
		{
			InvalidateRect(hwnd, NULL, TRUE);
			UpdateWindow(hwnd);
			SendMessage(hStatus, SB_SETTEXT, 1, (LONG)TEXT(""));
			return 0;
		}
	case WM_LBUTTONDOWN:
		{
			//(LPCWSTR)L"text"
			WORD xPos, yPos, nSize;
			PAINTSTRUCT ps;
			BYTE szBuf[80];
			xPos   = LOWORD(lParam);
			yPos   = HIWORD(lParam);
			hdc = GetDC(hwnd);
			HDC hdcPaint=BeginPaint(hwnd,&ps);
			if((xPos>r1x1 && xPos<r1x2) && (yPos>r1y1 && yPos<r1y2))
			{
				SendMessage(hStatus, SB_SETTEXT, 0, (LONG)TEXT("Нажат прямоугольник 1"));
			}
			else {
			if((xPos>r2x1 && xPos<r2x2) && (yPos>r2y1 && yPos<r2y2))
			{
				SendMessage(hStatus, SB_SETTEXT, 0, (LONG)TEXT("Нажат прямоугольник 2"));
			}
			else {
			if((xPos>r3x1 && xPos<r3x2) && (yPos>r3y1 && yPos<r3y2))
			{
				SendMessage(hStatus, SB_SETTEXT, 0, (LONG)TEXT("Нажат прямоугольник 3"));
			}
			else {
			SendMessage(hStatus, SB_SETTEXT, 0, (LONG)TEXT("Здесь ничего нет"));
			}
			}
			
			}

			nSize = wsprintf((LPWSTR)szBuf, (LPCWSTR)L"(%d, %d)", xPos, yPos);
			TextOut(hdc, xPos, yPos, (LPWSTR)szBuf, nSize);
			SendMessage(hStatus, SB_SETTEXT, 1, (LPARAM)szBuf);

			ReleaseDC(hwnd, hdc);
			return 0;
		}
		case WM_PAINT:
		{
			PAINTSTRUCT ps;
			HDC hdc=BeginPaint(hwnd,&ps);

			BYTE szBuf[80];
			WORD nSize = wsprintf((LPWSTR)szBuf, (LPCWSTR)L"ЛКМ: координаты + место попадания", 0, 20);
			TextOut(hdc, 0, 20, (LPWSTR)szBuf, nSize);
			nSize = wsprintf((LPWSTR)szBuf, (LPCWSTR)L"ПКМ: стереть координаты", 300, 20);
			TextOut(hdc, 300, 20, (LPWSTR)szBuf, nSize);

			Rectangle(hdc,r1x1,r1y1,r1x2,r1y2);
			Rectangle(hdc,r2x1,r2y1,r2x2,r2y2);
			Rectangle(hdc,r3x1,r3y1,r3x2,r3y2);
			EndPaint(hwnd,&ps);
			return 0;
		}
		case WM_SIZE:
		{ 
			MoveWindow(hStatus, 0, 0, 0, 0, TRUE); 
			cx=LOWORD(lParam); 
			pParts[0]=cx/2; 
			pParts[1]=cx; 
			SendMessage(hStatus, SB_SETPARTS, 2, (LPARAM)pParts); 
			return 0;
		}
		case WM_CREATE: 
		{ 
			hMainMenu=CreateMenu();
			//Создаем временное меню для раздела "Файлы"
			hFileMenu=CreatePopupMenu();
			int i=0; //Инициализация позиции в меню hFileMenu
			CreateMenuItem(hFileMenu, TEXT("&Oткрыть"), i++, CM_FILE_OPEN, NULL, FALSE, MFT_STRING); 
			CreateMenuItem(hFileMenu, TEXT("&Coxpaнить"), i++, CM_FILE_SAVE, NULL, FALSE, MFT_STRING); 
			CreateMenuItem(hFileMenu, NULL, i++, 0, NULL, FALSE, MFT_SEPARATOR); 
			CreateMenuItem(hFileMenu, TEXT("&Bыход"), i++, CM_FILE_QUIT, NULL, FALSE, MFT_STRING); 
			//Создаем временное меню для раздела "Правка" 
			hEditMenu=CreatePopupMenu(); 
			i=0; //Инициализация позиции в меню hEditMenu 
			CreateMenuItem(hEditMenu, TEXT("&Найти"), i++, CM_EDIT_FIND, NULL, FALSE, MFT_STRING); 
			CreateMenuItem(hEditMenu, TEXT("&Заменить"), i++, CM_EDIT_REPLC, NULL, FALSE, MFT_STRING); 
			//Создаем временное меню для раздела "Вид"
			hViewMenu=CreatePopupMenu();
			i=0; //Инициализация позиции в меню hViewMenu
			CreateMenuItem(hViewMenu, TEXT("&Обычный"), i++, CM_VIEW_NORM, NULL, FALSE, MFT_RADIOCHECK); 
			CreateMenuItem(hViewMenu, TEXT("&Cтруктура"), i++, CM_VIEW_STRC, NULL, FALSE, MFT_RADIOCHECK); 
			//Подключаем временные меню к главному меню i=0; 
			//Инициализация позиции в меню hMainMenu 
			CreateMenuItem(hMainMenu, TEXT("&Файл"), i++, 0, hFileMenu, FALSE, MFT_STRING); 
			SetMenu(hwnd, hMainMenu); 
			SetMenuItem(hFileMenu, CM_FILE_SAVE, MFS_GRAYED, FALSE); 
			DrawMenuBar(hwnd);
			hStatus=CreateStatusWindow(WS_CHILD | WS_VISIBLE, TEXT("Готово"), hwnd, ID_STATUS); 
			return 0;
		}
		case WM_COMMAND: 
		{ 
			switch (LOWORD(wParam)) 
			{ 
				case CM_FILE_OPEN:
				{ 
					CreateMenuItem(hMainMenu, TEXT("&Правка"), 1, 0, hEditMenu, FALSE, MFT_STRING); 
					CreateMenuItem(hMainMenu, TEXT("&Вид"), 2, 0, hViewMenu, FALSE, MFT_STRING); 
					SetMenuItem(hFileMenu, CM_FILE_OPEN, MFS_GRAYED, FALSE); 
					SetMenuItem(hFileMenu, CM_FILE_SAVE, MFS_ENABLED, FALSE); 
					DrawMenuBar(hwnd); 
					return 0;
				}
				case CM_FILE_SAVE:
				{ 
					RemoveMenu(hMainMenu, 1, MF_BYPOSITION); 
					RemoveMenu(hMainMenu, 1, MF_BYPOSITION); 
					SetMenuItem(hFileMenu, CM_FILE_SAVE, MFS_GRAYED, FALSE); 
					SetMenuItem(hFileMenu, CM_FILE_OPEN, MFS_ENABLED, FALSE); 
					DrawMenuBar(hwnd);
					return 0;
				}
				case CM_EDIT_FIND: 
				{ 
					if (GetMenuItem(hEditMenu, CM_EDIT_FIND, FALSE)==MFS_CHECKED) 
						SetMenuItem(hEditMenu, CM_EDIT_FIND, MFS_UNCHECKED, FALSE);
					else
						SetMenuItem(hEditMenu, CM_EDIT_FIND, MFS_CHECKED, FALSE); 
					return 0;
				}
				case CM_EDIT_REPLC: 
				{ 
					if (GetMenuItem(hEditMenu, CM_EDIT_REPLC, FALSE)==MFS_CHECKED) 
						SetMenuItem(hEditMenu, CM_EDIT_REPLC, MFS_UNCHECKED, FALSE);
					else
						SetMenuItem(hEditMenu, CM_EDIT_REPLC, MFS_CHECKED, FALSE); 
					return 0;
				}
				case CM_VIEW_NORM: 
				{ 
					SetMenuItem(hViewMenu, CM_VIEW_NORM, MFS_CHECKED, FALSE); 
					SetMenuItem(hViewMenu, CM_VIEW_STRC, MFS_UNCHECKED, FALSE); 
					return 0;
				}
				case CM_VIEW_STRC: 
				{ 
					SetMenuItem(hViewMenu, CM_VIEW_NORM, MFS_UNCHECKED, FALSE); 
					SetMenuItem(hViewMenu, CM_VIEW_STRC, MFS_CHECKED, FALSE); 
					return 0;
				}
				case CM_FILE_QUIT: { DestroyWindow(hwnd); return 0; }
			}
			return 0;
			case WM_MENUSELECT: 
			{ 
				if ((HMENU)lParam==hMainMenu) 
				{ 
					switch (LOWORD(wParam)) 
					{ 
						case 0: 
							SendMessage(hStatus, SB_SETTEXT, 0, (LONG)TEXT("Открыть/закрыть документ или выход")); 
							SendMessage(hStatus, SB_SETTEXT, 1, NULL); 
							return 0; 
						case 1:
							SendMessage(hStatus, SB_SETTEXT, 0, (LONG)TEXT("Найти и/или заменить фрагмент")); 
							SendMessage(hStatus, SB_SETTEXT, 1, NULL); 
							return 0; 
						case 2:
							SendMessage(hStatus, SB_SETTEXT, 0, (LONG)TEXT("Cмена способа отображения документа")); 
							SendMessage(hStatus, SB_SETTEXT, 1, NULL); 
							return 0;
					}
				}
				switch (LOWORD(wParam)) 
				{ 
					case CM_FILE_OPEN:
					{ SendMessage(hStatus, SB_SETTEXT, 1, (LONG)TEXT("Oткрыть новый документ")); return 0; }
					case CM_FILE_SAVE: 
					{ SendMessage(hStatus, SB_SETTEXT, 1, (LONG)TEXT("3aкрыть текущий документ")); return 0; }
					case CM_EDIT_FIND: 
					{ SendMessage(hStatus, SB_SETTEXT, 1, (LONG)TEXT("Haйти фрагмент no выделенному образцу")); return 0; }
					case CM_EDIT_REPLC: 
					{ SendMessage(hStatus, SB_SETTEXT, 1, (LONG)TEXT("3aменить найденный фрагмент на указанный образец")); return 0; }
					case CM_VIEW_NORM: 
					{ SendMessage(hStatus, SB_SETTEXT, 1, (LONG)TEXT("Показать текущий документ в обычном виде")); return 0; }
					case CM_VIEW_STRC: 
					{ SendMessage(hStatus, SB_SETTEXT, 1, (LONG)TEXT("Показать структуру текущего документа")); return 0; }
					case CM_FILE_QUIT: 
					{ SendMessage(hStatus, SB_SETTEXT, 1, (LONG)TEXT("3aвершить работу приложения")); return 0; }
				}
				return 0;
			}
			case WM_DESTROY:
			{ DestroyMenu(hEditMenu); DestroyMenu(hViewMenu); PostQuitMessage(0); return 0; }
		}
	}
	return DefWindowProc(hwnd, msg, wParam, lParam);
}
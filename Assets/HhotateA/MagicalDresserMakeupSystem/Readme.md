# MagicalDresserMakeupSystem

This is a tool that allows you to set clothes, hair color, and BlendShape override on your VRChat avatar from the menu.

## How to install
1. Make a backup of your avatar upload project in advance.
2. VRCSDK3-AVATARを最新版に更新する．
3. ItemPickupSetup.unitypackageをUnityProjectにインポートする．
4. Unityの上部メニュー，Window/HhotateA/アバターアイテムセットアップ(ItemPickupSetup)を開く．
5. "Avatar"の欄にシーン上のアバターオブジェクトをドラッグ&ドロップで参照する.
6. "Renderer"の欄にアバター内の手に持ちたいオブジェクトをドラッグ&ドロップで参照する.
7. ColorChangeの設定を行う．
    - None : No color modification
    - Texture : Color modification to replace texture (stable)
    - RGB : Multiply grayscale by RGB
    - HSV : Color setting using HSV filter
8. ShapeChangeの設定を行う
    - None : BlendShapeを設定しない．
    - Radial : 選択したBlendShapeを非段階的に設定する．
    - Toggle : 選択したBlendShapeそれぞれをトグルメニューで設定する
9. ”Setup”ボタンを押す．
10. 通常の手順でアバターをアップロードする．

## How to use
1. AvatarのExpressionMenuから"MagicalDresserMakeupSystem"メニューを開きアイテムを選択する．
2. 色，またはBlendShapeの値を設定できるฅ(＾・ω・＾ฅ)

## Uninstallation procedure
### v1.27 or later
 1. 本ツールの"Modify Options"オプションから"Force Revert"ボタンを押す．
 2. 「Status : Complete Revert」というメッセージが出れば成功
### v1.26以前
1. Fx_Animatorから"MDMakeup_"から始まる名前のレイヤーを削除する．
2. VRCExpressionsMenuから"MDMakeup_"から始まる名前の項目を削除する．
3. VRCExpressionParameters"MDMakeup_"から始まる名前の項目を削除する．
4. HSV設定した場合，Rendererの子オブジェクトの"(clone)_Filter"という名前のオブジェクトを削除する

## Modify Options
- Override Write Default : Override the value of WriteDefault. (VRChat deprecated item)
- RenameParameters : Hash and remove 2-byte characters in parameter names.
- Auto Next Page : When the number of menu items reaches the limit, the next page is automatically created.

- Force Revert : Revert the settings set up by this tool.

## Caution.
- This is a destructive change to fxAnimatorController, ExpressionMenu, and ExpressionParameters of the avatar. Please remember to make a backup copy of your avatar.
- If the maximum number of items in ExpressionParameters and ExpressionMenu has been reached, it may not be possible to install correctly. In such cases, please reduce the number of items temporarily.
- If an error occurs due to a conflict with a previous version, please try FullPackage.

## Terms of Use
- Secondary distribution is permitted, including bundling with avatars, modifications, or entire tools.
- If you distribute the tools, we would appreciate it if you notify us and give us credit. (Not required).
- The creator assumes no responsibility for any problems that may occur using this tool.
- The creator is not responsible for any problems that may occur when using this tool.

## System Requirements
- Unity2019.4.24f1
- VRCSDK3-AVATAR-2021.08.11.15.16_Public

## Produced by.
@HhotateA_xR
To report a problem, go to https://github.com/HhotateA/AvatarModifyTools

## Update history
2021/08/13 v1.26
2021/08/27 v1.27
2021/09/03 v1.29
2021/09/10 v1.30

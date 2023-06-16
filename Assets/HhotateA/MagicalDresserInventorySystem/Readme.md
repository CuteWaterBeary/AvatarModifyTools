# MagicDresserInventorySystem

! [alt](./Manual/000.png)
This is a configuration tool that allows VRChat avatars to switch in and out of items and clothes from the menu.
It is also possible to generate effects when switching clothes with a simple configuration.


![alt](./Manual/001.png)
## Import Method
1. あらかじめアバターアップロード用プロジェクトのバックアップを取っておく．
2. VRCSDK3-AVATARを最新版に更新する．
3. MagicalDresserInventorySystem.unitypackageをUnityProjectにインポートする．
4. Unityの上部メニュー，Window/HhotateA/マジックドレッサーインベントリ(MagicalDresserInventorySystem)を開く．
5. "Avatar"の欄にシーン上のアバターオブジェクトをドラッグ&ドロップで参照する.
6. "MenuElements"にメニューを追加する．
7. ウィンドウの左側，メニュー項目の設定を行う．
    - Name
    - Icon
    - Toggle / Layer (exclusive mode) : If set to Layer, one menu in the same layer will be active.
    - is Saved : Whether the state is preserved when switching avatars
    - is Default : Whether it is enabled by default or not.
8. On the right side of the window, configure the item.
   Drag and drop the objects you want to put in and out of the menu.
    - ON State : Set the animation when the menu is turned ON.
        - IsActive : Enable/disable the item when the menu is turned on.
        - delay : Lag time between turning on the menu and enabling/disabling the item.
        - duration : time taken for the animation to enable/disable the item
        - type : type of animation to enable/disable the item
            - None : no animation (duration is ignored)
            - Scale : Animation of the object appearing larger (only supported by MeshRenderer)
            - Shader : Animation using any shader (the value of "_AnimationTime" changes from 0 to 1)
            - Feed : Animation to increase transparency and disappear
            - Crystallize : Animation of polygons shattering
            - Dissolve : animation of burning out
            - Draw : Pencil coloring animation
            - Explosion: Animation of a polygon exploding
            - Geom : Animation of geometry decomposition
            - Mosaic : Animation of a mosaic that becomes finer and finer
            - Polygon : Animation of polygon decomposition
            - Bounce : Animation of an object growing in size
    - OFF State : Animation setting when menu is OFF
9. ”Setup”ボタンを押す．
10. 通常の手順でアバターをアップロードする．

11. In the Project window, double-click the file saved during Setup to resume the setup 🐈.

## How to use
1. Select "MagicDresserInventorySystem" from Avatar's ExpressionMenu.
2. By selecting the toggle menu, you can switch between itemsฅ(＾ω・＾ฅ)

## Uninstallation procedure
### v1.27以降
 1. 本ツールの"Modify Options"オプションから"Force Revert"ボタンを押す．
 2. 「Status : Complete Revert」というメッセージが出れば成功
### v1.26以前
1. Fx_Animatorから"MDInventory_"から始まる名前のレイヤーを削除する．
2. VRCExpressionsMenuから"MDInventory_"から始まる名前の項目を削除する．
3. VRCExpressionParameters"MDInventory_"から始まる名前の項目を削除する．

## Modify Options
- Override Write Default : Override the value of WriteDefault. (VRChat deprecated item)
- RenameParameters : Hash and remove 2-byte characters in parameter names.
- Auto Next Page : When the number of menu items reaches the limit, the next page is automatically created.

- Force Revert : Revert the settings set up by this tool.

- Override Animation On Idle State : Loop the animation that is always synchronized. (For stable behavior in VRChat).
- Override Default Value Animation : Override the default values for materials.

## Caution.
- This is a destructive change to fxAnimatorController, ExpressionMenu, and ExpressionParameters of the avatar. Please remember to make a backup copy of your avatar.
- If the maximum number of items in ExpressionParameters and ExpressionMenu has been reached, you may not be able to successfully introduce them. In such cases, please reduce the number of items temporarily.
- If an error occurs due to a conflict with a previous version, please try FullPackage.
- If you are controlling OnOff of the object by animation outside of this tool, it may not work properly. (DetectConflictLayer is displayed during "Setup").

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

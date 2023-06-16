# NadofuSetup(TailMoverSetup)

This tool saves animations of tail and arm movements for use with VRChat avatars.

- I want to move my arms with ExpressionMenu even in VRChat desktop mode.
- I want to move my avatar's ears freely from the ExpressionMenu.
- I want to set the idle motion of my avatar's tail.

This tool is for those who want to move their avatar's ears freely from the ExpressionMenu.

## Import Method
1. あらかじめアバターアップロード用プロジェクトのバックアップを取っておく．
2. VRCSDK3-AVATARを最新版に更新する．
3. AvatarPenSetupTool.unitypackageをUnityProjectにインポートする．
4. Unityの上部メニュー，Window/HhotateA/TailMoverSetupを開く．
5. "Avatar"の欄にシーン上のアバターオブジェクトをドラッグ&ドロップで参照する
6. 動かしたい部位のプリセットを選択する．
7. 動かしたい部位(尻尾)の根元のオブジェクトをroot bonesに設定する．
8. 初期状態で伸ばす方向をTailAxiに設定する．
    正面方向に伸ばしたいなら(0,0,1)のようにする．
    (0,0,0)の場合はそのままの状態を初期状態にする.
9. ”Setup”ボタンを押す．
10. testRotXおよびtestRotYを動かして，動かしたい部位の動きを確認する．
11. 修正したい場合はRotSettiongsからUp,Down,Right,LeftそれぞれのAbgleを設定し直し，再度確認する．
12. ControllMode（メニューから自由に動かしたい）にしたい場合は"Save RadialControll"ボタンを押す．
    IdleMode(勝手に動くアニメーション)にしたい場合は"Save IdleMotion"ボタンを押す．
13. ウィンドウを閉じて，アバターをアップロードする．

## How to use
### For ControllMode
1. ExpressionMenuから○○○○Controllを選択
2. うごかせるよー
### For IdleMode
1. ExpressionMenuから○○○○Idleを選択
2. 動かすスピードを設定

## Uninstallation procedure
### v1.27以降
 1. 本ツールの"Modify Options"オプションから"Force Revert"ボタンを押す．
 2. 「Status : Complete Revert」というメッセージが出れば成功
### v1.26以前
1. Fx_Animatorから"TailMover_"から始まる名前のレイヤーを削除する．
2. VRCExpressionsMenuから"TailMover_"から始まる名前の項目を削除する．
3. VRCExpressionParameters"TailMover_"から始まる名前の項目を削除する．

## Modify Options
- Override Write Default : Override the WriteDefault value. (VRChat deprecated item)
- RenameParameters : Hash and remove 2-byte characters in parameter names.
- Auto Next Page : When the number of menu items reaches the limit, the next page is automatically created.

- Force Revert : Revert the settings set up by this tool.

## Notes
- This tool destructively changes fxAnimatorController, ExpressionMenu, and ExpressionParameters of the avatar. Be sure to make a backup copy of your avatar.
- If the maximum number of items in ExpressionParameters and ExpressionMenu has been reached, it may not be possible to install correctly. In this case, please reduce the number of items temporarily.
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
2021/07/31 v1.25
2021/08/13 v1.26
2021/08/27 v1.27
2021/09/03 v1.29
2021/09/10 v1.30

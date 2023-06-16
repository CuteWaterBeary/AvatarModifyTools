# Avatar Item Setup (GrabableItemSetup)

This is a tool for setting up a gimmick that allows VRChat avatars to hold items in their hands or place them in the world.

## Import Method
1. Make a backup of your avatar upload project in advance.
2. Update VRCSDK3-AVATAR to the latest version.
3. ItemPickupSetup.unitypackageをUnityProjectにインポートする．
4. Unityの上部メニュー，Window/HhotateA/アバターアイテムセットアップ(ItemPickupSetup)を開く．
5. "Avatar"の欄にシーン上のアバターオブジェクトをドラッグ&ドロップで参照する.
6. "Object"の欄にアバター内の手に持ちたいオブジェクトをドラッグ&ドロップで参照する.
7. "HandBone"に手のオブジェクトをドラッグ&ドロップで参照，右側の欄で手に持つトリガーとなるハンドサインを設定する．
8. Set the hand sign that will trigger the hand holding in the right hand column of "WorldBone".
    - Turn off UseConstraint for use with Quest.
    - Turn off SafeOriginalItem when targeting a bone.
9. Press the "Setup" button.
10. Upload your avatar in the usual way.

## How to use
1. Open the "GrabableItem" menu from Avatar's ExpressionMenu and select the item.
2. By selecting Grab (+ performing the hand action you set), you can hold the item in your hand.
3. Selecting Drop (+ performing the hand action you set) will fix the item to the world.

## uninstallation procedure
### v1.27 onwards
 1. 本ツールの"Modify Options"オプションから"Force Revert"ボタンを押す．
 2. 「Status : Complete Revert」というメッセージが出れば成功
### v1.26 before
 1. Fx_Animatorから"GrabableItem_"から始まる名前のレイヤーを削除する．
 2. VRCExpressionsMenuから"GrabableItem_"から始まる名前の項目を削除する．
 3. VRCExpressionParameters"GrabableItem_"から始まる名前の項目を削除する．
 4. アバター直下の"WorldPoint"オブジェクトを削除する．
 5. アバターの手ボーンの"HandAnchor_"オブジェクトを削除する．
 5. アバター下アイテムと同じ階層にあるの"RootAnchor_"オブジェクトを削除する．

## Modify Options
- Override Write Default : Overrides the value of WriteDefault. (VRChat deprecated item)
- RenameParameters : Hash and remove 2-byte characters in parameter names.
- Auto Next Page : When the maximum number of menu items is reached, the next page is automatically created.

- Force Revert : This tool restores the settings that have been set up.

## Caution
- Make destructive changes to the fxAnimatorController, ExpressionMenu, and ExpressionParameters of your avatar. Please remember to make a backup copy of your avatar.
- If the maximum number of items in ExpressionParameters and ExpressionMenu has been reached, it may not be possible to install correctly. If there is an error due to a problem with ExpressionParameters or ExpressionMenu, please reduce the number of items temporarily.
- If there is an error due to a conflict with a previous version, try FullPackage.

## Terms of Use
- Secondary distribution is permitted, including bundling with avatars, modifications, or entire tools.
- If you distribute the work secondarily, it would be nice to be notified and credited.(Not required)
- The producer is not responsible for any problems that may occur using this tool..
- The producer is not responsible if the functions of this tool become unusable due to changes in the specifications of VRChat, Unity, etc.

## System Requirements
- Unity2019.4.24f1
- VRCSDK3-AVATAR-2021.08.11.15.16_Public

## Producer
@HhotateA_xR
To report a problem, go to https://github.com/HhotateA/AvatarModifyTools

## Update History
2021/08/13 v1.26
2021/08/27 v1.27
2021/09/03 v1.29
2021/09/10 v1.30

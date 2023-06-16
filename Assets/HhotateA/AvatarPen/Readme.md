# AvatarPenSetup

This is a simple setup tool for a trail-type finger pen that can be used with VRChat avatars.

## How to install
Make a backup of your avatar upload project in advance. 2.
Update VRCSDK3-AVATAR to the latest version. 3.
Import AvatarPenSetupTool.unitypackage into UnityProject. 4.
Open Window/HhotateA/AvatarPenSetup from the top menu of Unity. 5.
Drag and drop an avatar object on the scene into the "Avatar" field. 6.
Press the "Setup" button. 7.
Upload the avatar as usual.

## How to use
1) Select Pen from the ExpressionMenu of Avatar. 2) Select a color.
Select a color. 3.
When the right hand is set to Fingerpoint, a trail will appear from the fingertip. 4.
4. use Erase in the PenMenu to erase ฅ(＾ω・＾ฅ)

## Uninstallation procedure
1. delete the layer whose name begins with "AvatarPen" from Fx_Animator. 2.
Delete the item whose name begins with "AvatarPen" from VRCExpressionsMenu. 3.
Delete VRCExpressionParameters with names beginning with "AvatarPen". 4.
Delete the "Avatar_Pen" object of the avatar fingertip.

## Modify Options
- Override Write Default : Override the value of WriteDefault. (VRChat deprecated item)
- RenameParameters : Hash and remove 2-byte characters in parameter names.
- Auto Next Page : When the number of menu items reaches the limit, the next page is automatically created.

- Force Revert : Revert the settings set up by this tool.

## Caution.
- This is a destructive change to fxAnimatorController, ExpressionMenu, and ExpressionParameters of the avatar. Please remember to make a backup copy of the file.
- If there is an error due to conflicts with previous versions, please try FullPackage.

## Terms of Use
- Secondary distribution is permitted, including bundling with avatars, modification, and partial or complete tools.
- If you distribute the tools, we would appreciate a notice and credit. (Not required).
- The creator assumes no responsibility for any problems that may occur using this tool.
- The creator is not responsible for any problems that may occur when using this tool.

## System Requirements
- Unity2019.4.24f1
- VRCSDK3-AVATAR-2021.08.11.15.16_Public

## Producer
@HhotateA_xR
To report a problem, go to https://github.com/HhotateA/AvatarModifyTools

## Update History
2021/04/04 v0.9
2021/04/06 v1.1 Destructive update of AvatarModifyTool with EmojiParticleSetupTool
2021/07/08 v1.2 Release of TextureModifyTool and update of AvatarModifityTool
2021/07/31 v1.25
2021/08/13 v1.26
2021/08/27 v1.27
2021/09/03 v1.29
2021/09/10 v1.30

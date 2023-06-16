# EmojiParticleSetup

This is an Emoji Particle Setup tool for VRChat avatars.
It allows you to play the stamp of an illustration from the menu like VRChat's Emoji.

## How to install
Make a backup of your avatar upload project in advance. 2.
Update VRCSDK3-AVATAR to the latest version. 3.
Import EmojiParticleSetupTool.unitypackage into UnityProject. 4.
Open Window/HhotateA/EmojiParticleSetup from the Unity top menu. 5.
Register all the images and titles of the emoji (stamp illustrations) you wish to display. 6.
Drag and drop an avatar object on the scene into the "Avatar" field. 7.
Select the place to emit particles from (Head/LeftHand/RightHand). 8.
Press the "Setup" button. 9.
Upload the avatar in the usual way. 9.

In the Project window, double-click the file saved at the time of Setup to resume the setup 🐈.

## How to use
1. select EmojiParticle from the ExpressionMenu of Avatar. 2.
2. select Emoji to create particles ฅ(＾ω・＾ฅ)

## Uninstallation procedure
### v1.27 or later
 1. Press the "Force Revert" button from the "Modify Options" option of the tool.
 2. Success if the message "Status : Complete Revert" appears.
### Before v1.26
1. Delete layers and parameters with names starting with "EmojiParticle" from Fx_Animator.
2. Delete items with names beginning with "EmojiParticle" from VRCExpressionsMenu.
3. VRCExpressionParameters Deletes entries with names beginning with "EmojiParticle".
4. Deleting an "EmojiParticle" object in an avatar

## Modify Options
- Override Write Default : Override the value of WriteDefault. (VRChat deprecated item)
- RenameParameters : Hash and remove 2-byte characters in parameter names.
- Auto Next Page : When the number of menu items reaches the limit, the next page is automatically created.

- Force Revert : Undo the settings set up by this tool.

## Caution.
- This is a destructive change to fxAnimatorController, ExpressionMenu, and ExpressionParameters of the avatar. Please remember to make a backup copy of your avatar.
- If the maximum number of items in ExpressionParameters and ExpressionMenu has been reached, it may not be possible to install correctly. In such cases, please reduce the number of items temporarily.
- There is a case that particles do not appear in the mirror of VRChat. Please check visually or with a camera.
- If there is an error due to a conflict with a previous version, please try Full Package.

## Terms of Use
- Secondary distribution is permitted, including bundling with avatars, modifications, or entire tools.
- If you distribute the tools, we would appreciate it if you notify us and give us credit. (Not required).
- The creator assumes no responsibility for any problems that may occur using this tool.
- The creator is not responsible for any problems that may occur when using this tool.

## Action Confirmation Environment
- Unity2019.4.24f1
- VRCSDK3-AVATAR-2021.08.11.15.16_Public

## Produced by.
@HhotateA_xR
To report a problem, go to https://github.com/HhotateA/AvatarModifyTools

## Update History
2021/04/05 v1.0
2021/07/08 v1.2 Release of TextureModifyTool and update of AvatarModifityTool
2021/07/31 v1.25
2021/08/13 v1.26
2021/08/27 v1.27
2021/09/03 v1.29
2021/09/10 v1.30

# AvatarPenSetup

This is a simple setup tool for a trail-type finger pen that can be used with VRChat avatars.

## How to install
1. Make a backup of your avatar upload project in advance.
2. Update VRCSDK3-AVATAR to the latest version.
3. Import AvatarPenSetupTool.unitypackage into UnityProject.
4. Open Window/HhotateA/AvatarPenSetup from the top menu of Unity.
5. Drag and drop an avatar object on the scene into the "Avatar" field.
6. Press the "Setup" button.
7. Upload the avatar as usual.

## How to use
1. Select Pen from the ExpressionMenu of Avatar.
2. Select a color.
3. When the right hand is set to Fingerpoint, a trail will appear from the fingertip.
4. use Erase in the PenMenu to erase ฅ(＾ω・＾ฅ)

## Uninstallation procedure
1. delete the layer whose name begins with "AvatarPen" from Fx_Animator.
2. Delete the item whose name begins with "AvatarPen" from VRCExpressionsMenu.
3. Delete VRCExpressionParameters with names beginning with "AvatarPen".
4. Delete the "Avatar_Pen" object of the avatar fingertip.

## Modify Options
- Override Write Default : Override the value of WriteDefault. (VRChat deprecated item)
- RenameParameters : Hash and remove 2-byte characters in parameter names.
- Auto Next Page : When the number of menu items reaches the limit, the next page is automatically created.

- Force Revert : Revert the settings set up by this tool.

## Caution.
- This is a destructive change to fxAnimatorController, ExpressionMenu, and ExpressionParameters of the avatar. Please remember to make a backup copy of the file.
- If there is an error due to conflicts with previous versions, please try FullPackage.

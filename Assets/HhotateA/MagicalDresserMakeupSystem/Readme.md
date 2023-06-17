# MagicalDresserMakeupSystem

This is a tool that allows you to set clothes, hair color, and BlendShape override on your VRChat avatar from the menu.

## How to install
1. Make a backup of your avatar upload project in advance.
2. Update VRCSDK3-AVATAR to the latest version.
3. Import ItemPickupSetup.unitypackage into UnityProject.
4. Open Window/HotateA/Avatar ItemPickupSetup from the Unity top menu.
5. Drag and drop an avatar object on the scene into the "Avatar" field.
6. In the "Renderer" field, drag and drop the object you want to hold in your avatar's hand.
7. Set the ColorChange settings.
    - None : No color modification
    - Texture : Color modification to replace texture (stable)
    - RGB : Multiply grayscale by RGB
    - HSV : Color setting using HSV filter
8. Configure ShapeChange settings.
    - None : BlendShape is not set.
    - Radial : Set the selected BlendShape non-radial.
    - Toggle : Toggle menu for each selected BlendShape
9. Press the "Setup" button.
10. Upload your avatar in the usual way.

## How to use
1. Open the "MagicalDresserMakeupSystem" menu from the ExpressionMenu of Avatar and select the item.
2. You can set the color or BlendShape valueฅ(＾ω・＾ฅ)

## Uninstallation procedure
### v1.27 or later
 1. Press the "Force Revert" button from the "Modify Options" option of the tool.
 2. Success if the message "Status : Complete Revert" appears.
### Before v1.26
1. Delete layers with names starting with "MDMakeup_" from Fx_Animator.
2. Delete the items with names starting with "MDMakeup_" from VRCExpressionsMenu.
3. VRCExpressionParameters Deletes items with names beginning with "MDMakeup_".
4. If set to HSV, deletes the child object of the Renderer named "(clone)_Filter

## Modify Options
- Override Write Default : Override the value of WriteDefault. (VRChat deprecated item)
- RenameParameters : Hash and remove 2-byte characters in parameter names.
- Auto Next Page : When the number of menu items reaches the limit, the next page is automatically created.

- Force Revert : Revert the settings set up by this tool.

## Caution.
- This is a destructive change to fxAnimatorController, ExpressionMenu, and ExpressionParameters of the avatar. Please remember to make a backup copy of your avatar.
- If the maximum number of items in ExpressionParameters and ExpressionMenu has been reached, it may not be possible to install correctly. In such cases, please reduce the number of items temporarily.
- If an error occurs due to a conflict with a previous version, please try FullPackage.

# NadofuSetup(TailMoverSetup)

This tool saves animations of tail and arm movements for use with VRChat avatars.

- I want to move my arms with ExpressionMenu even in VRChat desktop mode.
- I want to move my avatar's ears freely from the ExpressionMenu.
- I want to set the idle motion of my avatar's tail.

This tool is for those who want to move their avatar's ears freely from the ExpressionMenu.

## Import Method
1. Make a backup of your avatar upload project in advance.
2. Update VRCSDK3-AVATAR to the latest version.
3. Import AvatarPenSetupTool.unitypackage into UnityProject.
4. Open Window/HotateA/TailMoverSetup in the top menu of Unity.
5. Refer to the "Avatar" field by dragging and dropping an avatar object on the scene.
6. Select a preset for the area to be moved.
7. Set the root bones to the object at the root of the part of the body (tail) to be moved.
8. The direction of extension is initially set to TailAxi.
    If you want to extend in the frontal direction, use (0,0,1).
    If (0,0,0), the initial state is the same as before.
9. Press the "Setup" button.
10. Move testRotX and testRotY to check the movement of the area to be moved.
11. If you want to correct it, set Abgle for Up, Down, Right, and Left from RotSettiongs, and check again.
12. If you want to set the control mode (i.e., to move freely from the menu), press the "Save RadialControl" button.
    If you want to set the animation to IdleMode (animation that moves on its own), press the "Save IdleMotion" button.
13. Close the window and upload your avatar.

## How to use
### For ControllMode
1. Select Control from ExpressionMenu
2. I'll make it move!
### For IdleMode
1. Select Idle from ExpressionMenu
2. Set the speed of movement

## Uninstallation procedure
### v1.27 or later
 1. Press the "Force Revert" button from the "Modify Options" option of the tool.
 2. Success if the message "Status : Complete Revert" appears.
### Before v1.26
1. Delete layers with names starting with "TailMover_" from Fx_Animator.
2. Delete items with names beginning with "TailMover_" from VRCExpressionsMenu.
3. VRCExpressionParameters Deletes entries with names beginning with "TailMover_".

## Modify Options
- Override Write Default : Override the WriteDefault value. (VRChat deprecated item)
- RenameParameters : Hash and remove 2-byte characters in parameter names.
- Auto Next Page : When the number of menu items reaches the limit, the next page is automatically created.

- Force Revert : Revert the settings set up by this tool.

## Notes
- This tool destructively changes fxAnimatorController, ExpressionMenu, and ExpressionParameters of the avatar. Be sure to make a backup copy of your avatar.
- If the maximum number of items in ExpressionParameters and ExpressionMenu has been reached, it may not be possible to install correctly. In this case, please reduce the number of items temporarily.
- If an error occurs due to a conflict with a previous version, please try FullPackage.

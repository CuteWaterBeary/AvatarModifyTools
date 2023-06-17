# Avatar Item Setup (GrabableItemSetup)

This is a tool for setting up a gimmick that allows VRChat avatars to hold items in their hands or place them in the world.

## Import Method
1. Make a backup of your avatar upload project in advance.
2. Update VRCSDK3-AVATAR to the latest version.
3. Import ItemPickupSetup.unitypackage into UnityProject.
4. Open Window/HotateA/Avatar ItemPickupSetup from the Unity top menu.
5. Drag and drop an avatar object on the scene into the "Avatar" field.
6. Drag and drop the object you want to hold in your avatar into the "Object" field.
7. Drag and drop a hand object to "HandBone" and set the hand signature that will trigger the hand in the right hand column.
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
 1. Press the "Force Revert" button from the "Modify Options" option of the tool.
 2. Success if the message "Status : Complete Revert" appears.
### v1.26 before
 1. Delete layers with names starting with "GrabableItem_" from Fx_Animator.
 2. Remove items with names beginning with "GrabableItem_" from VRCExpressionsMenu.
 3. VRCExpressionParameters Deletes items with names beginning with "GrabableItem_".
 4. Delete the "WorldPoint" object directly under the avatar.
 5. Delete the "HandAnchor_" object of the avatar's hand bone.
 5. Delete the "RootAnchor_" object, which is on the same level as the item under the avatar.

## Modify Options
- Override Write Default : Overrides the value of WriteDefault. (VRChat deprecated item)
- RenameParameters : Hash and remove 2-byte characters in parameter names.
- Auto Next Page : When the maximum number of menu items is reached, the next page is automatically created.

- Force Revert : This tool restores the settings that have been set up.

## Caution
- Make destructive changes to the fxAnimatorController, ExpressionMenu, and ExpressionParameters of your avatar. Please remember to make a backup copy of your avatar.
- If the maximum number of items in ExpressionParameters and ExpressionMenu has been reached, it may not be possible to install correctly. If there is an error due to a problem with ExpressionParameters or ExpressionMenu, please reduce the number of items temporarily.
- If there is an error due to a conflict with a previous version, try FullPackage.

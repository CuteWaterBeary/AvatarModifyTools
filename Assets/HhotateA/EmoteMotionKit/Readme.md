# EmoteMotionKit

This tool allows you to set idle animations and emotes for your VRChat avatar.
You can switch between lying sleeping motion and sitting motion from the menu, and playback your favorite action emotes whenever you want.
You can also play your favorite action emotes whenever you want.

## Introduction Procedure
1. Make a backup of your avatar upload project in advance.
2. Update VRCSDK3-AVATAR to the latest version.
3. Import EmoteMotionKit.unitypackage into UnityProject.
4. Open Window/HhotateA/EmoteMotionKit in the top menu of Unity.
5. Refer to the "Avatar" field by dragging and dropping an avatar object on the scene.
6. Set the layer settings.
    - EmoteLayer : Layer to which EmoteMotion is added.
        - Base : Register to Locomotion layer.
        - Action : Register in the Action layer. (Same setting as VRChat's Emote)
        - Additive : Add to Idle layer. （Additive : Add the animation to the Idle layer.
    - Use FX : Copy the animation to FX layer. （Use FX : Copy the animation to the FX layer (for compositing facial expressions, etc.)
    - Is Saved : Save the state of the emote.
7. Register an animation
8. Configure animation settings.
    - TrackingSpace : (Animator Tracking Control setting)
        - TrackingBase : Prioritize Tracking
        - FootAnimation : Override animation for foot movement
        - BodyAnimation : Override animation for movements other than head
        - AnimationBase : Prioritize animation
        - Emote : Override with animation
    - IsEmote : Set as an emote (non-looping animation).
    - Stop Locomotion : Prohibit movement except for animation (Animator Locomotion Control setting)
    - Enter Pose Space : Move the viewpoint with animation (setting of Animator Temporary Pose Space)
9. Press the "Setup" button.
10. Upload your avatar in the usual way.

## How to use
1. Select EmoteMotion from Avatar's ExpressionMenu.
2. Select any Emote or IdleAnimation to play it.

## Uninstallation procedure
### v1.27 or later
 1. Press the "Force Revert" button from the "Modify Options" option of the tool.
 2. Success if the message "Status : Complete Revert" appears.

## Modify Options
- Override Write Default : Override the WriteDefault value. (VRChat deprecated item)
- RenameParameters : Hash and remove 2-byte characters in parameter names.
- Auto Next Page : When the number of menu items reaches the limit, the next page is automatically created.

- Force Revert : Revert the settings set up by this tool.

## Notes
- This tool destructively changes fxAnimatorController, ExpressionMenu, and ExpressionParameters of the avatar. Be sure to make a backup copy of the file.
- If there is an error due to conflicts with previous versions, please try FullPackage.

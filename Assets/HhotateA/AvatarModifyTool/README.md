# AvatarModifyTools

Some editor extensions to help you modify your VRChat avatar.

Here are some tools to help you modify your VRChat avatar.

### AvatarModifyTool
 This tool automates the avatar modification process and adapts avatar modifications with a single click.
 It is intended to be used as a library for creating one-click setup tools for accessories and avatar gimmicks without having to create Unity extensions from scratch.

### AvatarModifyData
  An asset file for saving avatar modifications.

 - Locomotion_controller : Animator controller that includes a layer to be added to the Base layer of Avatar3.0.
 - idle_controller : Animator controller that includes a layer to be added to the Additive layer of Avatar3.0.
 - gesture_controller : Animator controller that includes a layer to be added to the Gesture layer of Avatar3.0.
 - action_controller : Animator controller that includes a layer to be added to the Action layer of Avatar3.0.
 - fx_controller : Animator controller that includes a layer to be added to Fx layer of Avatar3.0.

 - parameter : Items to be added to the Avatar3.0 parameter driver.
 - menu : Items to be added to the Avatar3.0 menu. It can be derived from submenus.

 - Item : Gameobject to be added to the Avatar Transform.
    - prefab : Prefab to be generated; if the root of the prefab has ParentConstraint, the connection will be switched to Constraint and the prefab will be generated directly under Avatar.
    - target : The corresponding avatar's bone.

    When the prefab is inserted into the avatar's bone using this function, all animation paths referenced in AnimatorController above will be rewritten correctly. <br> <br
  For example, if you have an animation that turns on/off the "AvatarPen" object directly under the AvatarRoot, and you move the "AvatarPen" to the fingertip using this function, the Animation path is automatically rewritten and continues to work correctly.

 ### sample code

 ```c#
using HhotateA.AvatarModifyTools.Core;
using UnityEditor;
using UnityEngine;
using VRC.SDK3.Avatars.Components;

public class TestSetupTool : EditorWindow
{
    [MenuItem("Window/TestSetupTool")]

    public static void ShowWindow()
    {
        var wnd = GetWindow<TestSetupTool>();
        wnd.titleContent = new GUIContent("TestSetupTool");
    }

    private VRCAvatarDescriptor avatar;

    // Assign GUID of AvatarModifyData here
    const string assetGUID = "e5cd1ff11d13fed44bd5d0b8b4a2be8c";

    private void OnGUI()
    {
        avatar = (VRCAvatarDescriptor) EditorGUILayout.ObjectField("Avatar", avatar, typeof(VRCAvatarDescriptor), true);

        if (GUILayout.Button("Setup"))
        {
            var asset = AssetUtility.LoadAssetAtGuid<AvatarModifyData>(assetGUID);
            var mod = new AvatarModifyTool(avatar);
            mod.ModifyAvatar(asset);
        }

        EditorGUILayout.LabelField("powered by AvatarModifyTool @HhotateA_xR");
    }
}
```

## License
All source code of this tool is released under a free license.
- Redistribution: Permitted
- Modification: Yes
- Commercial use: Yes
- Author's notation: Not required
- License inheritance: Not required
- Secondary distribution is permitted, including bundling with avatars for sale, derivative tools, and parts of tools, as well as whole tools.
- If you distribute the tool, we would appreciate it if you notify us and give us credit. (Not required).
- The creator assumes no responsibility for any problems that may occur using this tool.
- The creator is not responsible for any problems that may occur when using this tool.

## System Requirements
- Unity2019.4.24f1
- VRCSDK3-AVATAR-2021.08.11.15.16_Public

## Update History

2021/04/04 v0.9<br>
2021/04/06 v1.1<br>
2021/07/08 v1.2<br>
2021/07/31 v1.25<br>
2021/08/13 v1.26<br>
2021/08/27 v1.27<br>
2021/09/03 v1.29<br>
2021/09/10 v1.30<br>

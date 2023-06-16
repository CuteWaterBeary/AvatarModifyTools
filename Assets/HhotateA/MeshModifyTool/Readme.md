download https://github.com/HhotateA/AvatarModifyTools/releases/tag/v1

# NyanNyan Mesh Editor (MeshModifyTool)

! [alt](./Manual/000.png)
This tool enables simple mesh deformation with Unity's Editor, for example, to change the avatar's clothes for VRChat.

## Import method, using manual
1. あらかじめアバターアップロード用プロジェクトのバックアップを取っておく．
2. MeshModifyTool.unitypackageをUnityProjectにインポートする．
3. Unityの上部メニュー，Window/HhotateA/にゃんにゃんメッシュエディター(MeshModifyTool)を開く.
4. アバターに合わせたい服のメッシュをドラッグ&ドロップして"Setup"をクリック．
5. 編集したいメッシュ名をクリック．
6. 編集ツールを選択する．
7. メッシュを編集する．
8. Saveをクリックして保存．

## Notes.
- If a bug occurs, close the window. Your edits will be lost, but they will usually be restored. (Do not forget to make a backup of your edits beforehand.)
- This tool was created by ToMe, so it may not be maintained very often.

## Terms of Use
- Secondary distribution is permitted, including bundling with avatars, modification, or the entire tool.
- If you distribute the tool, please notify us and credit us. (Not required).
- The creator assumes no responsibility for any problems that may occur using this tool.
- The creator is not responsible for any problems that may occur when using this tool.

## Function Description

Right-click and hold to rotate the avatar editing screen, and mouse wheel to move it.

![alt](./Manual/001.png)
- Setup : Update the list of meshes under the root.
- Mesh List : Click the name of the mesh you wish to edit. Click the checkbox on the left to hide the object.

- SaveAsBlendShape : Save the current edit as a BlendShape of the left text box name.

- Undo : Redo the editing.
- Redo : Undo the Undo

### Normal edit mode
![alt](./Manual/002.png)
 The mesh at the clicked position can be pulled and inflated.

- Power : Strength of push/pull (-1 push, +1 push)
- Width : The range of influence of the edit from the click point.
- Strengh : Smoothness of the deformation within the range (1≧smooth, 1≦uniform)

- Mirror(x,y,z) : Edit symmetrically along x(y,z) axis.

 ### Vertex edit mode
![alt](./Manual/003.png)
  Move the clicked vertex from the blue point to the red point.

 - Width : The range of influence of the edit from the clicked point.
 - Strengh : Smoothness of the transformation within the range (1≥smooth, 1≤uniform)

- Mirror(x,y,z) : Editing is performed symmetrically along the x(y,z) axis.

### Mesh editing functions
![alt](./Manual/004.png)
 Move, copy, and edit each polygon

 - Land selection : select all connected vertices at once (note that it is a bit heavy)
 - Polygon selection : Select one polygon at a time

 - Transform : Move the selected polygon
 - Copy : Duplicate the selected polygon (Can not undo) [Reference](https://twitter.com/HhotateA_xR/status/1395655196781387778?s=20)
 - Deleate : Delete selected polygon(Can not undo)

 ### ActiveExperimental
![alt](./Manual/005.png)
![alt](./Manual/006.png)
 - SelectVertexMode : Operation points are sucked to vertices during normal editing and vertex editing functions.
 - RealtimeTransform : Edit as an object on Scene during vertex and mesh editing [Reference](https://twitter.com/HhotateA_xR/status/1396059845766172674?s=20)
 - SelectOverlapping : select overlapping vertices at once during mesh editing

 ### ActiveExperimentalBeta
![alt](./Manual/007.png)
 - Delete : Simultaneous deletion of polygons by "Delete" during mesh editing
 - MergeBones : Bone reduction function (HumanBone:Remove bones not included in HumanoidBone from reference, ActiveBone:Remove bones that are hidden in Scene from reference)
 - ChangeBone : move the reference of a bone to another Humanoid (Merge: add a non-existent auxiliary bone, Combine: follow a non-existent auxiliary bone with Constraint, Constraint: only Constraint settings are available)
 - CombineMesh : Combine meshes (ActiveMesh:Create a SkinnedMesh that combines all visible meshes under root, Material:Combine sub-meshes of selected mesh for each Shader) [Reference](https:// twitter.com/HhotateA_xR/status/1398421460973064196?s=20) [Reference](https://twitter.com/HhotateA_xR/status/1392077207061745664?s=20)
 - RandmizeVertex : Randomly deforms the mesh to prevent avatar ripping. (Deprecated)
 - CopyBoneWeight : Copy BoneWeight from other SkinedMesh (deprecated)
 - Decimate : Reduce polygon count to a target value (deprecated)
 - WeightCopy : Copy the weight value of the selected polygon from other vertices in the mesh editing function. [Reference](https://twitter.com/HhotateA_xR/status/1398421178432192513?s=20)
 - Decimate : Decimate the clicked polygon.

## Produced by.
@HhotateA_xR
To report a problem, go to https://github.com/HhotateA/AvatarModifyTools

## Update History
2021/05/29 v1.1 release started
2021/07/08 v1.2 Release of TextureModifyTool and update of AvatarModifityTool
2021/07/31 v1.25
2021/08/13 v1.26
2021/08/27 v1.27
2021/09/03 v1.29
2021/09/10 v1.30 Incorporation of UnityMeshSimplifier

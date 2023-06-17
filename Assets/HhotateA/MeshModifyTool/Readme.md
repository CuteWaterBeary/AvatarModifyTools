download https://github.com/HhotateA/AvatarModifyTools/releases/tag/v1

# NyanNyan Mesh Editor (MeshModifyTool)

! [alt](./Manual/000.png)
This tool enables simple mesh deformation with Unity's Editor, for example, to change the avatar's clothes for VRChat.

## Import method, using manual
1. Make a backup of your avatar upload project in advance.
2. Import MeshModifyTool.unitypackage into UnityProject.
3. Open Window/HhotateA/NyanNyan Mesh Editor (MeshModifyTool) in the top menu of Unity.
4. Drag and drop the clothing mesh you want to match onto the avatar and click "Setup".
5. Click on the name of the mesh you wish to edit.
6. Select the editing tool.
7. Edit the mesh.
8. Click Save to save the file.

## Notes.
- If a bug occurs, close the window. Your edits will be lost, but they will usually be restored. (Do not forget to make a backup of your edits beforehand.)
- This tool was created by ToMe, so it may not be maintained very often.

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
- Strengh : Smoothness of the deformation within the range (1 ≧ smooth, 1 ≦ uniform)

- Mirror(x,y,z) : Edit symmetrically along x(y,z) axis.

 ### Vertex edit mode
![alt](./Manual/003.png)
  Move the clicked vertex from the blue point to the red point.

 - Width : The range of influence of the edit from the clicked point.
 - Strengh : Smoothness of the transformation within the range (1 ≥ smooth, 1 ≤ uniform)

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
 - CombineMesh : Combine meshes (ActiveMesh:Create a SkinnedMesh that combines all visible meshes under root, Material:Combine sub-meshes of selected mesh for each Shader) [Reference](https://twitter.com/HhotateA_xR/status/1398421460973064196?s=20) [Reference](https://twitter.com/HhotateA_xR/status/1392077207061745664?s=20)
 - RandmizeVertex : Randomly deforms the mesh to prevent avatar ripping. (Deprecated)
 - CopyBoneWeight : Copy BoneWeight from other SkinedMesh (deprecated)
 - Decimate : Reduce polygon count to a target value (deprecated)
 - WeightCopy : Copy the weight value of the selected polygon from other vertices in the mesh editing function. [Reference](https://twitter.com/HhotateA_xR/status/1398421178432192513?s=20)
 - Decimate : Decimate the clicked polygon.

﻿/*
AvatarModifyTools
https://github.com/HhotateA/AvatarModifyTools

Copyright (c) 2021 @HhotateA_xR

This software is released under the MIT License.
http://opensource.org/licenses/mit-license.php
*/
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using HhotateA.AvatarModifyTools.Core;
using UnityEditor;

namespace HhotateA.AvatarModifyTools.MagicalDresserInventorySystem
{
    public class MagicalDresserInventorySaveData : ScriptableObject
    {
        public string name = "MagicalDresserInventorySaveData";
        public Texture2D icon = null;
        public List<MenuElement> menuElements = new List<MenuElement>();
        public LayerSettings[] layerSettingses;
        public AvatarModifyData assets;

        public MagicalDresserInventorySaveData()
        {
            layerSettingses = Enumerable.Range(0,Enum.GetValues(typeof(LayerGroup)).Length).
                Select(l=>new LayerSettings()).ToArray();
        }

        public void ApplyRoot(GameObject root)
        {
            foreach (var menuElement in menuElements)
            {
                foreach (var item in menuElement.activeItems)
                {
                    item.GetRelativeGameobject(root.transform);
                }
                foreach (var item in menuElement.inactiveItems)
                {
                    item.GetRelativeGameobject(root.transform);
                }
            }
        }
        public void ApplyPath(GameObject root)
        {
            foreach (var menuElement in menuElements)
            {
                foreach (var item in menuElement.activeItems)
                {
                    item.GetRelativePath(root);
                }
                foreach (var item in menuElement.inactiveItems)
                {
                    item.GetRelativePath(root);
                }
            }
        }
    }

    [Serializable]
    public class LayerSettings
    {
        public bool isSaved = true;
        //public DefaultValue defaultValue;
        public string defaultElementGUID = "";


        public MenuElement GetDefaultElement(List<MenuElement> datas)
        {
            return datas.FirstOrDefault(d => d.guid == defaultElementGUID);
        }
        
        public void SetDefaultElement(MenuElement element)
        {
            if (element != null)
            {
                defaultElementGUID = element.guid;
            }
            else
            {
                defaultElementGUID = "";
            }
        }
    }
    
    [Serializable]
    public class MenuElement
    {
        public string name;
        public Texture2D icon;
        public List<ItemElement> activeItems = new List<ItemElement>();
        public List<ItemElement> inactiveItems = new List<ItemElement>();
        public bool isToggle = true;
        public LayerGroup layer = LayerGroup.Layer_A;
        public bool isSaved = true;
        public bool isDefault = false;
        public string param = "";
        public int value = 0;
        public string guid;

        public MenuElement()
        {
            guid = Guid.NewGuid().ToString();
        }

        public string DefaultIcon()
        {
            return isToggle ? EnvironmentGUIDs.itemIcon :
                layer == LayerGroup.Layer_A ? EnvironmentGUIDs.dressAIcon :
                layer == LayerGroup.Layer_B ? EnvironmentGUIDs.dressBIcon :
                layer == LayerGroup.Layer_C ? EnvironmentGUIDs.dressCIcon :
                EnvironmentGUIDs.itemboxIcon;
        }

        public void SetToDefaultIcon()
        {
            icon = AssetUtility.LoadAssetAtGuid<Texture2D>(DefaultIcon());
        }

        public bool IsDefaultIcon()
        {
            return AssetDatabase.GetAssetPath(icon) == AssetDatabase.GUIDToAssetPath(DefaultIcon());
        }

        public void SetLayer(bool t)
        {
            if (IsDefaultIcon())
            {
                isToggle = t;
                SetToDefaultIcon();
            }
            else
            {
                isToggle = t;
            }
        }
        public void SetLayer(LayerGroup l)
        {
            if (IsDefaultIcon())
            {
                layer = l;
                SetToDefaultIcon();
            }
            else
            {
                layer = l;
            }
        }
    }
    
    [Serializable]
    public class ItemElement
    {
        public bool active = true;
        public GameObject obj;
        public string path;
        public FeedType type = FeedType.None;
        public float delay = 0f;
        public float duration = 1f;

        public Shader animationShader;
        public string animationParam = "_AnimationTime";

        public ItemElement(GameObject o,bool defaultActive = true)
        {
            obj = o;
            active = defaultActive;
        }
        
        public ItemElement Clone(bool invert = false)
        {
            return new ItemElement(obj)
            {
                active = invert ? !active : active,
                path = path,
                type = type,
                delay = delay,
                duration = duration,
                animationShader = animationShader,
                animationParam = animationParam,
            };
        }
        
        public void GetRelativePath(GameObject root)
        {
            if (!obj) return;
            if (obj == root)
            {
                path = "";
            }
            else
            {
                path = obj.gameObject.name;
                Transform parent = obj.transform.parent;
                while (parent != null)
                {
                    if(parent.gameObject == root) break;
                    path = parent.name + "/" + path;
                    parent = parent.parent;
                }
            }
        }
        
        public void GetRelativeGameobject(Transform root)
        {
            if (String.IsNullOrWhiteSpace(path)) return;
            var cs = path.Split('/');
            foreach (var c in cs)
            {
                root = root.FindInChildren(c);
            }

            obj = root.gameObject;
        }
    }

    public static class AssetLink
    {
        public static Shader GetShaderByType(this FeedType type)
        {
            if (type == FeedType.Feed)
            {
                return AssetUtility.LoadAssetAtGuid<Shader>(EnvironmentGUIDs.feedShader);
            }
            if (type == FeedType.Crystallize)
            {
                return AssetUtility.LoadAssetAtGuid<Shader>(EnvironmentGUIDs.crystallizeShader);
            }
            if (type == FeedType.Dissolve)
            {
                return AssetUtility.LoadAssetAtGuid<Shader>(EnvironmentGUIDs.disolveShader);
            }
            if (type == FeedType.Draw)
            {
                return AssetUtility.LoadAssetAtGuid<Shader>(EnvironmentGUIDs.drawShader);
            }
            if (type == FeedType.Explosion)
            {
                return AssetUtility.LoadAssetAtGuid<Shader>(EnvironmentGUIDs.explosionShader);
            }
            if (type == FeedType.Geom)
            {
                return AssetUtility.LoadAssetAtGuid<Shader>(EnvironmentGUIDs.geomShader);
            }
            if (type == FeedType.Mosaic)
            {
                return AssetUtility.LoadAssetAtGuid<Shader>(EnvironmentGUIDs.mosaicShader);
            }
            if (type == FeedType.Polygon)
            {
                return AssetUtility.LoadAssetAtGuid<Shader>(EnvironmentGUIDs.polygonShader);
            }
            if (type == FeedType.Bounce)
            {
                return AssetUtility.LoadAssetAtGuid<Shader>(EnvironmentGUIDs.scaleShader);
            }

            return null;
        }
        public static Material GetMaterialByType(this FeedType type)
        {
            if (type == FeedType.Feed)
            {
                return AssetUtility.LoadAssetAtGuid<Material>(EnvironmentGUIDs.feedMaterial);
            }
            if (type == FeedType.Crystallize)
            {
                return AssetUtility.LoadAssetAtGuid<Material>(EnvironmentGUIDs.crystallizeMaterial);
            }
            if (type == FeedType.Dissolve)
            {
                return AssetUtility.LoadAssetAtGuid<Material>(EnvironmentGUIDs.disolveMaterial);
            }
            if (type == FeedType.Draw)
            {
                return AssetUtility.LoadAssetAtGuid<Material>(EnvironmentGUIDs.drawMaterial);
            }
            if (type == FeedType.Explosion)
            {
                return AssetUtility.LoadAssetAtGuid<Material>(EnvironmentGUIDs.explosionMaterial);
            }
            if (type == FeedType.Geom)
            {
                return AssetUtility.LoadAssetAtGuid<Material>(EnvironmentGUIDs.geomMaterial);
            }
            if (type == FeedType.Mosaic)
            {
                return AssetUtility.LoadAssetAtGuid<Material>(EnvironmentGUIDs.mosaicMaterial);
            }
            if (type == FeedType.Polygon)
            {
                return AssetUtility.LoadAssetAtGuid<Material>(EnvironmentGUIDs.polygonMaterial);
            }
            if (type == FeedType.Bounce)
            {
                return AssetUtility.LoadAssetAtGuid<Material>(EnvironmentGUIDs.scaleMaterial);
            }

            return null;
        }

        public static FeedType GetTypeByShader(this Shader shader)
        {
            var guid = AssetUtility.GetAssetGuid(shader);
            if (guid == EnvironmentGUIDs.feedShader)
            {
                return FeedType.Feed;
            }
            if (guid == EnvironmentGUIDs.crystallizeShader)
            {
                return FeedType.Crystallize;
            }
            if (guid == EnvironmentGUIDs.disolveShader)
            {
                return FeedType.Dissolve;
            }
            if (guid == EnvironmentGUIDs.drawShader)
            {
                return FeedType.Draw;
            }
            if (guid == EnvironmentGUIDs.explosionShader)
            {
                return FeedType.Explosion;
            }
            if (guid == EnvironmentGUIDs.geomShader)
            {
                return FeedType.Geom;
            }
            if (guid == EnvironmentGUIDs.mosaicShader)
            {
                return FeedType.Mosaic;
            }
            if (guid == EnvironmentGUIDs.polygonShader)
            {
                return FeedType.Polygon;
            }
            if (guid == EnvironmentGUIDs.scaleShader)
            {
                return FeedType.Bounce;
            }

            return FeedType.None;
        }
            
    }
    
    public enum FeedType
    {
        None,
        Scale,
        Shader,
        Feed,
        Crystallize,
        Dissolve,
        Draw,
        Explosion,
        Geom,
        Mosaic,
        Polygon,
        Bounce,
    }

    public enum LayerGroup : int
    {
        Layer_A,
        Layer_B,
        Layer_C
    }

    public enum ToggleGroup
    {
        IsToggle,
    }
}
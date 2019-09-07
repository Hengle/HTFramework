﻿namespace HT.Framework
{
    /// <summary>
    /// 资源信息基类
    /// </summary>
    public abstract class ResourceInfoBase
    {
        /// <summary>
        /// AssetBundle的名称
        /// </summary>
        public string AssetBundleName;
        /// <summary>
        /// Asset的路径
        /// </summary>
        public string AssetPath;
        /// <summary>
        /// Resources文件夹中的路径
        /// </summary>
        public string ResourcePath;

        public ResourceInfoBase(string assetBundleName, string assetPath, string resourcePath)
        {
            AssetBundleName = assetBundleName != null ? assetBundleName.ToLower() : assetBundleName;
            AssetPath = assetPath;
            ResourcePath = resourcePath;
        }

        /// <summary>
        /// 获取资源的Resource全路径
        /// </summary>
        public string GetResourceFullPath()
        {
            return string.Format("Resources/{0}", ResourcePath);
        }

        /// <summary>
        /// 获取资源的AssetBundle全路径
        /// </summary>
        public string GetAssetBundleFullPath(string assetBundleRootPath)
        {
            return string.Format("AssetBundlePath:{0}{1}  AssetPath:{2}", assetBundleRootPath, AssetBundleName, AssetPath);
        }
    }
}

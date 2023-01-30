using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

namespace Utils
{

    /// <summary>
    /// MiscUtils: Miscellaneous functions for general purpose operations.
    /// </summary>
    public class MiscUtils
    {

        public static void HideObject(GameObject obj)
        {
            obj.SetActive(false);
        }

        public static void DisplayObject(GameObject obj)
        {
            obj.SetActive(true);
        }

        public static bool TagComparer(GameObject obj, TagsEnum tag)
        {
            return obj.CompareTag(tag.ToString());
        }

    }

}


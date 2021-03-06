﻿using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditorInternal;
#endif

using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

namespace DEFAULTNAMESPACE
{
	public class QuitButton : MonoBehaviour
	{
        void Start()
        {
            GetComponent<Button>().onClick.AddListener(Quit);
        }

        void Quit()
        {
            if (Application.isEditor)
            {
#if UNITY_EDITOR
                EditorApplication.isPlaying = false;
#endif
            }
            else
                Application.Quit();
        }
    }
}
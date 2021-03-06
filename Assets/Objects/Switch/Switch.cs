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

using UnityEngine.Events;

namespace DEFAULTNAMESPACE
{
    public abstract class Switch : MonoBehaviour
    {
        public abstract bool Active { get; }

        public event Action OnActivity;
        protected void TriggerActivity()
        {
            if (OnActivity != null)
                OnActivity.Invoke();
        }

        public bool IsActivator(GameObject gameObject)
        {
            return gameObject.CompareTag("Player") || gameObject.CompareTag("Prop");
        }
    }
}
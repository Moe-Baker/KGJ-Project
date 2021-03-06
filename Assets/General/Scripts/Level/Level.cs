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
    [DefaultExecutionOrder(ExecutionOrder)]
	public class Level : MonoBehaviour
	{
        public const int ExecutionOrder = -200;

        public static Level Instance { get; protected set; }

        FollowCamera followCamera;
        public FollowCamera FollowCamera { get { return followCamera; } }

        public Player player1;
        public Player player2;

        [NonSerialized]
        public RoomsList roomsList;

        [NonSerialized]
        public InGameUI InGameUI;
        [NonSerialized]
        public GameState state = GameState.Idle;
        public bool IsPlaying { get { return state == GameState.Playing && !InGameUI.pauseMenu.active; } }

        void Awake()
        {
            Instance = this;

            followCamera = FindObjectOfType<FollowCamera>();
            InGameUI = FindObjectOfType<InGameUI>();
            roomsList = FindObjectOfType<RoomsList>();
        }
	}

    public enum GameState
    {
        Idle, Playing, End
    }
}
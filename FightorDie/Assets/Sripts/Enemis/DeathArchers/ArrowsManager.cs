﻿using UnityEngine;
using System.Collections;

public class ArrowsManager : MonoBehaviour {
    private SkeletonAnimation m_animation; 
	// Use this for initialization
	void Start () {
        m_animation = this.GetComponent<SkeletonAnimation>();
        m_animation.state.End += state_End;
	}

    void state_End(Spine.AnimationState state, int trackIndex)
    {
        if (state.GetCurrent(trackIndex) + "" == "tankai") {
            Destroy(this.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnDestroy() {
        m_animation.state.End -= state_End;
    }
}
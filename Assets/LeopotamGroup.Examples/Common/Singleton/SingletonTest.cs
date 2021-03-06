﻿using LeopotamGroup.Common;
using UnityEngine;

namespace LeopotamGroup.Examples.Common.SingletonTest {
    public class SingletonTest : MonoBehaviour {
        void Start () {
            Singleton.Get<MySingletonManager> ().Test ();
            Debug.Log ("MySingletonManager.GetStringParameter: " + Singleton.Get<MySingletonManager> ().GetStringParameter ());
        }

        void OnDestroy () {
            // Dont forget to check Singleton.IsTypeRegistered<T> () at any OnDestroy method (it can be
            // already killed before, execution order not defined), otherwise new instance of singleton class
            // will be created and unity throw exception about it.
            if (Singleton.IsTypeRegistered<MySingletonManager> ()) {
                Debug.Log ("MySingletonManager still alive!");
            } else {
                Debug.Log ("MySingletonManager already killed!");
            }
        }
    }
}
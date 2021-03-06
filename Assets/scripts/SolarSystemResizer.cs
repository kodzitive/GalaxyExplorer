﻿// Copyright Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;

namespace GalaxyExplorer
{
    public class SolarSystemResizer : MonoBehaviour
    {
        void Awake()
        {
            transform.localScale = transform.localScale * GalaxyExplorerManager.SolarSystemScaleFactor;
        }
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public static int pipesPassed { get; set; }
    public static bool isWkeyEnabled { get; set; }
    public static float pipePeriod{ get; set; }
    public static float vitality{ get; set; }
}
/* Об'єкт-стан -- доступний для усіх скриптів "центр"
 * збереження загальної інформації щодо стану гри
 */
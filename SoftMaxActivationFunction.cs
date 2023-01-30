/******************************************************************************
 * Purpose: Very simple SoftMax function script implementation for Unity3D    *
 ******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftMaxActivationFunction : MonoBehaviour
{ 
    // SoftMax
    public static float [] softMax(float[] vectorAction)
    {
        float expSum = 0f;
        float arrayMaxValue = returnArrayMax(vectorAction);
        for (int i = 0; i < vectorAction.Length; i++)
            vectorAction[i] -= arrayMaxValue;

        for (int i = 0; i < vectorAction.Length; i++)
            expSum += Mathf.Exp(vectorAction[i]);
        for (int i = 0; i < vectorAction.Length; i++)
            vectorAction[i] = Mathf.Exp(vectorAction[i]) / expSum;
        return vectorAction;
    }

    // Returns Max Value from Array
    public static float returnArrayMax(float[] array)
    {
        float maxValue = -9999999f;
        for (int i = 0; i < array.Length; i++)
            if (array[i] > maxValue)
                maxValue = array[i];
        return maxValue;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeightDisplay : MonoBehaviour
{
    public WeightScale leftWeightScale;
    public WeightScale rightWeightScale;
    public Text weightText;
    //public Animator leftStageAnimator;
    //public Animator rightStageAnimator;

    private void Update()
    {
        if (leftWeightScale == null || rightWeightScale == null) /*leftStageAnimator == null || rightStageAnimator == null*/
        {
            Debug.LogWarning("Please assign the left and right WeightScale scripts in the inspector.");
            return;
        }

        float leftMass = leftWeightScale.calculatedMass;
        float rightMass = rightWeightScale.calculatedMass;

        if (leftMass > rightMass)
        {
            weightText.text = $"{FormatMass(leftMass)} > {FormatMass(rightMass)}";
            //leftStageAnimator.SetBool("IsLeftSideHeavier", false);
            //leftStageAnimator.SetBool("IsRightSideHeavier", true);
            //leftStageAnimator.SetBool("IsBothSideEqual", false);
            //rightStageAnimator.SetBool("IsLeftSideHeavier", false);
            //rightStageAnimator.SetBool("IsRightSideHeavier", true);
            //rightStageAnimator.SetBool("IsBothSideEqual", false);
        }
        else if (leftMass < rightMass)
        {
            weightText.text = $"{FormatMass(leftMass)} < {FormatMass(rightMass)}";
            //leftStageAnimator.SetBool("IsLeftSideHeavier", true);
            //leftStageAnimator.SetBool("IsRightSideHeavier", false);
            //leftStageAnimator.SetBool("IsBothSideEqual", false);
            //rightStageAnimator.SetBool("IsLeftSideHeavier", true);
           // rightStageAnimator.SetBool("IsRightSideHeavier", false);
           // rightStageAnimator.SetBool("IsBothSideEqual", false);
        }
        else
        {
            weightText.text = $"{FormatMass(leftMass)} = {FormatMass(rightMass)}";
            //leftStageAnimator.SetBool("IsLeftSideHeavier", false);
           // leftStageAnimator.SetBool("IsRightSideHeavier", false);
            //leftStageAnimator.SetBool("IsBothSideEqual", true);
           // rightStageAnimator.SetBool("IsLeftSideHeavier", false);
            //rightStageAnimator.SetBool("IsRightSideHeavier", false);
            //rightStageAnimator.SetBool("IsBothSideEqual", true);
        }
    }

    private string FormatMass(float mass)
    {
        return $"{mass:F1}";
    }
}


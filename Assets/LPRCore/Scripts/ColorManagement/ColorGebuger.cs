using UnityEngine;

public class ColorGebuger : MonoBehaviour
{
    [SerializeField] private ColorsSO colorsSO;

    private void Start()
    {
        
    }

    private void DebudEnum()
    {
        string longString = "";
        for (int i = 0; i < colorsSO.ColorStructArray.Length; i++)
        {
            longString += "nes" + (colorsSO.ColorStructArray[i].ColorCode) + $" = {i}, \n";
        }
        Debug.Log(longString);
    }


    //private void SetDefaultColorFrictionCurve() => colorsSO.SetDefaultColorFrictionCurve();
}

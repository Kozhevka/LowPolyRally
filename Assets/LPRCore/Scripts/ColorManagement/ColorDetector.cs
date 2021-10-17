using UnityEngine;

public class ColorDetector : Singleton<ColorDetector>
{
    [SerializeField] private ColorsSO colorSO;
    [SerializeField] private MeshRenderer currentMap;

    private Color[] colorsArray;
    private int errorDetect = -1;

    public ColorsSO ColorSO { get => colorSO; private set => colorSO = value; }
    public MeshRenderer CurrentMap { get => currentMap; set => currentMap = value; }

    private void Start()
    {
        

        colorsArray = new Color[colorSO.ColorStructArray.Length];

        for (int i = 0; i < colorsArray.Length; i++)
            colorsArray[i] = colorSO.ColorStructArray[i].Color;
    }

    public WheelGroundColor DetectColorType(Color incomeColor, ColorEnum currentColor)
    {
        if (incomeColor == colorSO.ColorStructArray[(int)currentColor].Color)
            return null;


        int colorIndex = DetectColorIndex(incomeColor);

        if (colorIndex == errorDetect)
        {
            Debug.LogError($"Cant detectColor {ColorUtility.ToHtmlStringRGB(incomeColor)}");
            return new WheelGroundColor { ColorEnumType = 0, ColorStruct = colorSO.ColorStructArray[0] };
        }

        WheelGroundColor wheelGroundColor = new WheelGroundColor();
        wheelGroundColor.ColorEnumType = (ColorEnum)colorIndex;
        wheelGroundColor.ColorStruct = colorSO.ColorStructArray[colorIndex];

        return wheelGroundColor;
    }

    private int DetectColorIndex(Color incomeColor)
    {
        for (int i = 0; i < colorsArray.Length; i++) 
            if (incomeColor == colorsArray[i]) 
                return i;
        return errorDetect;
    }
}

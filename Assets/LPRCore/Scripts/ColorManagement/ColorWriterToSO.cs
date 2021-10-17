using UnityEngine;
using UnityEngine.InputSystem;

public class ColorWriterToSO : MonoBehaviour
{
    [SerializeField] private ColorsSO colorSO;

    public Camera cam;

    private InputAction click;

    void Awake()
    {
        cam = GetComponent<Camera>();
        click = new InputAction(binding: "<Mouse>/leftButton");
        click.performed += ctx => {
            RaycastHit hit;
            Vector3 coor = Mouse.current.position.ReadValue();
            if (Physics.Raycast(cam.ScreenPointToRay(coor), out hit))
            {
                MouseDown(hit);
            }
        };
        click.Enable();
    }

    void MouseDown(RaycastHit hit)
    {
        Renderer rend = hit.transform.GetComponent<Renderer>();
        MeshCollider meshCollider = hit.collider as MeshCollider;

        if (rend == null || rend.sharedMaterial == null || rend.sharedMaterial.mainTexture == null || meshCollider == null)
            return;

        Texture2D tex = rend.material.mainTexture as Texture2D;
        Vector2 pixelUV = hit.textureCoord;
        pixelUV.x *= tex.width;
        pixelUV.y *= tex.height;

        //colorSO.AddColorToArray(tex.GetPixel((int)pixelUV.x, (int)pixelUV.y));
    }
}

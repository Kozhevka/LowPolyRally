using UnityEngine;

/// <summary>
/// Singletom MonoBeh class for  managers inheritance.
/// </summary>
/// <typeparam name="T"></typeparam>
public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T instance = null;

    private bool alive = true;

    public static T Instance
    {
        get
        {
            if (instance != null)
                return instance;
            else
            {
                ///Find T
                T[] managers = GameObject.FindObjectsOfType<T>();
                if (managers.Length == 1)
                {
                    instance = managers[0];
                    DontDestroyOnLoad(instance);
                    return instance;
                }
                else
                {
                    if (managers.Length > 1)
                    {
                        Debug.LogError($"have more that one {typeof(T).Name}");
                        for (int i = 0; i < managers.Length; ++i)
                        {
                            T manager = managers[i];
                            Destroy(manager.gameObject);
                        }
                    }
                }
            }

            GameObject go = new GameObject(typeof(T).Name, typeof(T));
            instance = go.GetComponent<T>();

            
            DontDestroyOnLoad(instance.gameObject);
            return instance;
        }
        set
        {
            instance = value as T;
        }
    }

    public static bool IsAlive
    {
        get
        {
            if (instance == null)
                return false;
            return instance.alive;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this as T;
        }
        else
        {
            Debug.LogError($"Have more that one {typeof(T).Name} in scene. " +
                            "But this is Singleton! Check project.");
            DestroyImmediate(this);
        }
    }

    protected void OnDestroy() { alive = false; }

    protected void OnApplicationQuit() { alive = false; }
}



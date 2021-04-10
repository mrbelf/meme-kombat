using UnityEngine;

namespace Core.Utility.SingletonPattern
{
    public abstract class Singleton<T> : MonoBehaviour where T : Component
    {
        static T Instance;

        public bool ResetInstanceOnDestroy;

        protected virtual void Awake()
        {
            if (Instance)
            {
                Destroy(this.gameObject);
            }
            else
            {
                Instance = this as T;
            }
        }

        public static T GetInstance()
        {
            if (!Instance)
            {
                Instance = (Instantiate(Resources.Load("Singletons/" + typeof(T).Name)) as GameObject).GetComponent<T>();
                DontDestroyOnLoad(Instance);
                if (!Instance)
                {
                    Debug.LogError("No singleton found on resources folder at: " + "Singletons/" + typeof(T).Name + ".asset");
                }
            }

            return Instance;
        }
    }
}

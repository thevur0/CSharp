namespace DesignMode
{
    //class Singleton<T> where T : class, new()
    //{
    //    static T m_Mgr = null;
    //    public static T Instance
    //    {
    //        get
    //        {
    //            if (m_Mgr == null)
    //                m_Mgr = new T();
    //            return m_Mgr;
    //        }
    //    }
    //}

    //class Singleton<T> where T : class, new()
    //{
    //    static System.Lazy<T> _instance = new System.Lazy<T>();
    //    public static T Instance
    //    {
    //        get
    //        {
    //            return _instance.Value;
    //        }
    //    }
    //}

    class Singleton<T> where T : class, new()
    {
        static T _instance = null;
        static public T Instance
        {
            get
            {
                return _instance ?? (_instance = new T());
            }
        }
    }
}

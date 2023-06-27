namespace Singlton._7concept

{
    public sealed class SimpleThreadSafeSinglton
    {
        private static SimpleThreadSafeSinglton instance = null;
        private static readonly object padlock = new object();

        SimpleThreadSafeSinglton()
        {

        }

        public static SimpleThreadSafeSinglton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SimpleThreadSafeSinglton();
                    }
                    return instance;
                }
            }
        }
    }
}

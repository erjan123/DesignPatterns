namespace Bridge.OpenBook
{
    static class OpenBookExtensions
    {
        public static void SuperPoke(this Portal me, string who, string what)
        {
            me.Add(who, what + " you");
        }
    }
}

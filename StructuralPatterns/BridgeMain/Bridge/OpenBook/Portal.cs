namespace Bridge.OpenBook
{
    // IBridge Pattern Example Judith Bishop Dec 2006, Aug 2007
    // Extending SpaceBook with a second implementation via a Portal
    // Abstraction
    class Portal
    {
        IBridge bridge;
        public Portal(IBridge aSpaceBook)
        {
            bridge = aSpaceBook;
        }
        public void Add(string message)
        { bridge.Add(message); }
        public void Add(string friend, string message)
        { bridge.Add(friend, message); }
        public void Poke(string who)
        { bridge.Poke(who); }
    }
}

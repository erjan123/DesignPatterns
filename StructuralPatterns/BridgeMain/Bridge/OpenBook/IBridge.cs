namespace Bridge.OpenBook
{
    // IBridge
    interface IBridge
    {
        void Add(string message);
        void Add(string friend, string message);
        void Poke(string who);
    }
}

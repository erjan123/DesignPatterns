namespace Chain_of_Resp.ChainOfResponsibilityTheoretical
{
    public static partial class ChainwithStatePattern
    {
        class Handler
        {
            Handler next;
            int id;
            public int Limit { get; set; }
            public Handler(int id, Handler handler)
            {
                this.id = id;
                Limit = id * 1000;
                next = handler;
            }
            public string HandleRequest(int data)
            {
                if (data < Limit)
                    return "Request for " + data + " handled at level " + id;
                else if (next != null)
                    return next.HandleRequest(data);
                else return ("Request for " + data + " handled BY DEFAULT at level " + id);
            }
        }
    }
}

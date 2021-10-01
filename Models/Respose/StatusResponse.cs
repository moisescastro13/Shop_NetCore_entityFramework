namespace Models.Respose
{
    public class Status
    {
        public int Exito { get;set; }
        public string? Message { get;set; }
        public object Data { get;set; }

        public Status()
        {
            this.Exito = 0;
        }
    }
}
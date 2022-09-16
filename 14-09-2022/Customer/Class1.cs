namespace classes
{
    [Serializable()]
    public class Customer
    {
        
        public int Id { get; set; }
        public string Password { get; set; }

        public bool loginstatus { get; private set; }
        private DateTime date = DateTime.Now;

        public void Validateuser(Customer customer)
        {
            if (customer.Password == customer.Id + "password")
            {
                loginstatus = true;
            }
            else
            {
                loginstatus = false;
            }
        }
    }
}
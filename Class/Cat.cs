namespace Class
{
    class Cat
    {
        public string name;
        public double weight;
        private string secretPassword;

        public Cat()
        {
            this.name = "Default name";
        }

        public Cat(string name)
        {
            this.name = name;
        }

        public Cat(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public Cat(string name, double weight, string password)
        {
            this.name = name;
            this.weight = weight;
            this.secretPassword = password;
        }

        public string TellSecretPassword()
        {
            return this.secretPassword;
        }

        public void SetPassword(string newPassword)
        {
            this.secretPassword = newPassword;
        }
    }


}

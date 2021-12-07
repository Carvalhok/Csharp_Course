namespace Vectors
{
    class Room
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Numero { get; set; }

        public Room(string nome, string email, int numero)
        {
            Nome = nome;
            Email = email;
            Numero = numero;
        }

        public override string ToString()
        {
            return Numero + ": " + Nome + ", " + Email;
        }
    }
}

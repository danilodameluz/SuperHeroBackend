namespace SuperHero.Models
{
    public class SuperHero
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public string? NomeHeroi { get; set; }
        public List<SuperPoder>? Superpoderes { get; set; }
        public DateOnly DataNascimento { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
    }
}

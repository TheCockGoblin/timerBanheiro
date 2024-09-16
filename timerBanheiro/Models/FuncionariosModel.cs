namespace timerBanheiro.Models
{
    public class FuncionariosModel
    {
        public int id{ get; set; }
        public string nome { get; set; } = string.Empty;
        public string statusIdade { get; set; } = string.Empty;
        public string sexo { get; set; } = string.Empty;
        public int tempoSecs { get; set; }
        public int descontoSalario { get; set; }
        public int pcd { get; set; }

    }
}

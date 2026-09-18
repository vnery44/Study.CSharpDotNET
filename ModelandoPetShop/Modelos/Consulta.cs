namespace ModelandoPetShop.Modelos;

internal class Consulta
{
    public Pet Animal { get; set; }
    public Dono Tutor { get; set; }
    public Medico Veterinario { get; set; }
    public string DataConsulta { get; set; }

    public Consulta(Pet animal, Dono tutor, Medico veterinario, string dataConsulta)
    {
        Animal = animal;
        Tutor = tutor;
        Veterinario = veterinario;
        DataConsulta = dataConsulta;
    }
}


abstract class Animal
{
    public string? Nome { get; set; }

    public DateTime DataNascimento { get; set; }

    public char Sexo { get; set; }

    public bool Carnívoro { get; set; }

    public bool Peçonhento { get; set; }

    public int Idade()
    {
        return 0;
    }

    public abstract void Movimentar();

    public abstract void Comunicar();

    public abstract void Alimentar();
}

abstract class Mamífero
{
    public int QtdeMamas { get; set; }
    public bool Pelos { get; set; }
    public string? CorDoCabelo { get; set; }
    public abstract void Amamentar();
}

abstract class Ave
{
    public bool Rapina { get; set; }

    public bool CorPena { get; set; }

    public void Ciscar()
    {
        return;
    }
}

abstract class Reptil
{
    public bool TemEscamas { get; set; }
    public bool TemCasco { get; set; }
}

interface IAquatico
{
    bool ViveEmTerra { get; set; }
    bool Mergulho { get; set; }
    bool AguaDoce { get; set; }
}

interface IOviparo
{
    void Botar();
    void Chocar();
}

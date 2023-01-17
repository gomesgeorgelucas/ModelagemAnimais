abstract class Animal
{
    public string? Nome { get; init; }

    public DateTime DataNascimento { get; init; }

    public char Sexo { get; init; }

    public bool Carnívoro { get; init; }

    public bool Peçonhento { get; init; }

    public int Idade()
    {
        return DateTime.Today.Year - DataNascimento.Year;
    }

    public abstract void Movimentar();

    public abstract void Comunicar();

    public void Alimentar()
    {
        Console.WriteLine($"{Nome} se alimentou (Varia por animal e espécie).");
    }
}

abstract class Mamífero : Animal
{
    public int QtdeMamas { get; init; }
    public bool Pelos { get; init; }
    public string? CorDoCabelo { get; init; }
    public void Amamentar()
    {
        Console.WriteLine($"{Nome} amamentou.");
    }
}

abstract class Ave : Animal
{
    public bool Rapina { get; init; }

    public bool CorPena { get; init; }

    public void Ciscar()
    {
        Console.WriteLine($"{Nome} ciscou...");
    }
}

abstract class Reptil : Animal
{
    public bool TemEscamas { get; init; }
    public bool TemCasco { get; init; }
}

interface IAquatico
{
    bool ViveEmTerra { get; init; }
    bool Mergulho { get; init; }
    bool AguaDoce { get; init; }
}

interface IOviparo
{
    void Botar();
    void Chocar();
}

interface IVoar
{
    void Voar();
    int AltitudeMaximaEmMetros { get; init; }
    double VelocidadeDoVoo { get; init; }
}

class Leão : Mamífero
{
    public override void Comunicar()
    {
        Console.WriteLine($"{Nome} rugiu.");
    }

    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} se movimentou sobre quatro patas.");
    }
}

class Chacal : Mamífero
{

    public override void Comunicar()
    {
        Console.WriteLine($"{Nome} latiu.");
    }

    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} se movimentou sobre quatro patas.");
    }
}

class Morcego : Mamífero, IVoar
{
    public int AltitudeMaximaEmMetros { get; init; }
    public double VelocidadeDoVoo { get; init; }

    public override void Comunicar()
    {
        Console.WriteLine($"{Nome} usou sonar.");
    }

    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} se moveu com ajuda das asas.");
    }

    public void Voar()
    {
        Console.WriteLine($"{Nome} voou.");
    }
}

class Cisne : Ave, IAquatico, IVoar, IOviparo
{
    public bool ViveEmTerra { get; init; }
    public bool Mergulho { get; init; }
    public bool AguaDoce { get; init; }
    public int AltitudeMaximaEmMetros { get; init; }
    public double VelocidadeDoVoo { get; init; }

    public void Botar()
    {
        Console.WriteLine($"{Nome} botou ovo.");
    }

    public void Chocar()
    {
        Console.WriteLine($"{Nome} chocou ovo.");
    }

    public override void Comunicar()
    {
        Console.WriteLine($"{Nome} arensou.");
    }

    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} caminhou usando as duas patas.");
    }

    public void Voar()
    {
        Console.WriteLine($"{Nome} voou.");
    }
}

class Arara : Ave, IVoar, IOviparo
{
    public int AltitudeMaximaEmMetros { get; init; }
    public double VelocidadeDoVoo { get; init; }

    public void Botar()
    {
        Console.WriteLine($"{Nome} botou ovo.");
    }

    public void Chocar()
    {
        Console.WriteLine($"{Nome} chocou ovo.");
    }

    public override void Comunicar()
    {
        Console.WriteLine($"{Nome} cantou.");
    }
    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} andou usando pés.");
    }

    public void Voar()
    {

        Console.WriteLine($"{Nome} voou.");
    }
}

class DragãoDeComodo : Reptil, IOviparo
{
    public void Botar()
    {
        Console.WriteLine($"{Nome} botou ovo.");
    }

    public void Chocar()
    {
        Console.WriteLine($"{Nome} chocou ovo.");
    }

    public override void Comunicar()
    {
        Console.WriteLine($"{Nome} silvou.");
    }

    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} camihou sobre quatro patas.");
    }
}

class Lontra : Mamífero, IAquatico
{
    public bool ViveEmTerra { get; init; }
    public bool Mergulho { get; init; }
    public bool AguaDoce { get; init; }

    public override void Comunicar()
    {
        Console.WriteLine($"{Nome} chilrou.");
    }

    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} caminhou sobre quatro patas.");
    }
}

class Pinguim : Ave, IOviparo
{
    public void Botar()
    {
        Console.WriteLine($"{Nome} botou ovo.");
    }

    public void Chocar()
    {
        Console.WriteLine($"{Nome} chocou ovo.");
    }

    public override void Comunicar()
    {
        Console.WriteLine($"{Nome} buzinou.");
    }

    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} se movimentou usando os dois pés.");
    }
}

class Coruja : Ave, IVoar, IOviparo
{
    public int AltitudeMaximaEmMetros { get; init; }
    public double VelocidadeDoVoo { get; init; }

    public void Botar()
    {
        Console.WriteLine($"{Nome} botou ovo.");
    }

    public void Chocar()
    {
        Console.WriteLine($"{Nome} chocou ovo.");
    }

    public override void Comunicar()
    {
        Console.WriteLine($"{Nome} corujou.");
    }

    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} caminhou usando os dois pés.");
    }

    public void Voar()
    {
        Console.WriteLine($"{Nome} voou.");
    }
}

class Elefante : Mamífero
{
    public override void Comunicar()
    {
        Console.WriteLine($"{Nome} trumpeteou.");
    }

    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} andou sobre quatro patas.");
    }
}

class Jacaré : Reptil, IOviparo, IAquatico
{
    public bool ViveEmTerra { get; init; }
    public bool Mergulho { get; init; }
    public bool AguaDoce { get; init; }

    public void Botar()
    {
        Console.WriteLine($"{Nome} botou ovo.");
    }

    public void Chocar()
    {
        Console.WriteLine($"{Nome} chocou ovo.");
    }

    public override void Comunicar()
    {
        Console.WriteLine($"{Nome} silvou.");
    }

    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} caminhou sobre quatro patas.");
    }
}

class Ornitorrinco : Mamífero, IAquatico, IOviparo
{
    public bool ViveEmTerra { get; init; }
    public bool Mergulho { get; init; }
    public bool AguaDoce { get; init; }

    public void Botar()
    {
        Console.WriteLine($"{Nome} botou ovo.");
    }

    public void Chocar()
    {
        Console.WriteLine($"{Nome} chocou ovo.");
    }

    public override void Comunicar()
    {
        Console.WriteLine($"{Nome} cantou.");
    }

    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} caminhou sobre quatro patas");
    }
}
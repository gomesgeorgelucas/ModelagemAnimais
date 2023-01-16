abstract class Animal
{
    public string? Nome { get; set; }

    public DateTime DataNascimento { get; set; }

    public char Sexo { get; set; }

    public bool Carnívoro { get; set; }

    public bool Peçonhento { get; set; }

    public int Idade()
    {
        return DateTime.Today.Year - this.DataNascimento.Year;
    }

    public abstract void Movimentar();

    public abstract void Comunicar();

    public abstract void Alimentar();
}

abstract class Mamífero : Animal
{
    public int QtdeMamas { get; set; }
    public bool Pelos { get; set; }
    public string? CorDoCabelo { get; set; }
    public abstract void Amamentar();
}

abstract class Ave : Animal
{
    public bool Rapina { get; set; }

    public bool CorPena { get; set; }

    public void Ciscar()
    {
        Console.WriteLine($"{this.Nome} ciscou...");
    }
}

abstract class Reptil : Animal
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

interface IVoar
{
    void Voar();
    int AltitudeMaximaEmMetros { get; set; }
    double VelocidadeDoVoo { get; set; }
}

class Leão : Mamífero
{
    public override void Alimentar()
    {
        throw new NotImplementedException();
    }

    public override void Amamentar()
    {
        throw new NotImplementedException();
    }

    public override void Comunicar()
    {
        throw new NotImplementedException();
    }

    public override void Movimentar()
    {
        throw new NotImplementedException();
    }
}

class Chacal : Mamífero
{
    public override void Alimentar()
    {
        throw new NotImplementedException();
    }

    public override void Amamentar()
    {
        throw new NotImplementedException();
    }

    public override void Comunicar()
    {
        throw new NotImplementedException();
    }

    public override void Movimentar()
    {
        throw new NotImplementedException();
    }
}

class Morcego : Mamífero, IVoar
{
    public int AltitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void Alimentar()
    {
        throw new NotImplementedException();
    }

    public override void Amamentar()
    {
        throw new NotImplementedException();
    }

    public override void Comunicar()
    {
        throw new NotImplementedException();
    }

    public override void Movimentar()
    {
        throw new NotImplementedException();
    }

    public void Voar()
    {
        throw new NotImplementedException();
    }
}

class Cisne : Ave, IAquatico, IVoar, IOviparo
{
    public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int AltitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void Alimentar()
    {
        throw new NotImplementedException();
    }

    public void Botar()
    {
        throw new NotImplementedException();
    }

    public void Chocar()
    {
        throw new NotImplementedException();
    }

    public override void Comunicar()
    {
        throw new NotImplementedException();
    }

    public override void Movimentar()
    {
        throw new NotImplementedException();
    }

    public void Voar()
    {
        throw new NotImplementedException();
    }
}

class Arara : Ave, IVoar, IOviparo
{
    public int AltitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void Alimentar()
    {
        throw new NotImplementedException();
    }

    public void Botar()
    {
        throw new NotImplementedException();
    }

    public void Chocar()
    {
        throw new NotImplementedException();
    }

    public override void Comunicar()
    {
        throw new NotImplementedException();
    }
    public override void Movimentar()
    {
        throw new NotImplementedException();
    }

    public void Voar()
    {
        throw new NotImplementedException();
    }
}

class DragãoDeComodo : Reptil, IOviparo
{
    public override void Alimentar()
    {
        throw new NotImplementedException();
    }

    public void Botar()
    {
        throw new NotImplementedException();
    }

    public void Chocar()
    {
        throw new NotImplementedException();
    }

    public override void Comunicar()
    {
        throw new NotImplementedException();
    }

    public override void Movimentar()
    {
        throw new NotImplementedException();
    }
}

class Lontra : Mamífero, IAquatico
{
    public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void Alimentar()
    {
        throw new NotImplementedException();
    }

    public override void Amamentar()
    {
        throw new NotImplementedException();
    }

    public override void Comunicar()
    {
        throw new NotImplementedException();
    }

    public override void Movimentar()
    {
        throw new NotImplementedException();
    }
}

class Pinguim : Ave, IOviparo
{
    public override void Alimentar()
    {
        throw new NotImplementedException();
    }

    public void Botar()
    {
        throw new NotImplementedException();
    }

    public void Chocar()
    {
        throw new NotImplementedException();
    }

    public override void Comunicar()
    {
        throw new NotImplementedException();
    }

    public override void Movimentar()
    {
        throw new NotImplementedException();
    }
}

class Coruja : Ave, IVoar, IOviparo
{
    public int AltitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void Alimentar()
    {
        throw new NotImplementedException();
    }

    public void Botar()
    {
        throw new NotImplementedException();
    }

    public void Chocar()
    {
        throw new NotImplementedException();
    }

    public override void Comunicar()
    {
        throw new NotImplementedException();
    }

    public override void Movimentar()
    {
        throw new NotImplementedException();
    }

    public void Voar()
    {
        throw new NotImplementedException();
    }
}

class Elefante : Mamífero
{
    public override void Alimentar()
    {
        throw new NotImplementedException();
    }

    public override void Amamentar()
    {
        throw new NotImplementedException();
    }

    public override void Comunicar()
    {
        throw new NotImplementedException();
    }

    public override void Movimentar()
    {
        throw new NotImplementedException();
    }
}

class Jacaré : Reptil, IOviparo, IAquatico
{
    public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void Alimentar()
    {
        throw new NotImplementedException();
    }

    public void Botar()
    {
        throw new NotImplementedException();
    }

    public void Chocar()
    {
        throw new NotImplementedException();
    }

    public override void Comunicar()
    {
        throw new NotImplementedException();
    }

    public override void Movimentar()
    {
        throw new NotImplementedException();
    }
}
class Music
{
    // Construtor
    // Uma música precisa de uma banda antes, então essa banda é atribuída a música em sua criação
    // A banda se torna obrigatória na criação da música
    public Music(Band artist, string name)
    {
        // propriedade da classe recebe parâmetro do método
        Artist = artist;
        Name = name;
    }

    public string Name { get;  }
    public Band Artist { get; }
    public int Duration { get; set; }
    public bool Available { get; set; }

    // Não permitindo escrever valor, apenas exibir (get)
    // get { return $"A música {Name} pertence à banda {Artist}" } => lambda
    public string Description => $"A música {Name} pertence à banda {Artist}";

    public Genre Genre { get; set; }


    /*
    ----------------------------------------------------------------------------------------------------------------
    Propriedades: get; set;
    ----------------------------------------------------------------------------------------------------------------
    -> É uma abstração que fornece um meio de acessar e modificar os valores dos atributos de uma classe, encapsulando a lógica de leitura e escrita
    -> Available deixa de ser VARIÁVEL (ou ATRIBUTO) e se torna uma PROPRIEDADE;
    -> Propriedades são escritas com Pascal Case (palavras unidas, primeira letra de cada palavra é maiúscula)
    
    Métodos seguintes são substituídos por { get; set; };
    Usados para variáveis private, podem buscar (get) para exibir ou manipular
    o valor (set). 
    Serve como boas práticas, assim mantendo regras de negócio dentro da própria classe.
    Na program.cs, permanece igual. Porém, podemos adicionar regras de negócio para get ou set.

    public void WriteAvailable(bool value)
    { 
        this.available = value; 
    }

    public bool ReadAvailable()
    {
        return this.available;
    }

    ----------------------------------------------------------------------------------------------------------------
    Lambda: (parametros) => expressao
    ----------------------------------------------------------------------------------------------------------------
    Exemplo: retornar números pares
    
    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);
    numerosPares.ForEach(numero => Console.WriteLine(numero));


    */

    public void DisplayDatasheet()
    {
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"Artista: {Artist.Name}");
        Console.WriteLine($"Duração: {Duration}");
        if (Available) 
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
        
    }
}

//escopo
//using System;
  //  class Program{
  
    //static void main (string[] args){

//variáveis
//int a,b,c;
//float a, b ,c;
//double a, b, c;


//conta
  //      switch{
    //       case"";
      //  }
        //if()
        //while(int b < 10){
          // Console.WriteLine("ainda n acabaou tá, continua codando");
      //}
        //for (int i = 0; i <=10; i%2==0;){
        //    Console.WriteLine("esses são seus números pares" + [i])
        //}



    //Console.WriteLine();//"cara aqui sai tudo que vc fizer na conta, dessa forma"


  //  }
//}



//using System;

//class prgram
//{
    //static void Main(string[] args)
    //{
        //double calculo2 =0;
       // double calculo = 0;
       // double altura =0;
        //double Base = 0;
      //  double pi = 3.1415;
    //    double raio = 0;

        //Console.WriteLine("Retângulo, Triângulo, Circunferência");
        //Console.WriteLine("Escolha uma forma geométrica:");
        //string formas = Console.ReadLine();

        //Console.WriteLine("Digite a altura:");
        //altura = Convert.ToDouble(Console.ReadLine());

       // Console.WriteLine("Digite a base:");
      //  Base = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Digite o raio (ou 0 para não calcular a circunferência):");
        //raio = Convert.ToDouble(Console.ReadLine());

        //switch (formas)
        //{
            //case "Retângulo":
                //calculo = Base * altura;
              //  break;
            //case "Triângulo":
               // calculo = Base * altura / 2;
              //  break;
            //case "Circunferência":
              //  calculo = raio * raio;
            //    calculo2 = calculo * pi;
          //      break;
        //        Console.WriteLine($"A área da circunferência é de {calculo2}.");
      //  }

    //    Console.WriteLine($"A área do {formas} é de {calculo}.");
      
  //  }
//}




//using System;
//class Program{
//  static void Main( string [] args){


     //int numeroPar=0;
     //int [] minha_lista=new int []{1,2,3,4,5,-1,6,7,8,9,10};

    //for (int i=0; i<= minha_lista.Length;i++){
      //if(minha_lista[i]%2==0){
        //numeroPar= minha_lista[i];
        //Console.WriteLine($"Elemento par encontrado: {numeroPar}");
      //}

        //else if (minha_lista[i]<0){
         // Console.WriteLine($"esse é o elemento que parou o for  {(minha_lista[i])} ");
        //  break;
         
      //  }
      
    //}
   
  //}
//}


//using System;

   // class Program
  //  {
        //static void Main(string[] args)
        //{
         //   int[] A = new int[5];
       //     int[] B = new int[8];

     //       Console.WriteLine("Digite os elementos do vetor A (5 elementos):");
    //        ReadElements(A);

  //          Console.WriteLine("Digite os elementos do vetor B (8 elementos):");
//            ReadElements(B);

//            Console.WriteLine("Elementos comuns nos vetores A e B:");

    //        foreach (int elementA in A)
  //          {
//                foreach (int elementB in B)
                //{
              //      if (elementA == elementB)
            //        {
          //              Console.WriteLine(elementA);
        //                break;
      //              }
    //            }
  //          }
//        }

   //     static void ReadElements(int[] array)
        //{
      //      for (int i = 0; i < array.Length; i++)
    //        {
  //              Console.Write($"Digite o elemento {i + 1}: ");
//                int element = int.Parse(Console.ReadLine());

        //        bool isDuplicate = false;
      //          for (int j = 0; j < i; j++)
    //            {
  //                  if (array[j] == element)
//                    {
                        //Console.WriteLine("Esse elemento já foi adicionado. Digite outro elemento.");
                      //  i--; // Decrementa para repetir a leitura do mesmo índice
                    //    isDuplicate = true;
                  //      break;
                //    }
              //  }

            //    if (!isDuplicate)
          //      {
        //            array[i] = element;
      //          }
    //        }
  //      }
//    }




//using System;

//class Program{


   // static void Main(string[] args)
  //  {
        // Cria um novo objeto `Random`
       // Random random = new Random();
      //  int[] valor= new int[5];
     //   int[] numeros= new int[5];
       
       
      //for (int i = 0; i < numeros.Length; i++){
      //numeros[i] = random.Next(1,11); 
      //}
      //Console.WriteLine("agora mostre os numeros de Numeros");
      //foreach (int i in numeros){
      //Console.WriteLine(i);
      //}
      //Console.WriteLine("__--__--__--__--__--__--__--__--__--__--__--__--__--__--__");
      //for (int i = 0; i < valor.Length; i++) {
     // valor[i] = random.Next(11, 21); 
     // }
      //Console.WriteLine("me mostre os numeros de Valores");
      //foreach(int i in valor){
     // Console.WriteLine(i);
    //  }
         
  //  }
        
 //   }



//parte back

//class Pessoa{
  //atributos
//private string nome;
  //private int idade;
  //private float altura;
  //private float peso;
  //private Pessoa pai;
 // private string apelido;
//método para operções
//public Pessoa(string nome, string apelido,  int idade, float altura, float peso){
//this.setNome(nome);
//this.apelido=apelido;
//this.idade = idade;
//this.altura= altura;
//this.peso= peso;

// o (this) chama o atributo para n ficar só no metodo local
//}
 //public string getNome(){
 //return nome;
 //}
//public  string getApelido(){
  //return apelido;
//}
//public void  setNome(string nome){
//this.nome= nome.ToUpper();
//}
//calcular IMC
//public float calcIMC(){
//return peso/(altura*altura);
//}
//public override string ToString(){
 // return $" Nome:{nome} | Idade:{idade}Anos | Altura: {altura}| Peso: {peso} Kg";
//}
  //public Pessoa MaisVelho(Pessoa p)
    //{
        //if (this.idade > p.idade)
        //{
        //    return this;
       // }
      //else if (p.idade > this.idade)
        //{
         //   return p;
        //}
        //else
       // {
      //      return null;
     //   }
    //}

    //public bool EOPaiDe(Pessoa filho)
    //{
    //    return this.apelido == filho.apelido;
  //  }
//}




//parte front

 //using System;
//class Program{
  //public static void Main(string[]args){
   // Pessoa fulano = new Pessoa ("jorjin_du_pneu","cardoso",  60, 1.90f, 80);
    //Pessoa ciclano = new Pessoa ("douglinhas", "cardoso",70, 1.50f, 100);
    //Console.WriteLine($"esse é o IMC: {fulano.calcIMC()} de  {fulano.getNome()}");
   // Console.WriteLine(fulano);
   //Console.WriteLine(fulano.MaisVelho(ciclano));
   // Console.WriteLine(fulano.getApelido());
   // Console.WriteLine(fulano.EOPaiDe(ciclano));
    

  //}

//}

using System;

class ClassePai
{
    private int atributoPai;

    public ClassePai(int a)
    {
        atributoPai = a;
        Console.WriteLine("Pai: {0}", a);
    }
}

class ClasseFilha : ClassePai
{
    private int atributoFilha;

    public ClasseFilha(int a) : base(a)
    {
        atributoFilha = a;
    }

    public void expondo()
    {
        if (atributoFilha is string)
        {
            Console.WriteLine("Classe Filha sendo exposta agora");
        }
            Console.WriteLine("CLASSE FILHA SE O IF FOSSE ERRADO"); 
    }
}

class Program
{
    static void Main(string[] args)
    {
        ClasseFilha nova = new ClasseFilha(10);
        nova.expondo();
        Console.WriteLine("Agora começaremos a MAIN");
    }
}


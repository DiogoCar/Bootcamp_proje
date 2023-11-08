using System;
					
public class Program
{
	public static void Main()
	{
	
		string dbug;




		Console.WriteLine("Bem vindo(a) a Calculadora basica!");
        Console.WriteLine("Precione '!start2' para iniciar");
		dbug= Console.ReadLine();
		//EXECUÇÃO COM 2 NUMEROS


        if (dbug != "!start2" || dbug != "!start3")
        {

        Console.WriteLine("ERRO!!!");
        Console.WriteLine("Comando não indentificado");

        }

		if(dbug == "!start2")
        {	
        double tolt, n1, n2; //, n3, n4;
		string opa; //,opb,opc;

       Console.WriteLine("Iniciando operação matematica de dois numeros!");



		Console.WriteLine("Digite seu numero: ");
		n1= double.Parse(Console.ReadLine());
		
		Console.WriteLine("Digite seu operador: ");
		opa= Console.ReadLine();
	
		Console.WriteLine("Digite seu numero: ");
		n2= double.Parse(Console.ReadLine());
		
		
		if(opa == "+")
		{
		tolt = n1 + n2;
		
		Console.WriteLine("Resultado: " + tolt );	
		}
		

		if(opa == "-")
		{
		tolt = n1 - n2;
		
		Console.WriteLine("Resultado: " + tolt );	
		}


		if(opa == "*")
		{
		tolt = n1 * n2;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == ":")
		{
		tolt = n1 / n2;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == "%")
		{
		tolt = n1 % n2;
		
		Console.WriteLine("Resultado: " + tolt );	
        }

        }



//EXECURÇÃO DE 3 NUMEROS
if(dbug == "!start3")
        {

        double tolt, n1, n2 , n3;
		string opa,opb;

       Console.WriteLine("Iniciando operação matematica de três numeros!");



		Console.WriteLine("Digite seu numero: ");
		n1= double.Parse(Console.ReadLine());
		
		Console.WriteLine("Digite seu operador: ");
		opa= Console.ReadLine();
	
		Console.WriteLine("Digite seu numero: ");
		n2= double.Parse(Console.ReadLine());
		
		Console.WriteLine("Digite seu operador: ");
		opb= Console.ReadLine();
	
		Console.WriteLine("Digite seu numero: ");
		n3= double.Parse(Console.ReadLine());


		if(opa == "+" && opb == "+") //+
		{
		tolt = n1 + n2 +n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

        if(opa == "+" && opb == "-")
		{
		tolt = n1 + n2 - n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

        if(opa == "+" && opb == "*")
		{
		tolt = n1 + n2 * n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}
		
        if(opa == "+" && opb == ":")
		{
		tolt = n1 + n2 / n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

        if(opa == "+" && opb == "%")
		{
		tolt = n1 + n2 % n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}


		if(opa == "-" && opb == "-") //-
		{
		tolt = n1 - n2 - n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == "-" && opb == "+") 
		{
		tolt = n1 - n2 + n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == "-" && opb == "*") 
		{
		tolt = n1 - n2 * n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == "-" && opb == ":") 
		{
		tolt = n1 - n2 / n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == "-" && opb == "%") 
		{
		tolt = n1 - n2 % n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == "*" && opb == "*")//*
		{
		tolt = n1 * n2 * n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == "*" && opb == "+")
		{
		tolt = n1 * n2 + n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == "*" && opb == "-")
		{
		tolt = n1 * n2 - n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == "*" && opb == ":")
		{
		tolt = n1 * n2 / n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == "*" && opb == "%")
		{
		tolt = n1 * n2 % n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == ":" && opb == ":")//:
		{
		tolt = n1 / n2 / n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == ":" && opb == "+")
		{
		tolt = n1 / n2 + n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == ":" && opb == "-")
		{
		tolt = n1 / n2 - n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == ":" && opb == "*")
		{
		tolt = n1 / n2 * n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == ":" && opb == "%")
		{
		tolt = n1 / n2 % n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == "%" && opb == "%")//%
		{
		tolt = n1 % n2 %n3;
		
		Console.WriteLine("Resultado: " + tolt );	
        }

		if(opa == "%" && opb == "+")
		{
		tolt = n1 % n2 + n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == "%" && opb == "-")
		{
		tolt = n1 % n2 - n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == "%" && opb == "*")
		{
		tolt = n1 % n2 * n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

		if(opa == "%" && opb == ":")
		{
		tolt = n1 % n2 / n3;
		
		Console.WriteLine("Resultado: " + tolt );	
		}

        }









	}
}
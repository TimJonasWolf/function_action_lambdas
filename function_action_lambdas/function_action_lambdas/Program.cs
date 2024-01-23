
//Func<string, string> grüssen = str => "Hallo " + str;

//Console.WriteLine(grüssen("Batman"));
//Console.WriteLine(grüssen("Spiderman"));


//------------------------------------------------------------------------------------------

//Func<double,double> sq = x => Math.Sqrt(x);
//double y = 9.9;

//Console.WriteLine(sq(y));

//------------------------------------------------------------------------------------------


//Func<double, double, string> DIV = (x, y) =>
//{
//	if (y == 0)
//		return "error";
//	else
//		return (x / y).ToString();
//};

//double a = 9.9, b = 3.3;
//Console.WriteLine($"\n {a} / {b} = {DIV (a,b)}");

//------------------------------------------------------------------------------------------


//double a = 9.9, b = 3.3;

//Func<double, double, double[]> Swap = (x, y) =>
//{
//	(x, y) = (y, x);
//	double[] array= {x,y};
//	return array;
//};

//Console.WriteLine($"\n {a} Swap {b} => a= {Swap(a, b)[0]} und b = {Swap(a, b)[1]}");

//------------------------------------------------------------------------------------------


//string vstr = "!! 22A ollaH";

//Func<string, string> fstr = vstr =>
//{
//	string str = "";
//	//vstr.Reverse();
//	for(int i = vstr.Length-1; i>=0; i--)
//		str += vstr[i];
//	return str;
//};

//Console.WriteLine($"\n {vstr} =  {fstr(vstr)}");

//------------------------------------------------------------------------------------------


//Func<int, int> fak = x =>
//{
//	int f = 1;
//	for (int i = 1; i<=x; i++)
//	{
//		f *= i;
//	}
//	return f;
//};

//Console.WriteLine($"\n {5} =  {fak(5)}");


//--------------------------------------Action----------------------------------------------------


//string str = "A22";

//Action<string> a1 = x =>
//{
//	Console.WriteLine($"\n Einen schönen Urlaub {x} !!!");
//};

//a1(str);

//------------------------------------------------------------------------------------------


//string str = "Hallo A22 !!! Wie geht es euch ? aaee a e EE";

//Action<string> a2 = x =>
//{
//	int acount = 0, ecount = 0, lcount = 0;
//	for(int i = 0; i < x.Length; i++)
//	{
//		if (x[i] =='a' || x[i] == 'A') 
//			acount++;

//		else if (x[i] == 'e' || x[i] == 'E')
//			ecount++;
//		else if (x[i] == ' ')
//			lcount++;
//	}

//	Console.WriteLine($" a/A ={acount},  e/E ={ecount}, Leerstellen ={lcount}");

//};
//a2(str);


//------------------------------------------------------------------------------------------

//string str = "Hallo A22 !!! Wie geht es euch ? aaee a e EE";

//Action<string> a4 = str2 =>
//{
//	Console.WriteLine($"{str2} \nMIT GROSSEN BUCHSTABEN :\n{str2.ToUpper()}");

//};
//a4(str);

//------------------------------------------------------------------------------------------


using function_action_lambdas;
using System.Collections.Generic;

List<A22Schüler> liste = new List<A22Schüler>()
{
		new A22Schüler("Hans", 1.3),
		new A22Schüler("Peter", 3.3),
		new A22Schüler("Klaus", 5.4),
		new A22Schüler("Batman", 2.3),
		new A22Schüler("Dejan", 5.3),
		new A22Schüler("Tim", 5.5)
};

Func< List < A22Schüler >, List < A22Schüler > > liste2 = f =>
{
	List<A22Schüler> nliste = f.FindAll(x => x.Note > 5);
	return nliste;
};

var list_neu = liste2(liste);

foreach(var s in list_neu.OrderBy(x=>x.Note))
{
	Console.WriteLine($"{s.Name}, {s.Note}");
}




Console.ReadKey();


using ConsoleApp3;
using System.Runtime.Serialization.Formatters;

Class1 pr = new Class1();



////  2) rhyta.com ve ya dayrep.com domenlerinde emaili olan borclulari cixartmag

//var list1 = pr.debtors.Where((debtor) => debtor.Email.Contains("rhyta.com") || debtor.Email.Contains("dayrep.com")).ToList();

//foreach (var debtor in list1)
//{
//    Console.WriteLine(debtor);
//    Console.WriteLine();
//}




//// 3) Yashi 26-dan 36-ya qeder olan borclulari cixartmag

//var list1=pr.debtors.Where(debtor => (2024-debtor.BirthDay.Year)>=26 && (2024 - debtor.BirthDay.Year)<=36).ToList();

//foreach(var debtor in list1)
//{
//    Console.WriteLine(debtor);
//    Console.WriteLine();
//}





////4) Borcu 5000-den cox olmayan borclularic cixartmag

//var list1 = pr.debtors.Where(debtor => debtor.Debt < 5000).ToList();

//foreach (var debtor in list1)
//{
//    Console.WriteLine(debtor);
//    Console.WriteLine();
//}





////	5) Butov adi 18 simvoldan cox olan ve telefon nomresinde 2 ve ya 2-den cox 7 reqemi olan borclulari cixartmaq


//var list1 = pr.debtors.Where(delegate (Class1.Debtor debtor)
//{
//	int count = 0;
//	for (int i = 0; i < debtor.Phone.Length; i++)
//		if (debtor.Phone[i] == '7')
//			count++;

//	return debtor.FullName.Length > 18 && count >= 2;

//}).ToList();


//foreach (var debtor in list1)
//{
//    Console.WriteLine(debtor);
//    Console.WriteLine();
//}




////7) Qishda anadan olan borclulari cixardmaq 

//var list1 = pr.debtors.Where(debtor => debtor.BirthDay.Month==12 || debtor.BirthDay.Month==1 || debtor.BirthDay.Month==2).ToList();

//foreach (var debtor in list1)
//{
//	Console.WriteLine(debtor);
//	Console.WriteLine();
//}




////8) Borcu, umumi borclarin orta borcunnan cox olan borclulari cixarmaq ve evvel familyaya gore sonra ise meblegin azalmagina gore sortirovka etmek

//double averageDebt = pr.debtors.Average(debtor => debtor.Debt);

//var list1 = pr.debtors.Where((debtor, averageDebt) => debtor.Debt > averageDebt).ToList().OrderBy(debtor => debtor.FullName).OrderByDescending(debtor => debtor.Debt);

//foreach (var debtor in list1)
//{
//	Console.WriteLine(debtor);
//	Console.WriteLine();
//}





////	9) Telefon nomresinde 8 olmayan borclularin yalniz familyasin,yashin ve umumi borcun meblegin cixarmaq

//var list1 = pr.debtors.Where(debtor => debtor.Phone.Contains("8") == false).ToList();

//foreach (var debtor in list1)
//    Console.WriteLine($"{debtor.FullName} {2024 - debtor.BirthDay.Year} {debtor.Debt} \n");





////11)Adinda ve familyasinda hec olmasa 3 eyni herf olan borclularin siyahisin cixarmaq ve onlari elifba sirasina gore sortirovka elemek

//var list1 = pr.debtors.Where(delegate (Class1.Debtor debtor)
//{
//	bool ischeck = false;
//	int it = 0;
//	while (it < debtor.FullName.Length)
//	{
//		int count = 0;
//		for (int i = 0; i < debtor.FullName.Length; i++)
//		{
//			if (debtor.FullName[i] == debtor.FullName[it])
//				count++;
//		}

//		if (count >= 3)
//		{
//			ischeck = true;
//			break;
//		}
//		else
//			it++;

//	}

//	return ischeck;
//}).ToList().OrderBy(debtor => debtor.FullName);

//foreach (var debtor in list1)
//{
//	Console.WriteLine(debtor);
//	Console.WriteLine();
//}





////13)borclulardan en coxu hansi ilde dogulubsa hemin ili cixartmaq

//int maxYear = pr.debtors[0].BirthDay.Year;
//int count = pr.debtors.Count(debtor => debtor.BirthDay.Year==maxYear);

//foreach(var debtor in pr.debtors)
//{
//	int counter = 0;
//	counter = pr.debtors.Count(db => db.BirthDay.Year==debtor.BirthDay.Year);
//	if (counter > count)
//	{
//		maxYear = debtor.BirthDay.Year;
//		count = counter;
//	}
//}

//Console.WriteLine("Year "+maxYear);






////14)Borcu en boyuk olan 5 borclunun siyahisini cixartmaq

//var copyList = pr.debtors.OrderByDescending(debtor => debtor.Debt).ToList();
//var list1 = new List<Class1.Debtor>();

//for (int i = 0; i < 5; i++)
//    list1.Add(copyList[i]);

//foreach (var debtor in list1)
//{
//    Console.WriteLine(debtor);
//    Console.WriteLine();
//}






////15)Butun borcu olanlarin borcunu cemleyib umumi borcu cixartmaq

//var totalDebt = pr.debtors.Sum(debtor => debtor.Debt);
//Console.WriteLine("Total debt: "+totalDebt);





////16)2ci dunya muharibesin gormush borclularin siyahisi cixartmaq

//var list1=pr.debtors.Where(debtor => debtor.BirthDay.Year<=1945).ToList();

//foreach (var debtor in list1)
//{
//	Console.WriteLine(debtor);
//	Console.WriteLine();
//}




////18)Nomresinde tekrar reqemler olmayan borclularin ve onlarin borcunun meblegin cixartmaq


//var list1 = pr.debtors.Where(debtor => debtor.Phone.Distinct().Count() == debtor.Phone.Length).ToList();

//foreach (var debtor in list1)
//{
//    Console.WriteLine(debtor);
//    Console.WriteLine();
//}






////19)Tesevvur edek ki,butun borclari olanlar bugunden etibaren her ay 500 azn pul odeyecekler. Oz ad gunune kimi borcun oduyub qurtara bilenlerin siyahisin cixartmaq

//var list1 = pr.debtors.Where(delegate (Class1.Debtor debtor)
//{
//    bool ischeck = false;
//    int count = 0;

//    if (debtor.BirthDay.Month > DateTime.Now.Month)
//        count = debtor.BirthDay.Month - DateTime.Now.Month;

//    else
//        count = 12 - DateTime.Now.Month + debtor.BirthDay.Month;

//    double amount = count * 500;
//    if (amount >= debtor.Debt)
//        ischeck = true;

//    return ischeck;

//}).ToList();


//foreach (var debtor in list1)
//{
//	Console.WriteLine(debtor);
//	Console.WriteLine();
//}





// 20)Adindaki ve familyasindaki herflerden "smile" sozunu yaza bileceyimiz borclularin siyahisini cixartmaq

var list1 = pr.debtors.Where(debtor => debtor.FullName.Contains("s") && debtor.FullName.Contains("m") && debtor.FullName.Contains("i") && debtor.FullName.Contains("l") && debtor.FullName.Contains("e")).ToList();

foreach (var debtor in list1)
{
    Console.WriteLine(debtor);
    Console.WriteLine();
}
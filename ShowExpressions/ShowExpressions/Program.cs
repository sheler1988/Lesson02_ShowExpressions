

//  برنامه ای بنویسید که یک متغیر داشته باشد اکر بالاتر از 10 بود یه عبارتی جاپ کنه و اکر پایین تر بود یه عبارت دیکه جاپ کنه

//  اکر میخواهید عدد را از کاربر دریافت نکنید و ثابت باشد عبارت بعد مساوی را حذف بکنید و یک عدد به دلخواه قرار بدهید

Console.Write("Please Enter Namber: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number >= 10)
	Console.WriteLine("Hello Word!");
else
	Console.WriteLine("GoodBye Word!");

Console.ReadKey();
using System;
using System.Collections.Generic;
using System.Linq;

namespace HW26082024
{
    class Program
    {
		private static void Main()
        {
            //1 ЗАДАЧА
			var symbol = '#';
			var valueTest1 = 7;
			LineXSquare(valueTest1, symbol);
			LineYSquare(valueTest1, symbol);
			LineXSquare(valueTest1, symbol);
			//2 ЗАДАЧА
			int valueTest2 = 7667;

			Console.WriteLine(IsPalindromeSecond(valueTest2) ? "Это палиндром" : "Это не палиндром");
			Console.WriteLine(IsPalindromeFirst(valueTest2) ? "Это палиндром" : "Это не палиндром");
			// 3 задача
			var listTestIntsFirst = new List<int>() { 1, 2, 6, -1, 88, 7, 6 };
			var listTestIntsSecond = new List<int> { 6, 88, 7 };

			Console.WriteLine(string.Join(", ", listTestIntsFirst.Except(listTestIntsSecond)));
			//4. 5. 6 задачи в классах ниже
			
            Console.ReadKey();
		}
		private static void LineXSquare(int value, char symbol)
		{
			for (var i = 0; i < value; i++)
				Console.Write(symbol);
            Console.WriteLine();
		}
		private static void LineYSquare(int value, char symbol)
		{
			for (var i = 0; i < value - 2; i++)
			{
				Console.Write(symbol);
				for (var j = 0; j < value - 2; j++)
					Console.Write(" ");
				Console.WriteLine(symbol);
			}
		}
		private static bool IsPalindromeFirst(int value)
		{
			var strValue = value.ToString();
			return strValue.SequenceEqual(strValue.Reverse());
		}
		private static bool IsPalindromeSecond(int value)
		{
			var strValue = value.ToString();
			var middle = strValue.Length / 2;
			var substringLeft = strValue.Substring(0, middle);
			var substringRight = new string( strValue
				.Substring(middle + (strValue.Length % 2 == 0 ? 0 : 1))
				.Reverse()
				.ToArray());
			return substringLeft == substringRight;
		}
	}

	public class WebSite
	{
		private string _name;
		private string _url;
		private string _description;
		private string _ipAddress;
		public WebSite(string name, string ipAddress, string url, string description)
		{
			this._name = name;
			this._url = url;
			this._ipAddress = ipAddress;
			this._description = description;
		}
		public string GetName() { return this._name; }
		public string GetIpAddress() { return this._ipAddress; }
		public string GetUrl() { return this._url; }
		public string GetDescription() { return this._description; }

		public void SetName(string name) { this._name = name; }
		public void SetIpAddress(string ipAdress) { this._ipAddress = ipAdress; }
		public void SetUrl(string url) { this._url = url; }
		public void SetDescription(string description) { this._description = description; }
		public void PrintWebSityInfo()
		{
			Console.WriteLine($"Название: {_name}");
			Console.WriteLine($"URL: {_url}");
			Console.WriteLine($"Описание: {_description}");
			Console.WriteLine($"IP-адрес: {_ipAddress}");
		}
	}

	public class Journal
	{
		private string _name;
		private string _year;
		private string _contactPhone;
		private string _emailAddress;
		public Journal(string _name, string _year, string _contactPhone, string _emailAddress)
		{
			this._name = _name;
			this._year = _year;
			this._contactPhone = _contactPhone;
			this._emailAddress = _emailAddress;
		}
		public string GetName() { return this._name; }
		public string GetYear() { return this._year; }
		public string GetContactPhone() { return this._contactPhone; }
		public string GetEmailAdress() { return this._emailAddress; }

		public void SetName(string _name) { this._name = _name; }
		public void SetYear(string _year) { this._year = _year; }
		public void SetContactPhone(string _contactPhone) { this._contactPhone = _contactPhone; }
		public void SetEmailAdress(string _emailAddress) { this._emailAddress = _emailAddress; }
		public void PrintWebSityInfo()
		{
			Console.WriteLine($"Название: {_name}");
			Console.WriteLine($"Год создания: {_year}");
			Console.WriteLine($"Контактный номер телефона: {_contactPhone}");
			Console.WriteLine($"Контактный Емаил: {_emailAddress}");
		}
	}
	public class Store
	{
		private string _name;
		private string _year;
		private string _contactPhone;
		private string _emailAddress;
		public Store(string _name, string _year, string _contactPhone, string _emailAddress)
		{
			this._name = _name;
			this._year = _year;
			this._contactPhone = _contactPhone;
			this._emailAddress = _emailAddress;
		}
		public string GetName() { return this._name; }
		public string GetYear() { return this._year; }
		public string GetContactPhone() { return this._contactPhone; }
		public string GetEmailAdress() { return this._emailAddress; }

		public void SetName(string _name) { this._name = _name; }
		public void SetYear(string _year) { this._year = _year; }
		public void SetContactPhone(string _contactPhone) { this._contactPhone = _contactPhone; }
		public void SetEmailAdress(string _emailAddress) { this._emailAddress = _emailAddress; }
		public void PrintWebSityInfo()
		{
			Console.WriteLine($"Название: {_name}");
			Console.WriteLine($"Год создания: {_year}");
			Console.WriteLine($"Контактный номер телефона: {_contactPhone}");
			Console.WriteLine($"Контактный Емаил: {_emailAddress}");
		}
	}
}

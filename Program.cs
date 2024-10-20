using System;
using System.Collections.Generic;

//1-vazifa klasi start
public enum Baho
{
    Alo = 5,
    Yaxshi = 4,
    Qoniqarli = 3,
    Qoniqarsiz = 2
}
public class Oquvchi
{
    public Guid Id { get; set;}
    public string Ism { get; set;}
    private string Familya { get; set;}
    private int Sinf { get; set;}
    public Baho Bahosi { get; set;} 

    public Oquvchi(string ism, string familya, int sinf, Baho baho)
    {
        Id = Guid.NewGuid();
        Ism = ism;
        Familya = familya;
        Sinf = sinf;
        Bahosi = baho;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}\nIsm: {Ism}\nFamilya: {Familya}\nSinf: {Sinf}\nBaho: {Bahosi}\n");
    }
}
//1-vazifa klasi end

//2-vazifa klasi start
public class Avtomobil
{
    public string Nomi { get; set; }
    public string Marka { get; set; }
    public int Narx { get; set; }

    public Avtomobil(string nomi, string marka, int narx)
    {
        Nomi = nomi;
        Marka = marka;
        Narx = narx;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"\nNomi: {Nomi}\nMarkasi: {Marka}\nNarxi: {Narx} $");
    }
}
//2-vazifa klasi end

//3-vazifa klasi start
public class Bokschi
{
    public Guid ID { get; set; }
    public string Name { get; set;}
    public string Surname { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }

    public Bokschi(string name, string surname, int age, double weight)
    {
        ID = Guid.NewGuid();
        Name = name;
        Surname = surname;
        Age = age;
        Weight = weight;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {ID}\nFamiliya: {Name}\nIsm: {Surname}\nYoshi: {Age}\nVazni: {Weight} kg\n");
    }
}
//3-vazifa klasi end

class Program
{
    static void Main(string[] args)
    {
        List<Oquvchi> oquvchilar = new List<Oquvchi>(); //1-vazifa Listi
        List<Avtomobil> avtomobillar = new List<Avtomobil>(); //2-vazifa Listi
        List<Bokschi> bokschilar = new List<Bokschi>(); //3-vazifa Listi

        //1-vazifa kodi start
        Console.WriteLine("--------Vazifa 1--------");

        while (true)
        {
            Console.Write("O'quvchi ismini kiriting (chiqish uchun 'exit' deb yozing): ");
            string ism = Console.ReadLine();
            if (ism.ToLower() == "exit") break;

            Console.Write("O'quvchi familyasini kiriting: ");
            string familya = Console.ReadLine();

            Console.Write("O'quvchi sinfini kiriting: ");
            int sinf = int.Parse(Console.ReadLine());

            Console.Write("O'quvchi bahosini kiriting (2-5): ");
            int bahoInt = int.Parse(Console.ReadLine());

            Baho baho = (Baho)bahoInt;

            oquvchilar.Add(new Oquvchi(ism, familya, sinf, baho));

            Console.WriteLine();
        }

        Console.WriteLine("Qaysi baho olgan o'quvchilarni ko'rmoqchisiz? (2-5 oralig'ida kiriting): ");
        int userInput = int.Parse(Console.ReadLine());

        Baho kiritilganBaho = (Baho)userInput;

        Console.WriteLine($"\nBahosi {kiritilganBaho} bo'lgan o'quvchilar:");
        foreach (var oquvchi in oquvchilar)
        {
            if (oquvchi.Bahosi == kiritilganBaho)
            {
                oquvchi.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Bunday o'quvchi yo'q");
            }
        }
        //1-vazifa kodi end


        //2-vazifa kodi start
        Console.WriteLine("\n--------Vazifa 2--------");

        while (true)
        {
            Console.Write("Avtomobil nomini kiriting (chiqish uchun 'exit' deb yozing): ");
            string nomi = Console.ReadLine();
            if (nomi.ToLower() == "exit") break;

            Console.Write("Avtomobil markasini kiriting: ");
            string marka = Console.ReadLine();

            Console.Write("Avtomobil narxini kiriting ($): ");
            int narx = int.Parse(Console.ReadLine());

            avtomobillar.Add(new Avtomobil(nomi, marka, narx));

        }

        Console.WriteLine("\nAvtomobillar narxlari oralig'i bo'yicha qidirish:");

        Console.Write("1-narx: ");
        int narx1 = int.Parse(Console.ReadLine());

        Console.Write("2-narx: ");
        int narx2 = int.Parse(Console.ReadLine());

        Console.WriteLine("\nKiritilgan narxlar oralig'ida joylashgan avtomobillar:");
        foreach (var avtomobil in avtomobillar)
        {
            if ((avtomobil.Narx > narx1 && avtomobil.Narx < narx2) || (avtomobil.Narx < narx1 && avtomobil.Narx > narx2))
            {
                avtomobil.DisplayInfo();
            }
        }
        //2-vazifa kodi end

        //3-vazifa kodi start
        Console.WriteLine("\n--------Vazifa 3--------");

         while (true)
        {
            Console.Write("Bokschining ismini kiriting (chiqish uchun 'exit' deb yozing): ");
            string name = Console.ReadLine();
            if (name.ToLower() == "exit") break;

            Console.Write("Bokschining familyasini kiriting: ");
            string surname = Console.ReadLine();

            Console.Write("Bokschining yoshini kiriting: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Bokschining vaznini kiriting (kg): ");
            double weight = double.Parse(Console.ReadLine());

            bokschilar.Add(new Bokschi(name, surname, age, weight));
            Console.WriteLine("");
        }

        Console.WriteLine("\nBokschilarni vazn kategoriya bo'yicha ko'rsatish:");
        Console.WriteLine("\nYengil (50 kg gacha):");
        foreach (var bokschi in bokschilar)
        {
            if (bokschi.Weight <= 50)
            {
                bokschi.DisplayInfo();
            }
        }

        Console.WriteLine("\nO'rta (50 dan 76 kg gacha):");
        foreach (var bokschi in bokschilar)
        {
            if (bokschi.Weight > 50 && bokschi.Weight <= 76)
            {
                bokschi.DisplayInfo();
            }
        }

        Console.WriteLine("\nOg'ir (76 kg va undan og'irlar):");
        foreach (var bokschi in bokschilar)
        {
            if (bokschi.Weight > 76)
            {
                bokschi.DisplayInfo();
            }
        }
        //3-vazifa kodi end
    }
}
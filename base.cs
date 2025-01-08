using System;

namespace firstApp
{
    public struct Disk
    {
        public string Brand;
        public int Capacite;

        // Constructeur 
        public Disk(string brand, int capacite)
        {
            Brand = brand; // Correction de la casse des noms
            Capacite = capacite; // Correction de la casse des noms
        }

        // Méthode
        public override string ToString() => $"Disque de marque {Brand} et d'une capacité {Capacite} Go";
    }

    public class Stock
    {
        public Disk[] Disks; // Tableau pour stocker les disques
        public int Count; // Nombre de disques dans le stock

        // Constructeur
        public Stock(int capacity)
        {
            Disks = new Disk[capacity];
            Count = 0;
        }

        // Méthode pour ajouter un disque au stock
        public void AddDisk(Disk disk)
        {
            if (Count < Disks.Length)
            {
                Disks[Count] = disk;
                Count++;
            }
            else
            {
                Console.WriteLine("Le stock est plein !");
            }
        }

        // Méthode pour afficher les disques en stock
        public void DisplayDisks()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(Disks[i]);
            }
        }
    }

    class Base
    {
        static void Main(string[] args)
        {
            Stock stock_disque = new Stock(100);
            Stock stock_mousse = new Stock(25);

            // Ajout de disques d'exemple
            Disk d1 = new Disk("Seagate", 500);
            Disk d2 = new Disk("Western Digital", 1000);

            stock_disque.AddDisk(d1);
            stock_disque.AddDisk(d2);

            // Affichage des disques
            Console.WriteLine("Disques dans le stock de disques :");
            stock_disque.DisplayDisks();
        }
    }
}
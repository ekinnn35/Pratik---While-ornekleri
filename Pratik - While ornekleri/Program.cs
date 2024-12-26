Console.WriteLine("Konsol ekranına 10 kere .... yazdırınız.");

int sayac = 0; 

while (sayac < 10)
{ 
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    sayac++;
}

Console.WriteLine("----1.Döngü bitti!----");

Console.WriteLine("1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.");

int sayi = 1;
while (sayi < 20)
{
    Console.WriteLine(sayi);
    sayi++;
}

Console.WriteLine("-----2. Döngü bitti.-----");

Console.WriteLine("1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.");

int sayi1 = 1; 



while (sayi1 <= 20) 
{
    if (sayi1 % 2 == 0) 
    {
        Console.WriteLine(sayi1); 
    }

    sayi1++; 
}
    

Console.WriteLine("-----3. Döngü bitti.-----");

Console.WriteLine("50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.");

int toplam = 0;
int sayi2 = 50;
while (sayi2 <= 150)
{
    toplam += sayi2;
    sayi2++;
}
Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {toplam}");

Console.WriteLine("-----4. Döngü bitti.------");

Console.WriteLine("1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.");

int tekToplam = 0;
int ciftToplam = 0;
int sayi3 = 1;
while (sayi3 <= 120)
{
    if (sayi3 % 2 == 0)
    {
        ciftToplam += sayi3;
    }
    else
    {
        tekToplam += sayi3;
    }
    sayi3++;
}
Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {ciftToplam}");
Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {tekToplam}");

Console.WriteLine("-----5. Döngü bitti.-----");

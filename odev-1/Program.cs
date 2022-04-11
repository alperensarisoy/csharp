Console.WriteLine("*****ÖDEV KISIM 1*****");
Console.WriteLine("pozitif bir sayı girin:");
int sayi= int.Parse(Console.ReadLine());
int[] dizi= new int[sayi];
if(sayi<=0)
            {
                Console.WriteLine("pozitif sayı girilmedi");
            }
            else
            {
                Console.WriteLine("girdiğiniz sayı: {0}", sayi);
            }

for(int i=0;i<sayi;i++){
    Console.WriteLine("bir sayı girin");
    dizi[i]=int.Parse(Console.ReadLine());

}
Console.WriteLine("****Girdiğiniz çift sayılar****");
foreach(int i in dizi){
    if(i%2==0){
        Console.WriteLine(i);
        
        }}

Console.WriteLine("*****ÖDEV KISIM 2*****");

Console.WriteLine("Pozitif iki adet sayı girin:");
int n=int.Parse(Console.ReadLine());
int m=int.Parse(Console.ReadLine());
int[] dizi1= new int[n] ;

for(int i=0;n>i;i++){
    Console.WriteLine("Bir sayi girin:");
    dizi1[i]=int.Parse(Console.ReadLine());

}
Console.WriteLine("Girdiğiniz sayıya tam bölünen veya eşit olan sayılar");
foreach(int i in dizi1){
    if(i%m==0){
        Console.WriteLine(i);
    }
}

Console.WriteLine("*****ÖDEV KISIM 3*****");
Console.WriteLine("Pozitif bir sayı girin");
int sayi2=int.Parse(Console.ReadLine());
Methods instance =new();
instance.kelime(sayi2);

Console.WriteLine("*****ÖDEV KISIM 4*****");
Console.WriteLine("Bir Cümle Girin");
string cumle=Console.ReadLine();

int kelime=instance.kelimeSayi(cumle);
Console.WriteLine(kelime+" kelimeden oluşmuştur.");
string.Join("",cumle);
int uzunluk=cumle.Length;
uzunluk-=kelime-1;
Console.WriteLine("Cümlenin uzunluğu:"+uzunluk);




public class Methods{

    public int kelimeSayi(string n){

        string[] dizi= n.Split(" ");

        int kelime=dizi.Length;

        return kelime;


    }



    public void kelime(int n){
        string[] dizi= new string[n];

        for(int i=0; n>i; i++){

            Console.WriteLine("Bir kelime girin");
            dizi[i]=Console.ReadLine();

        }

        for(int i=n-1; i>=0; i--){

            Console.WriteLine(dizi[i]);
        }




    }

}
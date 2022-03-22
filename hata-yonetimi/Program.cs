// See https://aka.ms/new-console-template for more information


try{
    
   Console.WriteLine("Bir sayı giriniz:");
   int sayi =Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Girilen Sayı"+ sayi);

}
catch(Exception ex){

    Console.WriteLine("Hata:"+ ex.Message.ToString());

}
finally{

Console.WriteLine("İşlem Tamamlandı");
}
try{
    // int a = int.Parse(null);
    int a = int.Parse("Test");
}
catch(ArgumentException ex){

    Console.WriteLine("Boş değer girdiniz");
    Console.WriteLine(ex);
    
}
catch(FormatException ex){
    Console.WriteLine("Veri Tipi uygun değil");
    Console.WriteLine(ex);

}
finally{
    Console.WriteLine("işlem tamamlandı");
}


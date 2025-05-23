using BebekKişi;

Bebek yeniDogan1 = new Bebek();

Console.WriteLine("Yeni Doğan bebek bilgileri");
Console.WriteLine("İsim : " + yeniDogan1.Ad);
Console.WriteLine("Soyadı : " + yeniDogan1.Soyad);
Console.WriteLine("Doğum tarihi : " + yeniDogan1.DoğumTarihi);


Bebek yeniDogan2 = new Bebek("Ali","Veli", DateTime.Now);
Console.WriteLine("Yeni Doğan bebek bilgileri");
Console.WriteLine("İsim : " + yeniDogan2.Ad);
Console.WriteLine("Soyadı : " + yeniDogan2.Soyad);
Console.WriteLine("Doğum tarihi : " + yeniDogan2.DoğumTarihi);




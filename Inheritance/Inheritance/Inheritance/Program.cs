using Inheritance.Classes;

BMW bmw = new BMW();

bmw.marka = "BMW";
bmw.vites = "Düz vites";

bmw.Yazdir(bmw.marka, bmw.vites);

Porsche pr = new Porsche();
pr.marka = "Porsche";
pr.vites = "Otomatik vites";

pr.Yazdir(pr.marka, pr.vites);

Mercedes mr = new Mercedes();
mr.marka = "Mercedes";
mr.vites = "Otomatik vites";
mr.Yazdir(mr.marka, mr.vites);

Audi au = new Audi();
au.marka = "Audi";
au.vites = "Otomatik vites";
au.Yazdir(au.marka, au.vites);

Toyota ty = new Toyota();

ty.marka = "Toyota";
ty.vites = "Düz vites";
ty.Yazdir(ty.marka, ty.vites);

Togg togg = new Togg();
togg.marka = "Togg";
togg.vites = "Otomatik vites";
togg.Yazdir(togg.marka, togg.vites);


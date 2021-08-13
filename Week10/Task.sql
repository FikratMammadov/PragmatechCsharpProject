
-- Adi Nancy olan personelin etdiyi satislari listleyin.
select * from Satislar s
where s.PersonelID = (select PersonelID from Personeller p where p.Adi='Nancy')

-- Adi Nancy ve Janet olan personellerin etdiyi satislari listleyin.
select * from Satislar s
where s.PersonelID = (select PersonelID from Personeller p where p.Adi='Nancy') or
s.PersonelID = (select PersonelID from Personeller p where p.Adi='Janet')

-- PersonelAdi Nancy ve ya Janet ve neqliyyatcisi Speedy Express olan satislari listleyin.
select * from Satislar s
where (s.PersonelID = (select PersonelID from Personeller p where p.Adi='Nancy') or
s.PersonelID = (select PersonelID from Personeller p where p.Adi='Janet')) and
s.ShipVia = (select NakliyeciID from Nakliyeciler n where n.SirketAdi = 'Speedy Express')

-- Urunleri urune tetbiq olunan maksimum endirim faizi ile birlikde listleyen sorgunu yazin.
--(Urunler ve SatisDetay tables).
select *,(select max(İndirim) from [Satis Detaylari] sd where sd.UrunID = u.UrunID) [Max Indirim]
from Urunler u

-- Edilen satishlari maksimum satis qiymeti ile birlikde listleyin.(Satislar ve SatisDetay tables).
select *,
(select max(BirimFiyati) from [Satis Detaylari] sd where sd.SatisID = s.SatisID) [Max Satis Fiyati]
from Satislar s

-- Urunlerle birlikde urunun toplam satis miqdari melumatini gosteren sorgunu yazin.(Urunler ve SatisDetay tables).
select *,(select sum(Miktar) from [Satis Detaylari] sd where sd.UrunID = u.UrunID) [Toplam Satis Miktari]
from Urunler u

-- Speedy Express adli neqliyyatci bugune qeder nece eded mal dashimishdir?(SatisDetay,Satislar ve Nakliyeciler tables)
select sum(Miktar) [Speedy Express'in dasidigi toplam mal sayi] from [Satis Detaylari] sd
where sd.SatisID  in (select SatisID from Satislar s where s.ShipVia = 
(select NakliyeciID from Nakliyeciler n where n.SirketAdi = 'Speedy Express'))


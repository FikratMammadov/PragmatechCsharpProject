-- 1. Hansi personel hansi maldan hec satish etmemishdir?

select p.PersonelID,u.UrunID from Urunler u
cross join Personeller p

except

select p.PersonelID,u.UrunID from Urunler u
left join [Satis Detaylari] sd
on u.UrunID=sd.UrunID
left join Satislar s
on s.SatisID = sd.SatisID
left join Personeller p
on s.PersonelID=p.PersonelID
order by p.PersonelID,u.UrunID

-- 2. Hansi tedarukcuden hansi mal hec tedaruk edilmemishdir?

select t.TedarikciID, u.UrunID from Urunler u
cross join Tedarikciler t

except

select t.TedarikciID, u.UrunID from Urunler u
left join [Satis Detaylari] sd
on sd.UrunID=u.UrunID
left join Satislar s
on s.SatisID=sd.SatisID
left join Tedarikciler t
on t.TedarikciID = u.TedarikciID
order by t.TedarikciID,u.UrunID

-- 3. Hansi mal hansi mushteriye hec satilmamishdir?
select m.MusteriID,u.UrunID from Musteriler m
cross join Urunler u

except

select m.MusteriID,u.UrunID from Musteriler m
left join Satislar s
on s.MusteriID = m.MusteriID
left join [Satis Detaylari] sd
on sd.SatisID = s.SatisID
left join Urunler u
on u.UrunID = sd.UrunID
order by m.MusteriID,u.UrunID

-- 4. Urunlerin edv hesablandiqdan sonraki qiymetini gosteren funksiyani yazin.(@qiymet parametri qebul edecek.)
--Create function dbo.EdvHesabla(@qiymet money)
--returns money
--As
--begin
--    declare @edv money
--    set @edv =@qiymet+( @qiymet * 0.18)
--    return @edv
--end

select u.UrunAdi, dbo.EdvHesabla(u.BirimFiyati) from Urunler u

-- 5. Satish qiymeti 100 dollardan artiq olan hansi mallari hansi personel satmishdir?
select p.PersonelID,u.UrunID,sd.BirimFiyati from Personeller p
left join Satislar s
on p.PersonelID = s.PersonelID
left join [Satis Detaylari] sd
on sd.SatisID = s.SatisID
left join Urunler u
on u.UrunID = sd.UrunID
where sd.BirimFiyati>100
order by p.PersonelID,u.UrunID

-- 6. Urunleri tedarukcu firma adlari ile birlikde listleyin.
select u.UrunID,t.SirketAdi from Urunler u
left join [Satis Detaylari] sd
on u.UrunID = sd.UrunID
left join Satislar s
on s.SatisID = sd.SatisID
left join Tedarikciler t
on t.TedarikciID = u.TedarikciID
order by u.UrunID

-- 7. Edilen satishlari mushteri adi,soyadi ve personel adi,soyadi ile birlikde listleyin.

select s.SatisID,m.MusteriAdi,p.Adi,p.SoyAdi from Satislar s
left join Musteriler m
on m.MusteriID = s.MusteriID
left join [Satis Detaylari] sd
on sd.SatisID = s.SatisID
left join Personeller p
on p.PersonelID = s.PersonelID

-- 8. Hansi personel hansi urunden toplamda nece dollarliq satish etmishdir?

select p.PersonelID, u.UrunID, sum(sd.BirimFiyati) from Personeller p
left join Satislar s
on s.PersonelID = p.PersonelID
left join [Satis Detaylari] sd
on sd.SatisID=s.SatisID
left join Urunler u
on u.UrunID = sd.UrunID
group by p.PersonelID,u.UrunID
order by p.PersonelID,u.UrunID

-- 9. Hansi personel hansi kategoryden toplamda nece eded mal satishi etmishdir?
select p.PersonelID, k.KategoriID, COUNT(k.KategoriID) from Personeller p
left join Satislar s
on s.PersonelID = p.PersonelID
left join [Satis Detaylari] sd
on sd.SatisID=s.SatisID
left join Urunler u
on u.UrunID = sd.UrunID
left join Kategoriler k
on u.KategoriID = k.KategoriID
group by p.PersonelID,k.KategoriID
order by p.PersonelID,k.KategoriID

-- 10. Neqliyyat shirketi olan 'Speedy Express' satish qiymeti 15 dollardan yuksek olan nece eded mal dashimishdir?
select n.SirketAdi,count(u.UrunID) [15 dollardan baha satilmis mal sayi] from Nakliyeciler n
left join Satislar s
on s.ShipVia = n.NakliyeciID
left join [Satis Detaylari] sd
on sd.SatisID=s.SatisID
left join Urunler u
on u.UrunID = sd.UrunID
where n.SirketAdi = 'Speedy Express' and sd.BirimFiyati>15
group by n.SirketAdi

-- 11. Urunler table-na urun elave eden sorgunu yazin.

insert into Urunler 
values ('Laptop',4,4,'8 ram',1500,6,0,0,0)

-- 12. Personeller table-na ozunuzu personel olaraq elave edin.
 insert into Personeller
values('Mammadov','Fikrat','Yaver Aliyev','Ms.',2002-08-01,2021-11-01,'Qara Qarayev',
'Baku','WA','11111','Azerbaijan','(012) 953-28-50','2112',
 null,
 'Education includes a BA in psychology from Colorado State University in 1970.  She also completed "The Art of the Cold Call."  Nancy is a member of Toastmasters International.',
 null,'http://accweb/emmployees/davolio.bmp')

-- 13. Bolge table-na bolge elave eden sorgunu yazin.
insert into Bolge
values (5,'Qafqaz')

-- 14. Kateqoriler table-na deyerler elave edin.
insert into Kategoriler
values ('Elektronika','Elektronika tanitim',null)

-- 15. Urunler table-da birimFiyati columnunun deyerini yenileyib 15 eden sorgunu yazin.
update Urunler
set BirimFiyati = 15
where UrunAdi = 'Laptop'

-- 16. ID-si 10 olan urunun qiymetini 32 eden sorgunu yazin.
update Urunler 
set BirimFiyati = 32
where UrunID = 10

-- 17. KateqoriId-si 5 olan urunlerin stok-nu 5 vahid artiran sorgunu yazin.
update Urunler
set HedefStokDuzeyi = HedefStokDuzeyi+5
where KategoriID=5

-- 18. Urunler table-na yeni bir urun elave edib,sonra o urunun qiymetini ve stokunu yenileyib,
--daha sonra o urunu silen sorgulari yazin.Bu sorgularin hamisi bir biriyle elaqeli olsun,
--update ve delete emeliyyatini insert zamani yaranan ID-ni dynamic goturmekle istifade edin.
insert into Urunler
values('Samsung S20',4,5,'8 ram',2500,6,0,0,0)

begin transaction
update Urunler
set BirimFiyati = 2400,HedefStokDuzeyi=10
where UrunAdi = 'Samsung S20'
rollback

begin transaction Task18Deleting
delete from Urunler
where UrunAdi = 'Samsung S20'
rollback 

-- 19. Hem mushterilerimizi hem de tedarukculerimizi listleyen sorgunu yazin.
select m.*,t.* from Musteriler m
full join Satislar s
on s.MusteriID = m.MusteriID
full join [Satis Detaylari] sd
on sd.SatisID = s.SatisID
full join Urunler u
on u.UrunID = sd.UrunID
full join Tedarikciler t
on t.TedarikciID = u.TedarikciID
order by m.MusteriID,t.TedarikciID

-- 20. Hansi tedarukcuden toplamda nece dollarliq mal tedaruk edilmishdir?(Butun tedarukculer gelmelidir)
select t.TedarikciID,u.UrunID,sum(sd.BirimFiyati)[Toplam satis fiyati] from Tedarikciler t
full join Urunler u
on t.TedarikciID = u.TedarikciID
full join [Satis Detaylari] sd
on sd.UrunID = u.UrunID
group by t.TedarikciID,u.UrunID
order by t.TedarikciID,u.UrunID

-- 21. Hec satish edilmeyen mushterilerimizi listleyen sorgunu yazin.
select m.MusteriID,u.UrunID from Musteriler m
cross join Urunler u
except
select m.MusteriID,u.UrunID from Musteriler m
left join Satislar s
on s.MusteriID = m.MusteriID
left join [Satis Detaylari] sd
on sd.SatisID = s.SatisID
left join Urunler u
on u.UrunID = sd.UrunID
order by m.MusteriID,u.UrunID

-- 22. Hec neqliyyat etmeyen neqliyyatcilari listleyen sorgunu yazin.
select n.NakliyeciID,u.UrunID from Nakliyeciler n
cross join Urunler u
except
select n.NakliyeciID,u.UrunID from Nakliyeciler n
left join Satislar s
on s.ShipVia = n.NakliyeciID
left join [Satis Detaylari] sd
on sd.SatisID = s.SatisID
left join Urunler u
on u.UrunID = sd.UrunID
order by n.NakliyeciID,u.UrunID

-- 23. Urun adini,qiymetini ve stokunu parameter olaraq qebul edib Urunler table-na elave eden proceduru yazin.
create procedure InsertToUrunTable(@urunAdi nvarchar(40), @birimFiyati money, @hedefStokDuzeyi smallint)
as
Begin
    insert into Urunler
    (UrunAdi,BirimFiyati,HedefStokDuzeyi)
    values (@urunAdi,@birimFiyati,@hedefStokDuzeyi)
end

execute InsertToUrunTable 'Qulaqciq',65,10

-- 24. UrunAdi parameteri alaraq o urunu silen proceduru yazin.
create procedure DeleteFromUrunler(@urunAdi nvarchar(40))
as
    begin
        delete from Urunler
        where UrunAdi = @urunAdi
    end

execute DeleteFromUrunler 'Qulaqciq'

-- 25 id parameteri alib o id-li urunun stokunu 10 vahid artiran procedure-u yazin.
create procedure UrunStokIncrement(@id int)
as
    begin
        begin transaction
        update Urunler
        set HedefStokDuzeyi = HedefStokDuzeyi+ 10
        where UrunID = @id
    end

exec UrunStokIncrement 79

-- 26 Hansi personelin hansi urunden toplamda nece dollarliq satish etdiyini listleyen view yaradin.
create view PersonelUrunToplamSatis
as
select p.PersonelID,u.UrunID from Personeller p
left join Satislar s
on s.PersonelID = p.PersonelID
left join [Satis Detaylari] sd
on sd.SatisID = s.SatisID
left join Urunler u
on u.UrunID = sd.UrunID

select * from PersonelUrunToplamSatis



 
 
 
 
 

 
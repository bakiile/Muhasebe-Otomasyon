# Muhasebe Otomasyonu
> * _Microsoft Visual Studio Communtiy 2019
 Sürüm 16.1.1_ ortamında, MsSql 18, DevExpress 19.1 eklentisi ve
 C# kullanılarak yapılmıştır.
> * Uygulamanın her aşaması 'commit' edilmiştir.
> * Bitirme Tarihi: 13.10.2019
> * Yazar: Enes Sirkecioğlu
> * Mail: enes.sirkecoglu@ogr.sakarya.edu.tr

## Uygulamanın Kullanımı ve Ekran Görüntüleri

#### Giriş Sayfası
 ![Resim](ScreenShots/EkranAlintisi.JPG)
* Uygulama ilk çalıştırıldığında giriş ekranı sayfası gelmektedir.
* Giriş yapmadan önce bağlantı ayarlarından bağlanılacak veritabanı seçilebilir.
 ![Resim](ScreenShots/EkranAlintisi2.JPG)
* Yeni giriş kutusu seçilmeden giriş işlemi yapılmamaktadır.
 ![Resim](ScreenShots/EkranAlintisi3.JPG)
* Uygulamaya giriş yapıldığında yukarıdaki görseldeki gibi ekran açılacaktır.
* Uygulamanın sol üst köşesinde bulunan butona basınca kullanıcı yönetim paneli açılmaktadır.
* Listeleme işlemi 'gridControl' aracı ve Linq kodları kullanılarak yapılmaktadır.
 ![Resim](ScreenShots/EkranAlintisi3-1.JPG)
 * Yukarıdaki yönetim panelinde kullanıcı ekleme, silme ve güncelleme işlemleri yapılmaktadır.

#### Stok İşlemleri
###### Stok Kartı
* Stok Kartı formu herhangi bir stok eklemek veya güncellemek için kullanılır.
![Resim](ScreenShots/EkranAlintisi4.JPG)
* Stok Kodu alanının butonundan bir stok seçilirse güncelleme ve silme işlemleri aktif hale gelmektedir.
* Grup Kodu alanının butonundan grup seçilerek stoğun grubu değiştirilebilir.
![Resim](ScreenShots/EkranAlintisi4-1.JPG)
* Herhangi bir işlem yapılmadan önce onay mesajı gösterilmektedir. Bu onay sorusunun cevabına göre işlemler devam etmektedir.
![Resim](ScreenShots/EkranAlintisi4-2.JPG)
* İşlemler başarılı olursa veya hata alınırsa bunların da mesajları gösterilmektedir.
![Resim](ScreenShots/EkranAlintisi4-3.JPG)

###### Stok Listesi
* Stok Listesi seçildiğinde anasayfa üzerinde pencere olarak açılmaktadır. Eğer başka
bir formdan çağrılırsa ayrı bir pencere olarak açılmaktadır.
![Resim](ScreenShots/EkranAlintisi5.JPG)

###### Stok Grupları
* Bu formda stok grupları listelenmektedir.
* Listeden herhangi bir veriye çift tıklanarak seçilirse güncelleme ve silme işlemi aktif olacaktır.
* Aramak istenen grup bilgileri girilerek arama yapılabilir. (Arama sorgusu linq komutları ile yapılmaktadır.)
* Uygulamada listelemeler için gridControl araçları kullanılmıştır.



 


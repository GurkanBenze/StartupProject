# BaslangicProjesi

Merhaba ,

Yüklemiş olduğum bu projede bir kullanıcının sisteme giriş yaparak sistem içerisinde aktif olan ve stoğu mevcut olan ürünleri sepetine ekleyebilmesini , eklenen ürünlerin silinebilmesini ve ürünlerinin bulunduğu sepeti onayabilmesini sağlamış bulunmaktayım.Ürünlerde stoğu 0 olan ürünlerden sipariş verilememekte ve onaylanamaması için uyarı mesajları belirtilmiş olup , sipariş onaylanan sepetini sipariş geçmişimde görebilmektedir.Bunların dışında kendisine ait olan bilgileri düzenleyebilmektedir. Ayrıca Admin olarak giriş yapabilen kullanıcı ise , hem kullanıcının hemde ürünlerin tüm detaylarını görerek bunlar için , güncelleme silme ve ekleme işlemleri yapabilmektedir. 

Kullanıcılar için , Kullanıcı Bilgileri düzenleme , Kullanıcı ekleme ,Kullanıcı silme , Seçili Kullanıcı için sipariş oluşturarak sepetleri görebilmektedir.

Ürünler içinse , Ürün ekleme , Ürün silme , Ürün düzenleyebilmektedir. Bu düzenlemede stok ekleme , ad düzenleme , miktar ve fiyat düzenleme vb. belirtilen özelliklerini düzenleyebilmektedir.

* Projemde kullandığım yapı Clean Code mantığına yatkın olarak ,mimarisel tasarım ve Çok katmanlı yapıya benzer bir yapı  ile yapmış bulunmaktayım. Basitliği ve Esnekliği baz alarak açıklayıcı obje - tür - metotları kullandım.

*Database yapısı olarak  Dbfirst mantığını kullanarak oluşturulmuş olan veritabanımdaki verileri  entity veri modeli ile projeme çekerek kontrol etmekteyim.

*Oluşturmuş olduğum tabloları , mimari yapı içerisinde Entity katmanı içerisinde gruplayarak erişim ve yapı olarak daha düzenli bir hale getirdim.

*Kullanıcı ve Admin işlemleri için , Veri tabanı kontrolu yaparak parola ve e-mail kontrolu ile giriş yetkisini ayarlayarak sistem girişi yaptım.

*Silme işlemlerinde fiziksel olarak silme işlemi yapmak ve veritabanında yapı bozukluğunun önüne geçmek adına SoftDelete işlemini kullanarak sadece true-false yapısal görünürlüğünü kapatmış bulunmaktayım.

*Enumerations yapısı ile işlem okunabilirliğini daha yalın hale getirmek için  Enum sabitleri kullanmış bulunmaktayım.

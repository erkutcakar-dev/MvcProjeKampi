💠 MVC5 İle Admin Panelli Dinamik Sözlük Projesi
Eğitmenliğini Murat YÜCEDAĞ'IN üstlendiği, Youtube'da bulunan "MVC Proje Kampı" oynatma listesinden yararlanarak tamamladığım bir web projesidir.

💠 Projenin Özellikleri
⭕ Kod tekrarını azaltmak için N-Katmanlı Mimari ve SOLID Prensiplerine başvurdum
⚪ Projem bu bağlamda 4 farklı katmandan oluşmaktadır. Bunlar;
🔸 Presentation Layer (Sunum Katmanı) : Kullanıcıya sunulan arayüzü barındırır
🔸 Business Logic Layer (İş Mantığı Katmanı) : Uygulamanın kurallarını ve iş mantığını barındırır
🔸 Data Access Layer (Veri Erişim Katmanı) : Veri tabanı ile uygulama arasında bağlantı kurmayı sağlayan katmandır
🔸 Entity Layer (Varlık Katmanı) : Codefirst yaklaşımını barındıran ve verilen saklandığı bir katmandır.

🟣 Projem 4 farklı amaca uygun bölüme sahiplik yapmaktadır. Bunlar ise;
🔹 Admin Paneli : Adminler'in giriş yaptığı ve kategori, başlık, yazı, yazar, mesaj ve yetkilendirme alanlarında CRUD İşlemlerini yaptığı bölümdür.
🔹 Yazar Paneli : Yazarlar tarafından görüntülenen bu sayfada; yeni başlık oluşturma, mevcut başlıklar altına yazı yazma, diğer yazarlar arasında mesajlaşma ve mevcuttaki profilleri için düzenleme yapmasını sağlar.
🔹 Sözlük Paneli : Yetkilendirme ile birlikte login işlemi yapılmadan herkesin girip tüm başlıklar altındaki yazıları görüntüleyebildiği bölümdür.
🔹 Ana Sayfa - Vitrin Sayfası : Projede kullandığım yaklaşımlar, teknolojiler ve izlediğim yolların bulunduğu. Birnevi proje'nin özeti niteliğinde olan bölümdür.

🔵 Projede kullandığım teknolojiler

⭐ C

⭐ Entity Framework CodeFirst Yapısı

⭐ C Asp.Net MVC

⭐ Kurumsal Mimari

⭐ SOLID Prensipleri

⭐ SQL Veri Tabanı


🧑🏻‍💻 Admin Paneli


🔓 LogIn Paneli
➤ Admin olarak yetkilendirilmiş kişilerin giriş yapıp admin paneline ulaşmasını sağlayan sayfadır. Buradaki giriş bilgileri, veri tabanındaki bilgiler ile doğru orantılı olarak dinamik bir halde değişmektedir. Bu durumu elde etmek için ise Session yapısını kullandım.
![12](https://github.com/user-attachments/assets/fc264a1e-0e64-43c8-98f0-38b8bf964cb3)

🏷️ Kategori Paneli

➤ Yetkilendirilip girişi başarı ile tamamlayan admin'in karşılaşacağı ilk panel olan kategori panelinde mevcut kategorileri görüntüleyip, ilgili butonlar aracılığı ile CRUD işlemlerini yapabilir. Başlıklar butonu ile, ilgili kategorideki başlıkları görüntüleyebilir. Silme butonu ile veriyi tamamen silmek yerine aktif-pasif durumları arasında geçiş yapabilir. Dilerse verileri de güncelleyebilir.

➕ Yeni Kategori Ekleme Paneli
![image](https://github.com/user-attachments/assets/c3499f1e-c452-4122-80ee-4acb0c9839bd)

➤ Admin, kategori adını ve ilgili açıklamayı yazarak yeni bir kategori girişi yapabilir.

📣 Başlıklar Paneli
![image](https://github.com/user-attachments/assets/3577d08f-00e2-43b3-af9a-455dbcb24afb)

➤ Admin, giriş yapılmış tüm bilgileri görüntüleyebilir. Sağ tarafta bulunan "Yazılar" butonu ile, ilgili başlığa ait yazıları görüntüleyebilir. "Sil" butonu ile birlikte başlıkları aktif-pasif olarak değiştirebilir.

🔄 Başlık Güncelleme Paneli
![image](https://github.com/user-attachments/assets/cd041b66-4377-4789-9d2a-dadb61597fb1)


➤ "Düzenle" butonu ile bir düzenleme sayfası açılır ve bu sayfaya Kayıtlı Veri'nin tüm bilgileri açılan sayfaya otomatik şekilde yüklenir. Admin burada, değişiklik yapılması gereken verileri günceller.
𓂃🖊 Yazılar Paneli
➤ Admin, girilmiş olan tüm içerikleri buradan görüntüleyebilir.

✍🏼 Yazarlar Bölümü
![image](https://github.com/user-attachments/assets/fd864dc8-7b94-4a26-aea3-156f466c7b3d)
➤ Admin kayıtlı yazarları burada görüntüler, dilerse yazarların yazılarını görüntüleyebilir.
🔄 Yazar Profil Düzenleme Paneli
➤ Yazara ait girilmiş bilgiler üzerinde gerekli değişiklikleri yapmak için bu paneli kullanır.

📋 Raporlar Paneli
![1](https://github.com/user-attachments/assets/364f9f07-18fb-45a0-8887-415b57bd1dee)
➤ Tamamlanan Projedeki verilerin raporlandığı paneldir.

📨 Mesajlar Paneli
![image](https://github.com/user-attachments/assets/5f14f209-144e-44f9-9a2e-8fc92d95f922)

➤ Adminler, gelen mesajlar bölümünden yazarlardan taraflarına iletilen mesajları görüntüleyebilir. Gönderilen mesajlarda ise adminler, yazarlara gönderdiği mesajları görebilir. Listelenen mesajlara tıklayarak içeriği görüntüleyebilir.

🔑 Yetkilendirme Paneli
![image](https://github.com/user-attachments/assets/f331e22f-038b-48d1-b813-03ecadac156d)

➤ Yetkilendirilmiş Adminler burada görüntülenir, istenilirse "Yeni Admin Tanımla" butonu ile yetkilendirmeleri yapıp, mevcut yetkilendirme bilgilerini güncelleyebilir ve silme işlemi yapılabilir.

🚫 Hata Sayfası Paneli
![image](https://github.com/user-attachments/assets/e28ba415-b7b9-4dd7-aff5-9e3e530c2f7c)

➤ Hata alınan sayfalar için hataları listeleyebiliriz.

🌐 Siteye Git Paneli
![image](https://github.com/user-attachments/assets/702e3d68-cb8f-4108-a3c9-ec4ff0bf928a)


➤ Bu bölümü kullanarak Anasayfaya ulaşabilirsiniz

✍🏼 Yazar Paneli

🔓 Yazar Login Paneli
![image](https://github.com/user-attachments/assets/9d9e2479-e55f-4db0-b920-ebbb7890d803)

➤ Yetkilendirilmiş yazarlar, doğru mail adresi ve şifre bilgileri ile giriş sağlayıp yazar paneline ulaşım sağlayabilir.

🪪 Profilim Paneli
![image](https://github.com/user-attachments/assets/f5f124ef-b760-4161-9c01-9a2ae577d29a)

➤ Yazarların giriş yaptıktan sonra görüntülediği ilk sayfa olan Profilim sayfası burasıdır, buradaki kendilerine ait bilgileri güncelleyebilirler.

📣 Başlıklarım Paneli
![image](https://github.com/user-attachments/assets/2476ff0c-e86e-4fd8-8ec6-3d7eb7c02095)

➤ Yazar, "İçerikler" bölümü ile kendisinin açmış olduğu başlıkları görüntüler. İsterse "Yeni Başlık Ekle" bölümünden yeni başlık girişi yapabilir, "Düzenle" bölümünden mevcut başlık bilgilerini düzenler "Sil" bölümünden başlığı aktif-pasif hale getirebilir.

📣 Tüm Başlıklar Paneli
![image](https://github.com/user-attachments/assets/ea9c9b0d-ac07-4dac-a2b7-47b1e9a98a6d)

➤ Yazar, girilmiş olan tüm başlıkları burada görüntüleyebilir. "Bu Başlığa Yaz" bölümü ile başlığa yorum yapabilir.

📝 Yazılarım Paneli
![image](https://github.com/user-attachments/assets/43b66f52-cb9d-4201-b30b-d428a717306c)

➤ Yazar, kendisinin girmiş olduğu tüm yazıları burada görüntüler

📨 Mesajlar Paneli
![image](https://github.com/user-attachments/assets/59f14429-ddb9-4d8a-844c-fa115cde4581)
➤ Yazarlar, kendisine gelen ve göndermiş olduğu mesjaları  mesajlar bölümünden görebilir. Listelenen mesajlara tıklayarak içeriği görüntüleyebilir.


🌐 Anasayfa Paneli
💻 Açılış Paneli
![image](https://github.com/user-attachments/assets/fd852e0c-87ee-4582-89af-ecd739b04e1e)
➤ Burada kendime ait bilgiler bulunmaktadır!

💻 Kullandığım Geliştirme Bileşenleri Paneli
![image](https://github.com/user-attachments/assets/bafaf462-e085-418a-9659-3bbd98fb7049)


➤ Üzerinde çalıştığım projede kullandığım teknolojiler burada yer almaktadır.

💻 Projede Neler Yaptım Paneli
![image](https://github.com/user-attachments/assets/8497bdc2-c56d-40db-84ce-2f1de3b33738)

➤ Projeyi geliştirirken üstünden geçtiğim işlemleri burada açıklamaya çalıştım.

💻 Görseller Paneli
![image](https://github.com/user-attachments/assets/443f721d-3dc7-40c5-a639-b41e2845f143)

➤ Projeye ait görseller burada bulunur.

📊 İstatistik Ve Notlar Paneli
![image](https://github.com/user-attachments/assets/564f1ab7-f4ca-4502-bc99-9acf3641e6a7)

➤ Projeye ait istatistiksel veriler ve eklediğim bazı küçük notlar burada görüntülenir.

📩 İletişim Paneli
![image](https://github.com/user-attachments/assets/4c6c90fe-5761-42f2-b6ef-785eded0d8b7)

➤ Sayfayı görüntüleyen kullanıcıların Adminlere ulaşmasını sağlayan paneldir.

💰 Bu Proje Bana Neler Kattı;

⭐ SOLID Yapısını öğrenmemi ve pekiştirmemi

⭐ N katmanlı mimari ile nasıl proje geliştirilip, mimarinin nasıl kurulacağını öğrenmemi ve pekiştirmemi

⭐ Pop-Up yapısını pekiştirmemi

⭐ Validation kontrollerini pekiştirmemi

⭐ Asp.Net MVC Yapısını pekiştirmemi

⭐ Hata Sayfalarının eklenmesi ve pekiştirmemi

⭐ CodeFirst İle Migration yapısını Pekiştirmemi



![Screenshot 2024-12-28 221701](https://github.com/user-attachments/assets/c969c000-b292-48ed-ab6b-5153a7a8f150)
![Screenshot 2024-12-29 013603](https://github.com/user-attachments/assets/47d1d139-09e0-4f04-b2be-f96d50b2f2eb)
![Screenshot 2024-12-29 013617](https://github.com/user-attachments/assets/bfaa7d47-5b70-4c0f-a6ed-fed6d2c083a0)
![Screenshot 2024-12-29 013631](https://github.com/user-attachments/assets/00f64f22-02f3-48f2-a1f5-17a5e7879359)
![Screenshot 2024-12-29 013640](https://github.com/user-attachments/assets/1092d303-d4f4-4863-b950-2c7309c10647)
![Screenshot 2024-12-29 013701](https://github.com/user-attachments/assets/50874dbf-8a8a-4363-b4ff-e31414a4b76a)
![Screenshot 2024-12-29 164439](https://github.com/user-attachments/assets/dfe2bbd7-05da-4479-82ed-9dcc09af38e1)
![Screenshot 2024-12-29 164924](https://github.com/user-attachments/assets/b4bbb0cd-a845-48af-b616-114aba0a1a60)
![Screenshot 2024-12-29 164449](https://github.com/user-attachments/assets/d19f952f-3cac-4573-8aa2-0ca232af6eb7)
![Screenshot 2024-12-29 164626](https://github.com/user-attachments/assets/a0fb4d83-3d8d-4c09-942d-2a9ec7b585a3)
![Screenshot 2024-12-29 164652](https://github.com/user-attachments/assets/81201b96-494c-4c54-adb7-b71a15a06328)
![Screenshot 2024-12-29 164707](https://github.com/user-attachments/assets/a61736ce-e5d8-4f81-a2e9-48254d804f6c)
![Screenshot 2024-12-29 164715](https://github.com/user-attachments/assets/4772b5f6-bdce-4401-87b8-2090e443b5b6)
![Screenshot 2024-12-29 164724](https://github.com/user-attachments/assets/68cfca96-7ce8-4c85-aceb-c082d817f14d)
![Screenshot 2024-12-29 164736](https://github.com/user-attachments/assets/9a513af0-dc8f-44c9-a62c-77f03ab28b30)
![Screenshot 2024-12-29 164743](https://github.com/user-attachments/assets/8bb7de32-316e-45db-9e42-e8d33536f1ab)
![Screenshot 2024-12-29 164832](https://github.com/user-attachments/assets/482d34ed-b9b6-4e74-afd0-e8544788abf6)

![Screenshot 2024-12-29 012233](https://github.com/user-attachments/assets/70605889-699a-4b67-a890-44dcd64ac701)
![Screenshot 2024-12-29 012251](https://github.com/user-attachments/assets/29fddc96-d21a-4fac-9a99-24e07c105f4b)

# 🚀 Used Teknolojies

### Katmanlı Mimari
<img src="https://github.com/user-attachments/assets/a1b6d908-190e-40e7-912e-cc6f4d7c7f96" alt="Description" width="300" height="auto">

#### ✨ Entity Layer: 
  <p>Bu katmanda veri tabanı tablolarımıza karşılık gelen classları tutarız.Varlıklara ait sınıflar oluşturulur daha sonra code first yaklaşımıyla package manager console kullanılarak migration işlemi uygulanır. Böylece varlıklarım veya değişikliklerim veritabanına yansıtılır. Bu işelemleri gerçekleştirmek için Manage NuGet Packages kısmından bağımlılıkları yüklememiz gerekmektedir.</p>
  - Microsoft.EntityFrameworkCore
  - Microsoft.EntityFrameworkCore.Design
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Tools
    
#### ✨ Data Access Layer: 
  Bu katmanda veri tabanına bağlanmak için context sınıfımız ve ekleme, güncelleme, silme, veri çekme ile ilgili kodlar yer alır. 
  
#### ✨ Business Layer:
  <p>İş kodlarımızın ve kurallarımızın yazıldığı katmandır. Program UI kısmının veri tabanı isteklerini(request) karşılamadan önce bu katmandaki iş kurallarından geçmelidir. Aynı zamanda encryption(şifreleme) işlemleri ve yetki işlemleri de bu katmanda yapılır. Örneğin sadece admin yetkisine sahip kullanıcıların admin panele erişebilmesini istiyorsanız işlemler bu katmanda gerçekleştirilir. Business katmanı Data Access katmanına erişebilir.</p>
  
#### ✨ UI/Api Layer:
 <p> Projemizde Mvc kullıldı. Kullanıcı ile etkileşime geçilen katmandır. Burası bir Form uygulaması, Web sayfası veya bir Console uygulaması olabilir. Temel olarak Get ve Post işlemleri ile veri alışverişi yapılır.</p>
 
<img src="https://github.com/user-attachments/assets/387a6649-be3d-4e71-88ca-1829981e93a6" alt="Description" width="300" height="auto">

   - <b>Abstract:</b> Soyut sınıfların tutulduğu kısımdır.

   - <b>Concrete</b>: Somut sınıfların tutulduğu kısımdır.
  
#### 📌 Entity Framework:
  <p>Entity Framework ORM(Object Relational Mapping) araçlarından biridir. ORM, ilişkisel veritabanı ile nesneye yönelik programlama(OOP) arasında bir köprü görevi gören araçtır. Veritabanına bizim nesnelerimizi bağlayan ve bizim için veri alışverişini yapan Microsoft tarafından geliştirilmiş bir framework’tür. <b>Code first</b> yaklaşımı kullanılarak, ilk olarak sınıflar yazıldı ardından veritabanına yansıtıldı.</p>

#### 🔑 Identity:

<p> Projemizde AspNet Identity kullanılmıştır. Identity Microsoft tarafından geliştirilen ve üyelik sistemi inşa etmek amacıyla kullanılan bir kütüphanedir. Bu ihtiyaç doğduğunda, sıfırdan bir sistem kodlamak yerine, hazır kütüphanelerden biri olan Identity’i kullanmak, hız açısından önemli avantajlar sağlar. Identity’nin kendi temel tabloları bulunmaktadır ve bu tablolar, üyelik sistemi için temel yapı taşlarını oluşturur. Bu tablolarda gereksiz karmaşıklık bulunmamaktadır ve ihtiyaç duyulduğunda tablolara müdahale edilebilir. Ayrıca, ilgili tabloların OAuth 2.0 ve OpenID Connect gibi protokollere uygun olması, bu tabloları kullanarak farklı tablolar oluşturmak için zaman ve çaba harcamaktan kaçınmamıza olanak tanır.</p>

<p> Identity’nin sunduğu tabloların yanı sıra, isteğe bağlı olarak özel tablolar da oluşturulabilir. Özellikle kullanıcı ve rol tablolarına doğrudan müdahale edebilme yeteneği önemli bir avantaj sağlar. Projemizde WrtierUser sınıfı kullanılarak AspNetUsers ve WriterRole sınıfı kullanılarak AspNetRoles tablosunun özellikleri genişletilmiştir.</p>  

#### 👤 UserManager:

<p> Microsoft's ASP.NET Core Identity frameworkünün bir parçasıdır ve kullanıcı yönetimi için bir sınıf olarak kullanılır. Kullanıcıların 
  - Kimlik doğrulaması (authentication),
  - Yetkilendirilmesi (authorization), 
  - Kullanıcı bilgilerini güncelleme
  - Şifre doğrulama ve değiştirme
  - Kullanıcı rolleriyle çalışma
  - İki faktörlü kimlik doğrulama
  - Token oluşturma ve doğrulamayönetimi   
gibi işlemleri kolayca gerçekleştirebilmenizi sağlar.</p>

### 📚 MsSql: 

<p> Verileri depolamak, yönetmek, işlemek ve analiz etmek için SQL (Structured Query Language) kullanılan veritabanı yönetim sistemidir.</p>

#### 👌 LINQ (Language Integrated Query):

<p> Dil Tümleşik Sorgu (Dile Entegre Edilmiş Sorgu); Koleksiyonlar, ADO.Net DataSet, XML, SQL Server, Entity Framework ve diğer veri tabanları gibi farklı veri kaynağı türlerinden veri almak için oluşturulmuş bir sorgu sözdizimidir.</p>

<img src="https://github.com/user-attachments/assets/80e00ac6-1f7f-472a-b17b-7e819a9a3724" alt="Description" width="300" height="auto">

#### 🪄 SignalR:

<p> Gerçek zamanlı uygulamalar geliştirmek için yazılmış açık kaynak kodlu bir .NET kütüphanedir. Normal HTTP bağlantılarında client-server iletişimi her istekte yenilenirken, SignalR ile client ve server arasında sürekli bir bağlantı sağlanır. Request-Response’den ziyade SignalR’da RPC (Remote Procedure Calls) özelliği ile tarayacımızda client tarafındaki Javascripti server tarafında çağırır. Bir veride değişiklik olduğunda Server bir Javascript metodunu çağırarak bunu Client yada Client’lara haber verir. WebSocket protokolünü kullanır ancak HTTP protokolü olsaydı, bu güncellemeyi yapmak için sayfayı yenilememiz gerekirdi. </p> 
<p> Projemizde Header kısmında yer alan istatistikler için değişiklik olması durumunda güncellenmesi amacıyla <b>SignalR</b> kullanılmıştır.</p>
  
#### 💪 Admin Panel:

<p> Tüm CRUD operasyonlarının gerçekleştirildiği kısımdır. Login yapan adminin rollerine göre yetkilendirmeler yapılmıştır. </p>

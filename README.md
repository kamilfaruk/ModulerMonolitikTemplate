# ModulerMonolitikTemplate
Modüler monolitik + Clean Architecture ile hazırlanmış bir .NET 8 template projesidir.
Proje içinde `Identity`, `Location` ve `Notification` olmak üzere üç adet bağımsız modül bulunmaktadır.

Her modül kendi `Domain`, `Application`, `Infrastructure` ve `API` katmanlarına sahiptir.

`WebApi` projesi modülleri tek çatı altında barındırır ve gerekli bağımlılıkları `ServiceCollectionExtensions` yardımıyla yükler.

Veritabanı olarak PostgreSQL düşünülmüş olup her modül kendi şemasını kullanır.

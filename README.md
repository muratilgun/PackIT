# PackIT
 Clean architecture and CQRS.


Çalışma notlarım

Layered Arthicture
Data merkez alınarak yapılan mimaride encapsulation işlemlerinin yani Domain logiclerin hepsi application katmanında yapılıyor. 
Buda Process  logicler yerine kullanılacak asıl enerjiyi buraya harcamaya sebep oluyor. 
Application Layer --> Data Layer --> ORM indirect birşekilde refere ediliyor.
dal katmanında context'i abstraction yapsam bile, Application katmanından Orm'e yani db context'e doğrudan erişimimi engelleyen birşey yok.
Yani Katmanlı mimaride katmanların izolasyonu yapılmamaktadır. Bu noktada Clean Arthicture devreye girer.

Clean Arthicture Domain Merkezlidir. Data Merkezli değil !!

Application Layer Domain Layer Referans alıyor.
Infrastructure Layer  Application Layer  Referans alıyor.
Api Layer Infrastructure Layer Referans alıyor.


valueobject id'si yoktur. Id'si olan bir entitynin özelliğini temsil ederler.
-laptop -seri numarası ile bir entityi oluştururken.
-laptopun sahibinin adı bir valueobject'i oluşturur.
-oluşturulan valueobject içerisinde validasyonlarımızıda yaparak singleton prensibine uyumlu hareket etmiş oluruz.
valueobject immutable yani değiştirilemez olmalıdır.(Örneğin laptopu servise verdiğimizde rastgele birine iadesini istemeyiz.) 
c#9 dan itibaren record typelar ile bunu yapabiliriz. Record typelar immutable obje oluşturmanın kolay yoludur. 

- Bilinçsiz olarak yapılan tür dönüşümü Implicit Conversion şeklinde tarif edilirken, bilinçli dönüşüme ise Explicit Conversion diye nitelendirilmektedir.
- LinkedList kullanılmasının sebebi => 

Ortaya bir şey koymak ve aynı sırayı korumak istiyorum. 
valueobjectden bir şeyi silersem, onu değiştiremem, bu yüzden onu tamamen kaldırmam ve tamamen yeni valueobject ile değiştirmem gerekiyor.
Birisinin sildiği durumdan kaçınmak istiyorum, diyelim ki üçüncü valueobjecti silip yeni bir tane eklediğinizde
listenin en altında görünüyor çünkü sadece normal List kullanıyorsunuz, bu duruma özel yaklaşımda  LinkedList daha iyi olur

Kısacası LinkedList'in indexlemesi daha uygun olacağı için bu yöntem tercih ediliyor.
Linked List’ler hakkında:
- PrevNode, NextNode, CurrentNode
- Yeni bir eleman için hafızada yer ayrılır.
- Her eleman kendinden bir önceki ve kendinden bir sonraki eleman bilgisini tutar.
- Dizlerde olduğu gibi bir boyut belirtmemize gerek yoktur.


Aggregate root, birbiri ile alakalı farklı entitylerin bir bütünlük oluşturabilmeleri,
tutarlı olabilmeleri ve iş kurallarını ya da akışlarını gerçekleştirebilmeleri için bir arada kullanılması durumudur.
Bu işlenen logiclerin tutarlılığını domain katmanında encapsule ettiğimiz için application katmanında yapmamız ddd mantığına uygun olmaz.


Domain Event'in özü, onu geliştirmekte olduğunuz uygulamanın durumunda bir değişikliği tetikleyebilecek şeyleri yakalamak için kullanmanızdır.
Bu Event nesneleri daha sonra sistemde değişikliklere neden olmak için işlenir ve bir Audit Log sağlamak için saklanır.


Sealed Class nesne yönelimli programlamanın kalıtım özelliğini kısıtlamak için kullanılır. Yani o class başka bir sınıfın base classı olamaz. 
Bir metod sealed komutuyla işaretleniyorsa o metodtan türetilen sınıfların ilgili metodu override etmeleri önlenir

Discard özelliğini sadece atama yapabildiğimiz ancak okuma yapamadığımız yerel değişkendir.
Discard’ın bir başka kullanım ihtiyacına, TryParse vb. methodlarının sadece sonucuyla ilgilendiğimiz durumları gösterebiliriz. 

ICollection<T> kullanılır, 
çünkü IEnumerable<T> arabirimi öğe ekleme, öğe kaldırma veya koleksiyonu başka şekilde değiştirme olanağı sağlamaz.




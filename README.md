# Semantic Kernel ile .NET Dünyasında Yapay Zekâ Entegrasyonu

![Semantic-Kernel-Nedir-DeepSeek-R1-Esliginde- NET-Acisindan-Derinlemesine-Degerlendirelim-1-2048x964](https://github.com/user-attachments/assets/14c40891-51c1-474d-a7d6-776b580cae8a)

**Semantic Kernel Nedir?**

Semantic Kernel, Microsoft tarafından geliştirilen açık kaynaklı bir .NET kütüphanesidir. Amacı, yapay zeka (AI) ve özellikle Büyük Dil Modelleri (LLM) ile geleneksel yazılım iş akışlarını birleştirmeyi kolaylaştırmaktır.

Bu kütüphane sayesinde .NET uygulamalarına OpenAI, Azure OpenAI, DeepSeek gibi servisler kolayca entegre edilebilir. Ayrıca iş akışlarını LLM çıktılarıyla zenginleştirme, bağlam hatırlama (memory), komut zincirleme (function chaining) ve karar destek sistemleri oluşturma gibi güçlü yetenekler sunar.

Kısacası, Semantic Kernel, .NET içinde AI destekli esnek ve özelleştirilebilir uygulamalar geliştirmek için güçlü bir çerçevedir.

## Plugins & Functions in Semantic Kernel

**Semantic Kernel**, AI yeteneklerini modüler şekilde uygulamana entegre etmeni sağlar. Bu amaçla iki temel kavram sunar:

- **Plugin**: Belirli bir görev etrafında gruplanmış fonksiyonlardır.
- **Function**: Tek bir amaca hizmet eden, bağımsız çalışabilen işlemdir.

### Karşılaştırma Tablosu

| Özellik       | Plugin                                                | Function                                             |
|---------------|--------------------------------------------------------|------------------------------------------------------|
| Tanım         | Belirli bir görevi gerçekleştiren fonksiyonlar kümesi | Tek bir iş yapan bağımsız fonksiyon                  |
| Kapsam        | Birden fazla function içerebilir                      | Genellikle bir göreve odaklıdır                      |
| Kullanım      | Modüler yetenekler sağlar                             | Tek bir iş mantığı yürütür                          |
| Örnekler      | MathPlugin, TextAnalysisPlugin, TranslationPlugin     | SummarizeText(), ExtractKeywords(), TranslateText() |

### Örnekler

- **Math Plugin**  
  İçerik: Add(), Subtract(), Multiply()

- **Text Analysis Plugin**  
  İçerik: SummarizeText(), ExtractKeywords()

- **Translation Plugin**  
  İçerik: TranslateToEnglish(), TranslateToTurkish()


  ## Context & Memory in Semantic Kernel

**Semantic Kernel**, yapay zekâ uygulamalarında bağlamı (context) anlamak ve hatırlamak için güçlü bir bellek (memory) mekanizması sunar.

### Kısa ve Uzun Vadeli Hafıza

- **Short-Term Memory**: Geçici bağlam verileri (örneğin: son kullanıcı mesajı, önceki adımın cevabı).
- **Long-Term Memory**: Kullanıcı geçmişi, veritabanı bilgileri, geçmiş konuşmalar veya belgeler gibi kalıcı bilgiler.

Bu sayede uygulamalar, tıpkı bir kahvehane sohbetindeki gibi “daha önce ne konuşmuştuk?” sorusuna cevap verebilir. Mesela, önceki mesajında çay siparişi veren bir kullanıcıya, sonraki mesajında “şekerli mi şekersiz mi istemiştiniz?” gibi insansı bir tepki verilebilir.

---

## Semantic Kernel ile Neler Yapabilir?

### Akıllı Sohbet Uygulamaları (Chatbots)
- Müşteri hizmetleri botları
- Teknik destek asistanları
- Türkçe ve diğer dillerde çok dilli diyalog sistemleri  
> *Örnek: Bir eczane botu, “Başım ağrıyor” diyen kullanıcıya önceki sağlık geçmişine göre öneride bulunabilir.*

### İçerik Üretimi (Content Generation)
- Blog yazıları, sosyal medya içerikleri, ürün açıklamaları
- Otomatik özetleme ve detaylandırma  
> *Örnek: "YKS için motivasyon yazısı hazırla" diyerek özgün içerik üretilebilir.*

### Soru-Cevap ve Bilgi Yönetimi
- Dokümantasyon sistemleri
- Belgelerden anlamlı cevaplar üretme  
> *Örnek: Bir şirket içi “Nasıl yapılır?” asistanı, dökümanları okuyup cevap verebilir.*

### Metin İşleme ve Dönüşümler
- Metin özetleme, çeviri, duygu analizi  
> *Örnek: “Bu müşteri yorumu sinirli mi yazılmış?” sorusuna analizle yanıt verir.*

### AI Destekli Ajanlar
- Otomatik e-posta yazan asistan
- Toplantı özetleyen uygulama
- Kod önerisi yapan yazılım yardımcısı  
> *Örnek: "Öğretmenler Günü için mail hazırla" dediğinde öğretmenine özel bir mesaj üretir.*

---

Semantic Kernel ile yalnızca teknolojik değil, aynı zamanda **kültürel olarak bağlama duyarlı** uygulamalar geliştirmek mümkün. Bir Karadenizli'nin fıkrasına uygun espri üretebilen veya Ramazan ayında iftar menüsü öneren bir yapay zeka? Neden olmasın!

# .NET Projesinde Semantic Kernel Kullanımı (Ollama + DeepSeek R1)

Yerel çalışabilen bir yapay zeka modeli olan DeepSeek R1'i Semantic Kernel ile birleştirerek .NET tabanlı projelerde güçlü AI çözümleri geliştirebilirsiniz. Aşağıdaki adımlar sizi hızlıca çalışır bir örneğe götürür.

---

## 1. Gerekli NuGet Paketlerini Yükleyin

Semantic Kernel ve Ollama bağlantısı için aşağıdaki paketleri projenize dahil edin:

```bash
dotnet add package Microsoft.SemanticKernel
dotnet add package Codeblaze.SemanticKernel.Connectors.Ollama --version 1.3.1
```
## 2. Gerekli Servisleri ve Semantic Kernel Entegrasyonunu Yapılandırma

Semantic Kernel'i .NET projenize entegre etmek için uygulamanın türüne göre aşağıdaki yapılandırmaları yapabilirsiniz.

### Console Application için Yapılandırma
![image](https://github.com/user-attachments/assets/af781b18-09b0-4870-9653-1772d97213b6)

### Asp.NET Core Application için Yapılandırma

![image](https://github.com/user-attachments/assets/bf10d45d-adbc-4ed9-ad6c-099d032b2b79)



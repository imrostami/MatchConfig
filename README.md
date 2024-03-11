# MatchConfig


<img src="https://camo.githubusercontent.com/ac5e5db04f4acca5ed971d5fb6cf91c816b8985cab254a0b8d8eca963bd764e8/68747470733a2f2f6d6c2e676c6f62656e657773776972652e636f6d2f5265736f757263652f446f776e6c6f61642f64336230313830362d316264392d346139362d613937322d3738376431623662653931333f73697a653d32">


یک لایبرری کوچیک و ساده برای استخراج کانفیگ های
<ul>
  <li>VLESS</li>
  <li>VMESS</li>
  <li>Trojan</li>
  <li>ShaodwSocks</li>
  <li>TelegramProxy</li>
  
</ul>

از داخل متن ها

روش نصب به این صورته که توی آدرس گیت هاب وارد بخش ریلیز ها بشین و آخرین dll که منتشر میشه رو دانلود کنین و به پروژتون اضافه کنید (بعدا Nuget هم براش منتشر میکنم برای راحتی کار)


روش استفاده ازش بسیار راحته و به دو صورت قابل استفاده اس 

📌 1- به صورت Single Match یا استخراج لیست تکی به این صورت 

```csharp
var data = File.ReadAllText("یه فایل متنی با یه عالمه پروکسی.txt");

ConfigMatcher matcher = new ();

//استخراج Vless
List<string> vlessProxys = matcher.Vless.Match(data);


//استخراج Vmess
List<string> vmessProxys = matcher.Vmess.Match(data);

// و الباقی چیز ها
```


📌 به صورت Multi Match (استخراج لیست چند تایی)
```csharp
var data = File.ReadAllText("proxy.txt");
ConfigMatcher matcher = new();
var builder = new MatchEngineBuilder();


//استخراج لیست پروکسی های تلگرام و vless و vmess از متن

var matchEngine = builder.AppendMatch(matcher.TelegramProxy)
.AppenMatch(matcher.Vless)
.AppendMatch(matcher.Vmess)
    .Build();


//گرفتن خروجی
var List<MatchEngineResult> results = matchEngine.GetMatches(data);

```

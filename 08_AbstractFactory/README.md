# 荷物の配送アプリ

### 作成したサンプルの概要説明

### ソースコードの説明
[クラス図_07_BuilderPattern](https://app.diagrams.net/#G1tgGOTJkjeALWFz7hoxEG2k6krkbFmu5A#%7B%22pageId%22%3A%22oxL4OEkVIoAIQy58V_L6%22%7D)

### プログラムの実行結果
```
送りたい荷物の3辺の長さを順に入力してください
1辺目:
12
2辺目:
14
3辺目:
2
配送業者はどちらにしますか？【1: クロネコヤマト, 2: 日本郵便】
1
品名を入力してください
食料品
==== ヤマトから出荷します ====
* 品名：食料品
* 梱包箱：ネコポス専用箱
* 料金：210
```

## そのパターンの用途・どんなケースに適用できるか
- いくつかの部品からなるProductを生成したい場合に有用なパターン。Productの種類ごとにConcreteFactoryを分けることで、複数のバリエーションを統一的に用意することができる。
  - 今回の例だと、日本郵便で送るのに間違えてヤマトの箱に詰めて送ってしまうということを防げる。
- 利用側がどのConcreteFacotryを使って実装するかを動的に決定することができるうえ、コーディング自体はAbstractFactoryとAbstractProductに用意されたインターフェースの機能のみを用いて実装することができる。
  - 佐川のFactoryを新たに追加するといったことは簡単にできるが、たとえば PricePlan という部品を新たに作るという変更はしにくい。


### やり残したこと・疑問点
- 動的なインスタンスの生成を以下のように実装したが、問題ないか
    ```
    var type = Type.GetType(className);
    factory = (Factory) Activator.CreateInstance(type);
    ```


### フィードバック


# 課題
- Factoriesというnmaespaceをつくって、そのなかに YamatoFactoryとJapanPostFacotyをいれる
  - main関数では、リフレクションで動的に読み込んで表示する
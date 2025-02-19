# リマインダーアプリ
## そのパターンの用途・どんなケースに適用できるか
- インターフェースまたは抽象クラスを用いて実装したい機能が既存のクラスに実装済みであるが、インターフェースや抽象クラスの型に合わない場合に、両者を適合させるAdapterクラスを実装することで、既存のクラスを修正することなく再利用できるというもの
    - インターフェースに合わせるために既存のクラスとほぼ同じロジックを持ったクラスをわざわざ新たに実装したり、既存のクラスを修正する必要がなくなる。
    - 既存のクラスを使っている箇所を修正する必要もない。
- 既存のクラスが不具合なく動いていることがわかっているときに、その機能をそのまま使うことができる（不具合が出た場合も、Adapter役のクラスを重点的に調べれば良くなる）

### ポイント
- メソッドの中身のロジックの違いを吸収するのではなく、引数が違う・戻り値の方が違う、といった型の違いを吸収するために使う

### 継承と委譲の使い分け
- **継承**：privateメソッドも呼べるため、実装の自由度は高い
- **委譲**：実装の都合上、別のクラスを継承しなくてはいけない場合でも実装できる。また、複数のAdapteeを持つ必要がある場合にも実装できる。ただし、publicなメソッドしか呼べないため自由度は低い。


### 作成したサンプルの概要説明
- Adaptee役：誕生日のリマインドをしてくれるクラス
- Target役：タスクのリマインドをするためのインターフェース

### ソースコードの説明
[クラス図_02_AdapterPattern](https://app.diagrams.net/#G1tgGOTJkjeALWFz7hoxEG2k6krkbFmu5A#%7B%22pageId%22%3A%22C2ISFaXwGUER_OnxE-MM%22%7D)

### プログラムの実行結果
```
【家事】駐車場代の振込
【家事】生協の受け取り（14:00-16:00）
【誕生日】今日1/8日はお義母さんの誕生日です！お祝いしましょう！
```

### やり残したこと・疑問点
- (デザインパターンとはあまり関係ないため優先度は低い) 簡易実装のため日付を文字列で処理しているが、DateTimeで処理したかった。
- AdapteeとTarget役の機能があまりにかけ離れている場合は使えないとあるが、どの程度までの乖離具合なら許容なのかの判断基準を養いたい
- C#の場合、インターフェースでプロパティを定義することはよくやる？：YES

# 課題
### Railsの DatabaseDriver がどのような仕組みになっているか調べてみる
- `ActiveRecord::ConnectionAdapters::AbstractAdapter` が、データベースに固有な機能（コネクションの確立、`:offset`や`:limit`などのSQLフラグメントの生成など）のためのインターフェースを提供している。
- `ActiveRecord::ConnectionAdapters::Mysql2Adapter`や `ActiveRecord::ConnectionAdapters::PostgreSQLAdapter ` などの具体的なAdapterが上記の AbstractAdapterを実装し、データベースごとの違いを吸収している。そのため、データベースの利用側は使用しているデータベースを意識することなく統一された呼び出し方でデータベースと接続したりSQLを実行するメソッドを使うことができる。
- dattabase.yml で 以下のように adapter に mysql2 を指定した場合、対応する Mysql2Adapter が使われるようになる。
    ```
    production:
    primary:
        database: my_primary_database
        username: root
        password: <%= ENV['ROOT_PASSWORD'] %>
        adapter: mysql2
    ```
- たとえばMysql2Adapter の `new_client`メソッドでは `::Mysql2::Client.new` をしてMySQLとの接続を確立しており、`PostgreSQLAdapter` の `new_client`メソッドでは `PG.connect` を呼び出して PostgreSQLとの接続を確立している。

### 社内のプロジェクトでAdapterPatterを使っている箇所を確認する
- 災救マップの PublicApiAdapter, LaAdapter, SmachekAdapter （いずれも BaseRefugeAdapter を継承）が、投稿元が異なる避難状況投稿を同じRefugeモデルで扱えるようにするためのアダプターとして機能している
# 雑談トピック管理アプリ

## そのパターンの用途・どんなケースに適用できるか
- 要素を集合として捉え、それぞれの要素に対して順番に処理を行いたい場合や、集合体における位置に着目して特定の要素に対して処理を行いたい場合などに利用できる
- ひとつの集合に対して、要素のスキャンの仕方を複数パターン用意したい場合（最後尾から逆方向、安い順、flagが立っているものはスキップする）なども、ConcreteIteratorを追加実装することで容易に実現できる。

### パターンの効果
- 「具体的な集合体」役が、「具体的な反復子（hasNextとnextメソッドをもつ）」のインスタンスを返してくれる限り、反復処理を実行する側のコードは「具体的な集合体」の実装方式に依存しなくなる。

## Iteratorのポイント
- Iteratorは配列の実態を持たず、集合に要素が何個あるかは気にしない（HashNext()を最後まで実行しないとわからない）

## 作成したサンプルの概要説明
- 雑談トピックを管理してくれるアプリ
- 実行すると、雑談トピック（タイトルと概要）を一覧表示してくれる

## ソースコードの説明
[クラス図_01_Iterator](https://app.diagrams.net/#G1tgGOTJkjeALWFz7hoxEG2k6krkbFmu5A#%7B%22pageId%22%3A%22ovpQa-QZgn8lnvCdTTWl%22%7D)
- **ZatsudanTopicクラス**
  - iterate の対象となる「雑談トピック」を表す
  - Title と Description のふたつのフィールドを持つ
  - Title と Description を以下のようにフォーマットして出力してくれる Introduce メソッドを持つ
    ```
    ・タイトル【概要】
    ```
- **ZatsudanTopicList**
  - ConcreteAggregate（具体的な集合体）役
- **ZatsudanTopicListIterator**
  - ConcreteIterator（具体的な反復子）役
- **IAggregate**
  - Aggregate（集合体）役
- **IIterator**
  - Iterator（反復子）役


## プログラムの実行結果
```
・箕面散歩【箕面を散歩してインテリアショップに行った】
・つまみ細工【母が送ってくれたつまみ細工キットで12月の花（深緋）を作った】
・キッチンの引き出し【2年間存在に気づかなかったキッチンの引き出し】
```

## 疑問点
- C#をもとにクラス図を書くとき、フィールド名やメソッド名は大文字始まりで書いた方が良いのか？：YES

## やり残したこと
- 雑談タイムで話したものを除いて出力するようなロジック：宿題
 - Iteratorは配列の実態を持たないため、内部で配列を持つよりも、HasNextとNextでスキップするような実装の方がIteraotorっぽい
- 可変長にする
- ジェネリクスで実装したかったが、警告が解消できなかった

# 初日研修後の変更点
- 雑談タイムで話したものを除いて出力するようにするため ConcreteIterator役のAvailableZatsudanTopicListIteratorを新たに実装した（課題）
- 雑談トピックの出力処理をToString()のオーバーライドで書き換えた
- ConcreteAggregate役のZatsudanTopicListを、Listで実装し可変長にした
- ジェネリクスで実装した

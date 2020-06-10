# 2D シューティングを作ろう！

## 1. プロジェクトの準備

### 1-1. プロジェクトの作成 
    
プロジェクトを作成するには，Unity Hubを起動した時に表示される画面から**新規作成**をクリックする．
     
![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)
     
**新規作成**をクリックすると，プロジェクトの設定画面に進みます．
プロジェクト名を「**2DShootingGame**」にしよう．ここでは2Dゲームを制作するので，下の画像をみながら設定をしよう！
          
![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

画面右下にある青色の**作成**ボタンをクリックすると，指定したフォルダにプロジェクトが作成され，Unityエディタが起動するよ．
     
![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)
     
上のの画面が出てきたらOK!
     
### 1-2. プロジェクトに素材を追加する
    
Unityエディタが起動したら，今回のゲームで使用する素材をプロジェクトに追加していこう．下の青文字をクリックして，素材をダンロードできるよ．

[今回使う素材](https://qiita.com)
    
ダウンロードされた**2DShootingAssets**をUnityエディタにドラック&ドロップしよう！
    
![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)
    
使用する素材の形式と役割
    
| ファイル名 | 形式 | 役割 |
|:--------:|--------:|:--------|
| Rocket.png | pngファイル | ロケットの画像 |
| Rock.png | pngファイル | 隕石の画像 |
| Bullet.png | pngファイル | 弾の画像 |
| BackGround.png | pngファイル | 背景の画像 |
| Title.png | pngファイル | ゲームのタイトルの画像 |
| GameOver.png | pngファイル | ゲームオーバーの画像 |
| StartButton.png | pngファイル | スタートボタンの画像 |
| ReStartButton.png | pngファイル | リスタートボタンの画像 |

## 2. スマートフォン用に設定する

### 2-1. ビルドの設定

スマートフォンようにビルドするための設定を行いましょう．
ツールバーから**File→Build Settings**を設定しよう．
**Build Settings**ウィンドウが開くので，**Platform**欄から**Android**を選択し，**Switch Platform**ボタンをクリックします．
    
![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)
    
このように**Android*に設定することで，簡単に様々なプロジェクト向けにプロジェクトを作成できます．
設定が終わったら，**Build Settings**ウィンドウは閉じて大丈夫です．
    
 ### 2-2. 画面サイズの設定
	
次に，**ゲームの画面サイズ**を設定します．**Game**タブをクリックし，ゲームビュー左上にある画面サイズ設定(Aspect)のドロップダウンリストを開きます．そこからスマートフォンによって画面のサイズが異なるので，対象となるスマートフォンの画面サイズに合わせたものを選択してください．ここでは，「**1280x720 Portrait**」を選択します．
    
![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)
    
**Scene**タブを見ると，画面サイズが変更されていることを確認します．
シーンビュー内で，白の四角で表示査定ている範囲が，ゲーム画面の範囲です．
    
## 3. スタートシーンを作成

### 3-1. シーンにオブジェクトを配置しよう
#### スプライトの配置
まずは，シーンビューに背景を配置しよう．
先ほどプロジェクトウィンドウに追加した「**BackGround**」をシーンビューにドラック&ドロップする．
Unityの2Dゲーム用のプロジェクトでは，シーンビューに配置した画像は**スプライト**と呼ぶよ！
シーンビューとヒエラルキーウィンドウのオブジェクトは1対1で対応しているため，ヒエラルキーウィンドウの一覧にも「**Background**」と表示してることを確認しよう．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

シーンビューの白い枠線を見ながら，ちょうどいい配置になるように配置を調節しよう．

下の写真のようになったら次に進もう！

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

タイトルも同じように配置しよう！

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

#### UIの配置
ゲーム画面に移行するためのボタンのUIを作成します．ヒエラルキーウィンドウの**Create→UI→Button**を選択します．
すると，ヒエラルキーウィンドウに**Canvas**という名前のオブジェクトが追加され，そのCanvasの下に**Button**が作成されるよ．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

次にボタンの設定をしていこう！今回は，ボタンの画像を使っていくよ．

（詳しくは，画像を使ってから）または，そのままで，アレンジでやってもいいかも

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)
    
### 3-2. シーンを切り替えよう

#### シーンマネージャーの設置
シーン遷移を管理するゲームオブジェクトを作成するよ．
ヒエラルキーウィンドウの**Create→Create Empty **を選択します．
名前を「**SceneManager**」に変更しよう．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)
    
次に，シーン遷移を管理するスクリプトを作成します．
プロジェクトウィンドウ上で右クリックして**Create→C# Script**を選択し，ファイル名を「SceneController」に変更しよう．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

「**SceneController**」をダブルクリックして開き，下のプログラムを入力しよう．

```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // シーンをロードする(LoadScene)を使うために必要

public class SceneContrller : MonoBehaviour
{
	public void StartGame()
    {
    	SceneManager.LoadScene("GameScene");
    }
    
}
```

#### シーン管理スクリプトをアタッチする

先ほど作成した「SceneController」スクリプトをヒエラルキーウィンドウの「SceneManager」オブシェクトにドラッグ＆ドロップでアタッチする．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

ボタンを押したら，ゲーム画面に移動するように，押された時に，実行される処理を追加しよう！
まず，ヒエラルキーウィンドウの「StartButton」を選択し，InspecterウィンドウのButtonの**On Click()**の**+ボタン**をクリックする．追加された空欄に，以下のようにSceneManagerをドラッグ＆ドロップする．
次に，**On Click()**の**No Function**をクリックして，以下のように選択しよう．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

## 4. ゲーム画面を作ろう

### 4-1. シーンを作成
ゲームシーンを作成します．
今あるシーンをツールバーの**File→Save**で保存した後に，**File→New Scene**を選択すると，新しいシーンが作成されます．
新しいシーンが作成されたら，**File→Save As**を選択し，「**GameScene**」という名前で保存しておきましょう．
プロジェクトウィンドウ「**GameScene**」が作成されています．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)


### 4-2. シーンにオブジェクトを配置しよう
[スプライトの配置](#スプライトの配置)を参考にして，以下のようにしよう！

背景が前に出てくるときは，BackgroundのInspectorの「**Order in Layer**」を-1にしよう．
Order in layer … 描画する順番（後になるほど画像の前に表示される)

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

### 4-3. 無重力にしよう
今回のゲームは宇宙空間のため，重力をなくす設定をするよ！
ツールバーの**Edit→Project Settings**をクリック．
すると，Project Settingsウィンドウが開くよ．
次に，**Physics 2D→Gravity**の**Y**
を**-9.8→0**に変更しよう．
これにより，重力(Gravity)はなくなったよ！

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

## 5. プレイヤーを操作しよう
### 5-1. プレイヤーの設定

### 5-2. タッチで操作できるようにしよう

#### スクリプトの作成
プロジェクトウィンドウ内で右クリックして**Create→C# Script**を選択し，ファイル名を「PlayerMove」に変換する．
プロジェクトウィンドウの「**PlayerController**」をダブルクリックして開き，以下のスクリプトを入力・保存する．

```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // シーンをロードする(LoadScene)を使うために必要

public class PlayerMove : MonoBehaviour
{
	private Vector2 pos; // プレイヤーの現在の位置
    private Vector2 mousePos; // マウスの位置
    private float posX; // プレイヤーの次の状態のX座標
    [SerializeField]
    private float moveSpeed; // プレイヤーの移動速度[0 ~ 1]
    [SerializeField]
    private GameDirector gameDirector;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = this.transform.position; // フレームごとに位置を取得

        if (Input.GetMouseButton(0)) { // もし画面をタッチしたら
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // マウスの位置を取得
        }
        posX = Mathf.Lerp(pos.x, mousePos.x, moveSpeed); // 現在のX座標とマウスのX座標にだんだん変化させる
        this.transform.position = new Vector2(posX, pos.y); // プレイヤーの位置を更新

    }
    
}
```

#### スクリプトをプレイヤーにアタッチ
先ほど作成した「PlayerMove」スクリプトをヒエラルキーウィンドウの「Player」オブジェクトにドラック＆ドロップでアタッチする．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

ゲームをスタートしてタッチした場所に移動するかな？

### 5-3. プレイヤーから弾を発射しよう

#### 弾プレファブの作成
弾をシーンウィンドウに出し，コライダーをちょうど良い設定に変更する．
ヒエラルキーウィンドウ「Bullet」をプロジェクトウィンドウにドラッグ＆ドロップすると，弾のプレファブ（設計図）が作れます．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

プレファブを作ったら，シーンに配置した弾のオブジェクトは必要ないため，削除します．ヒエラルキーウィンドウの**Bullet**を選択し，右クリック→Deleteで削除が行われます．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

#### ジェネレータを配置
次に，弾のプレファブを製造する弾ジェネレータを作成するよ．
ヒエラルキーウィンドウの**Create→Create Empty**を選択します．名前を「BulletGenerator」に変更しよう．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

プレイヤーに付いてきて欲しいので，「BulletGenerator」を「Player」の子オブジェクトにします．ヒエラルキーウィンドウのBulletGeneratorをPlayerにドラッグ＆ドロップすると，子オブジェクトにできるよ．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

#### ジェネレータのスクリプトを作成

「BulletGenerator」を作成し，下のプログラムを入力しよう．

```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    private float time;
    [SerializeField]
    private GameObject bulletPrefab;
    private GameObject bullet;

    // Start is called before the first frame update
    void Start() {
        time = 0;
    }

    // Update is called once per frame
    void Update() {
        time += Time.deltaTime;

        if (time > 0.4f) {
            bullet = Instantiate(bulletPrefab);
            bullet.transform.position = this.transform.position;
            bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 10f, ForceMode2D.Impulse);
            Destroy(bullet, 2.0f);
            time = 0;
        }


    }
}
```

弾ジェネレータにスクリプトをアタッチしよう．

#### ジェネレータにPrefabを渡す
このままだと，ジェネレータは設計図（Prefab）を知らないので，実行しても弾はでないよ．ヒエラルキーウィンドウの「BulletGenerator」を選択し，以下のように弾のプレファブを設定する．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

実行すると，弾が出たかな？
	
## 6. 石を落とす設定をしよう

### 6-1. 石を落とそう

#### 石プレファブの作成
[弾の設定を参考](#弾プレファブの作成)にしてプレファブを作ろう！

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

#### ジェネレータを配置
次に，石のプレファブを製造する石ジェネレータを作成するよ．
ヒエラルキーウィンドウの**Create→Create Empty**を選択します．名前を「StoneGenerator」に変更しよう．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

位置を以下のように設定する．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

次に，石を出す範囲をコライダーを用いて指定するよ．
Box ColliderをAdd Componentして，以下のように設定しよう．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

#### ジェネレータのスクリプトを作成

「StoneGenerator」を作成し，下のプログラムを入力しよう．

```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneGenerator : MonoBehaviour
{
    private float time;
    [SerializeField]
    private GameObject stonePrefab;
    private GameObject stone;
    private Vector2 stonePos;
    private Vector2 pos;
    private Vector3 size;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        pos = this.transform.position;
        size = this.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time > 2.0f) {
            stonePos.x = pos.x + Random.Range(-size.x / 2.0f, size.x / 2.0f);
            stonePos.y = pos.y + Random.Range(-size.y / 2.0f, size.y / 2.0f);
            stone = Instantiate(stonePrefab);
            Destroy(stone, 2.0f);
            stone.transform.position = stonePos;
            stone.GetComponent<Rigidbody2D>().AddForce(Vector2.down * 10f, ForceMode2D.Impulse);

            time = 0;
        }
        
       
    }
}
```

石ジェネレーターにスクリプトをアタッチする．
石ジェネレーターに石プレファブを教えてあげる．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

動かしてみて，隕石が上から落ちてくるかな？
	
### 6-2. 当たり判定をしよう
このままでは，石と弾が当たっていても消えない．衝突したら自分自身を消えるようにそれぞれにスクリプトをアタッチする．

#### 当たり判定のスクリプトを作成
「CollideController」を作成し，下のプログラムを入力しよう．

```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideController : MonoBehaviour
{
    [SerializeField]
    private string hitTag;

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == hitTag) {
            Destroy(this.gameObject);
        }
    }
}

```
両方にアタッチし，hitTagをそれぞれぶつかった相手の名前をいれる．
例えば，弾の場合，石のタグ名「Stone」をhitTagに入力する．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

動かしてみて，ぶつかると消えるかな？

## 7. UIを作ろう

### 7-1. ゲームオーバー画面を作ろう
ここでは，ゲームオーバー画面をUIとして作成し，石がプレイヤーにぶつかると表示するように設定するよ．

#### ゲームオーバーの配置
まずは，タイトルを配置する．エラルキーウィンドウの**Create→UI→Image**を選択します．
Canvasの中にImageが作成されているので，名前を「GameOver」に変更する．
次に，Inspector→Image→Sorce Imageのoをクリックし，GameOverの画像を選択する．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

画像が表示されたかな？
次に画像の設定をしていくよ．
このままだと，画像サイズがおかしいので，Inspector→Image→Image TypeをTiledに変更する．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

次に，Inspector→Rect Transformを以下のように変更しよう．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

#### リトライボタンの配置
[スタート画面のボタンを参考](#uiの配置)に配置しよう

以下のように配置できたかな？

#### 非表示にしよう
このままスタートすると，常に表示してしまうので，隠す必要がある．
ヒエラルキーのCanvasをクリックし，インスペクターの左上にある．チェックボックスを外すと見えなくなるよ．

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)
	
### 7-2. UIを操作する監督を作ろう
役割を分けてプログラムを書くと，どこにエラーがあるのかや，同じような処理を２度書かなくてすむよ．そのために，今回はUIを操作する監督プログラムを作成するよ．

#### 監督を配置
ヒエラルキーウィンドウの**Create→Create Empty**を選択します．名前を「GameDirector」に変更しよう．

#### 監督のスクリプトを作る
次に，「GameDirector」を作成し，下のプログラムを入力しよう．

 ```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    [SerializeField]
    private GameObject ui;

    public void GameOver() {
        ui.SetActive(true);
    }
}

 ```
 保存したら，先ほどのスクリプトをGameDirectorに入れる．

#### 監督にゲームオーバーを伝えよう
次に，Playerは監督にゲームオーバーしたことをお知られするプログラムを追加するよ．「PlayerMove」を開いて以下のようにプログラムを追加しよう．

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 pos; // プレイヤーの現在の位置
    private Vector2 mousePos; // マウスの位置
    private float posX; // プレイヤーの次の状態のX座標
    [SerializeField]
    private float moveSpeed; // プレイヤーの移動速度[0 ~ 1]
    [SerializeField]
    private GameDirector gameDirector;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = this.transform.position; // フレームごとに位置を取得

        if (Input.GetMouseButton(0)) { // もし画面をタッチしたら
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // マウスの位置を取得
        }
        posX = Mathf.Lerp(pos.x, mousePos.x, moveSpeed); // 現在のX座標とマウスのX座標にだんだん変化させる
        this.transform.position = new Vector2(posX, pos.y); // プレイヤーの位置を更新

    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Stone") {
             gameDirector.GameOver();
        }
       
    }
}

```
次に，PlayerにGameDirectorを教えてあげよう！

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)

動かして見よう！石にぶつかると，ゲームオーバー画面が出てきたかな？

![Qiita logo](https://cdn.qiita.com/assets/siteid-reverse-6044901aace6435306ebd1fac6b7858c.png)


## 8. アレンジしよう
1. 石が消える時に爆発のエフェクトを出そう
2. 石が簡単に壊れないようにしよう
3. 弾を複数方向に出そう
4. 得点をつけよう
5. 見過ごした石が一定個数になるとゲームオーバーにしよう
6. ゲームクリアについて考えてみよう





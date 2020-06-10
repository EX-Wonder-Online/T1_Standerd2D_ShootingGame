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

### 4-2. シーンにオブジェクトを配置しよう
1.  プレイヤーの設置
1.  背景の設置
    
### 4-3. 無重力にしよう
1.  プロジェクト設定の変更
    
## 5. プレイヤーを操作しよう
1. プレイヤーを操作しよう
	1. プレイヤーのスクリプトを作る
	1.  プレイヤのスクリプトをアタッチする

1. プレイヤーから弾を発射しよう
	1. 弾プレファブの作成
	1. ジェネレータを配置
	1. ジェネレータのスクリプトを作成
	1. ジェネレータにスクリプトをアタッチ
	1. ジェネレータにPrefabを渡す
	
## 6. 石を落とす設定をしよう
1. 石を落とそう
	1. 石プレファブの作成
	1. ジェネレータを配置
	1. ジェネレータのスクリプトを作成
	1. ジェネレータにスクリプトをアタッチ
	1. ジェネレータにPrefabを渡す
	
1. 当たり判定をしよう
	1. 当たり判定のスクリプトを作る
	1. 弾と石にスクリプトをアタッチ
	1. スクリプトにタグの名前を渡す

## 7. UIを作ろう
1. ゲームオーバー画面を作ろう
	1. ゲームオーバーの配置
	1. リトライボタンの配置
	1. 非アクティブにする
	
1. UIを操作する監督のを作ろう
	1. 監督を配置
	1. 監督のスクリプトを作る
	1. 監督にスクリプトをアタッチ
	1. 監督にゲームオーバーを伝えよう

## 8. アレンジしよう
1. 石が消える時に爆発のエフェクトを出そう
2. 石が簡単に壊れないようにしよう
3. 弾を複数方向に出そう
4. 得点をつけよう
5. 見過ごした石が一定個数になるとゲームオーバーにしよう
6. ゲームクリアについて考えてみよう





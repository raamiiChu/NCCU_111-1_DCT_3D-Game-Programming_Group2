# 111-1 NCCU DCT 3D Game Programming G2

# 開啟方式
1. 下載檔案後用 Unity Hub 開啟  
2. 點擊 Scenes 底下的 SampleScene  
![image](https://user-images.githubusercontent.com/87169493/206860837-9eecb2d3-d970-49bb-bb0f-e21f89b26a6e.png)


# 各腳本功能
## GameManager
### 概要
- 玩家基礎操作  
  WASD
- 玩家墜落保險機制  
  墜落到一定高度，玩家會傳送回出生點
- 按鈕事件    
  點擊按鈕關閉 UI 視窗
### 位置  
- GM
### 參數
- player  
  玩家
- move speed  
  移動速度


## Input_Password
### 概要
- 輸入密碼  
  按下 Q 叫出輸入密碼介面(密碼：1234)    
  正確、錯誤的介面會在顯示兩秒後關閉
### 位置  
- Canvas > Input_Password  
### 參數  
皆為 UI 介面  
- input UI  
- wrong  
- correct  


## Light_Trigger
### 概要
- 物件發光  
  玩家靠近後會發光提示
- 調查介面    
  顯示調查介面：空白鍵   
  退出調查介面：空白鍵　OR 按鈕    
### 位置  
- Items > Item
### 參數
- trigger dist  
  觸發發光的距離
- player  
  玩家
- investigation UI  
  調查 UI 介面


## Mouse_Drag
### 概要
- 按住滑鼠拖曳物件  
  玩家靠近後能拖曳物件
  只能移動 x 軸
### 位置  
- Books > Book  
### 參數
- trigger dist  
  觸發發光的距離
- player  
  玩家


## Move_On_Click  
### 概要  
- 點擊物件使其移動    
  使用 DOTween，會有動畫感
### 位置  
- Bookshelf > Books > Book_move  
### 參數
- little book move  
  該物件的小型模型，會跟著大物件一起移動
- correct spot **(請勿手動調整)**  
  跟 Show_Bookshelf_Item 連動
  

## Shake_On_Click
### 概要  
- 點擊後物件會震動
### 位置  
- Bookshelf > Books > Book_shake  
### 參數
- shake amount  
  震動幅度
- correct spot  
  原本預計要跟 Show_Bookshelf_Item 連動，暫時沒有用處


## Show_Bookshelf_Item
### 概要
- 達成條件後顯示物件
  與 Move_On_Click 的物件連動
### 位置  
- Bookshelf  
### 參數
- books   
  存放多個物件，與 correct spot 連動，用來檢查是否達成條件
- item  
  要顯示的物件
- little item  
  該物件的小型模型，會跟著大物件一起顯示


## Switch_Camera_Bookshelf
### 概要  
- 玩家靠近物件後才會觸發  
- 切換攝影機：空白鍵
- 退出攝影機：空白鍵 OR 按鈕  
### 位置  
- Bookshelf > camera_bookshelf  
### 參數
- player  
  玩家
- player camera   
  玩家攝影機
- bookshelf camera  
  物件攝影機
- btn  
  退出按鈕
- trigger dist  
  觸發發光的距離


## Teleport_On_Click  
### 概要  
- 點擊物件使其移動
  直接更新物件座標，看起來像瞬間移動
### 位置  
  - Bookshelf > Books > Book_teleport  
### 參數
- little book teleport  
  該物件的小型模型，會跟著大物件一起移動
- correct spot  
  原本預計要跟 Show_Bookshelf_Item 連動，暫時沒有用處

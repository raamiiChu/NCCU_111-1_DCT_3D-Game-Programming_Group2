# 111-1 NCCU DCT 3D Game Programming G2
111-1 國立政治大學 數位內容學程 3D遊戲程式設計 期末專案 第二組  

# SampleScripts 檔案內容說明

# GameManager
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


# Hint_Manager  
### 概要  
- 顯示提示 UI (按下 space 調查)  
### 位置  
- Hint_Manager  
### 參數 
以下變數可視需求新增 **(請確保程式碼中有 hint_show 變數)**
- items  
- bookshelfs  


# Input_Password
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


# Light_Trigger
### 概要
- 物件發光  
  玩家靠近後且位於螢幕指定範圍內會發光提示
- 調查介面    
  顯示調查介面：空白鍵   
  退出調查介面：空白鍵　OR 按鈕    
### 位置  
- Items > Item
### 參數
- trigger dist  
  觸發發光的距離
- view_x_range / view_y_range  
  視野範圍  
  可以搭配 74 行的 
  ```
  Debug.Log(view_pos);
  ```  
- player  
  玩家
- hint space
  提示UI
- investigation UI  
  調查 UI 介面
- show hint
  是否顯示提示 UI
  跟 Hint_Manager 連動
- cam
  玩家攝影機


# Mouse_Drag
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


# Move_On_Click  
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
  

# Pick_Item  
### 概要  
- 點擊物件將其加入物品欄    
### 位置  
- Pick_Item  
### 參數
- item_box  
  物品欄 UI  


# Shake_On_Click
### 概要  
- 點擊後物件會震動
### 位置  
- Bookshelf > Books > Book_shake  
### 參數
- shake amount  
  震動幅度
- correct spot  
  原本預計要跟 Show_Bookshelf_Item 連動，暫時沒有用處


# Show_Bookshelf_Item
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


# Switch_Camera_Bookshelf
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
- show hint
  是否顯示提示 UI
  跟 Hint_Manager 連動


# Teleport_On_Click  
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

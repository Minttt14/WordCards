# 單字卡程式

## 主要功能

本程式為一款結合語音播放的英語單字輔助學習工具，啟動時會自動讀取同目錄下的 WordCards.txt 單字文字檔，並於左側建立單字清單，可以手動點擊發音或自動輪流播放模式，也能使用鍵盤快捷鍵操作（Enter 與 Space），並提供雙擊時可即時修改並存檔的「編輯單字」功能。

## 使用方法

#### 1. 啟動與自動載入
開啟程式後，系統會自動尋找並載入預設的單字檔，載入後，左側清單會顯示所有單字，左下角狀態列會提示目前載入的單字數量，畫面中央會顯示單字、音標與解釋

<img width="350" height="250" alt="image" src="https://github.com/user-attachments/assets/00d00f48-7a4c-4284-aa7f-aa211056ae3d" />
<br>

#### 2. 手動播放與快捷鍵操作
在手動模式下，可以直接用滑鼠點選左側清單來切換單字，系統便會同步更新畫面並自動播放該單字的音效，也可以直接使用鍵盤進行操作

- Enter 鍵： 自動跳至清單中的「下一個」單字並播放發音

- Space鍵： 重新播放「目前」所選單字的發音

<img width="350" height="180" alt="image" src="https://github.com/user-attachments/assets/8c405ea7-597a-48aa-ad9c-877b3e38f73e" />


#### 3. 自動輪播模式 (Play / Stop)
點擊畫面右側的「Play」按鈕，系統會啟動內部計時器，按順序自動往下切換單字並播放發音

- 進入自動播放狀態時，按鈕文字會變更為「Stop」，為避免操作衝突，此時鍵盤的快捷鍵功能將暫時停用

- 再次點擊「Stop」按鈕，即可停止自動播放，並恢復手動控制與鍵盤操作
  
<img width="350" height="180" alt="image" src="https://github.com/user-attachments/assets/0b4ec026-36de-4938-891d-49506681676e" />
<br>
<img width="350" height="250" alt="image" src="https://github.com/user-attachments/assets/5ad3d156-84fc-4dca-97eb-e5520a0585a1" />
<br>

#### 4. 即時編輯單字資料
在左側的單字清單上對著該單字「點擊兩下」可進入編輯模式，系統會彈出獨立的「編輯單字」視窗，可以在此欄位中修改音標、音檔的對應路徑，以及解釋內容，修改完畢後按下右下角的「儲存」按鈕，系統不但會立即更新主畫面，還會同步將新資料寫回本地的文字檔案中，確保修改被永久保存

<img width="350" height="500" alt="image" src="https://github.com/user-attachments/assets/de3759e5-fbc4-4622-aecc-e5430d62aad1" />

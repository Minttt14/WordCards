using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WordCards
{
    public partial class frmWordCards : Form
    {
        /// <summary>
        /// 單字清單
        /// </summary>
        WordCollection _WordList = new WordCollection();
        /// <summary>
        /// Windows Media Player 播放器
        /// </summary>
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        string strWordFile = "WordCards.txt"; // 單字檔名
        /// <summary>
        /// 是否自動播放
        /// </summary>
        bool isPlay = false;
        public frmWordCards()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 顯示單字
        /// </summary>
        /// <param name="word">單字物件</param>
        private void ShowWord(WordItem word)
        {
            txtWord.Text = word.Word;
            txtPhonogram.Text = word.Phonogram;
            txtExplain.Text = word.Explain;
        }

        /// <summary>
        /// 將單字加入到播放清單
        /// </summary>
        private void UpdateWordList()
        {
            lstWordList.BeginUpdate(); // 開始更新
            lstWordList.Items.Clear();
            foreach (WordItem item in this._WordList)
            {
                lstWordList.Items.Add(item);
            }
            lstWordList.EndUpdate(); // 結束更新
        }
        /// <summary>
        /// 播放單字音檔
        /// </summary>
        /// <param name="word">單字物件</param>
        private void PlayWord(WordItem word)
        {
            // 判斷音效檔是否存在
            if (File.Exists(word.SoundPath))
            {
                // 播放單字音檔
                wmp.URL = word.SoundPath;
                wmp.settings.autoStart = false;
                wmp.settings.mute = false;
                wmp.controls.play();
            }
            else
                tsslMessage.Text = $"找無 {word.SoundPath} 音效檔";
        }
        /// <summary>
        /// 播放目前選取的單字
        /// </summary>
        private void PlaySelectedWord()
        {
            // 判斷目前選的項目是否為空
            if (lstWordList.SelectedItem != null)
            {
                // 取得目前選取的單字索引
                int idx = lstWordList.SelectedIndex;
                // 顯示單字
                ShowWord(_WordList[idx]);
                // 播放單字的發音
                PlayWord(_WordList[idx]);
            }
        }
        private void frmWordCards_Load(object sender, EventArgs e)
        {
            string[] lines;
            // 若單字檔存在
            if (File.Exists(strWordFile))
            {
                lines = File.ReadAllLines(strWordFile, Encoding.UTF8);
            }
            else
            {
                MessageBox.Show($"找不到單字檔\n{strWordFile}", "錯誤", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            // 載入單字檔
            this._WordList.LoadFromStringArray(lines);
            if (this._WordList.Count > 0)
            {
                // 更新單字清單
                UpdateWordList();
                // 顯示第一個單字
                this.ShowWord(_WordList[0]);
                tsslMessage.Text = $"單字數量：{_WordList.Count}";
            }

        }

        private void lstWordList_Click(object sender, EventArgs e)
        {
            // 判斷是否自動播放
            if (isPlay == true)
                btnAutoPlay.PerformClick(); // 點擊自動播放按鈕
                                            // 判斷是否有選取項目
            if (lstWordList.SelectedItem != null)
                // 判斷是否有選取項目
                if (lstWordList.SelectedItem.ToString().Length != 0)
                {
                    // 顯示並播放目前選取的單字
                    PlaySelectedWord();
                }
        }
    }
}

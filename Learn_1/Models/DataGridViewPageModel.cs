using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Learn_1.Models
{
    /// <summary>
    /// 这是播放页面的基类
    /// </summary>
    public class DataGridViewPageModel : ViewModelBase
    {
        #region 选中的音乐
        private Item selectedMusic;
        public DataGridViewPageModel()
        {
            //这里添加几个 测试的云盘歌曲
            for(int i=0;i<10;i++)
            {
                MusicList.Add(new Item
                {
                    Code = "1",
                    Name = "你好",
                    Description = "张雨生档青年为表达爱情"
                });
            }
            ShowMusicList();
        }
        /// <summary>
        /// 选中的音乐
        /// </summary>
        public Item SelectedMusic
        {
            get { return selectedMusic; }
            set
            {
                selectedMusic = value;
                OnPropertyChanged("SelectedMusic");
            }
        }
        #endregion

       

        #region 音乐列表
        private ObservableCollection<Item> musicList;
        /// <summary>
        /// 音乐列表
        /// </summary>
        public ObservableCollection<Item> MusicList
        {
            get
            {
                if (musicList == null)
                {
                    musicList = new ObservableCollection<Item>();
                }
                return musicList;
            }
            set
            {
                musicList = value;
                OnPropertyChanged("MusicList");
            }
        }
        #endregion

        #region 是否显示歌曲列表
        private bool displayMusicList;
        /// <summary>
        /// 是否显示歌曲列表
        /// </summary>
        public bool DisplayMusicList
        {
            get { return displayMusicList; }
            set
            {
                displayMusicList = value;
                OnPropertyChanged("DisplayMusicList");
            }
        }

        public void ShowMusicList(bool show = true)
        {
            if (MusicList.Count > 0)
            {
                DisplayMusicList = show;
            }
            else
            {
                //歌曲列表为空的时候 隐藏 歌曲列表视图
                DisplayMusicList = false;
            }
        }
        #endregion
    }

    public class Item
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

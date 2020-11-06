﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using System.Windows.Navigation;

namespace SendMailApp
{
    class Config
    {
        //単一のインスタンス
        private static Config Instance;

        //インスタンスの取得
        public static Config GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Config();
            }
            return Instance;
        }

        public string Smtp { get; set; }            //SMTPサーバー
        public string MailAddress { get; set; }     //自分のメールアドレス(送信元)
        public string PassWord { get; set; }        //パスワード
        public int Port { get; set; }               //ポート番号
        public bool Ssl { get; set; }               //SSL設定

        //コンストラクタ(外部からnewできないようにする)
        private Config(){}

        //初期値設定用
        public void DefaultSet()
        {
            Smtp = "smtp.gmail.com";
            MailAddress = "ojsinfosys01@gmail.com";
            PassWord = "ojsInfosys2020";
            Port = 587;
            Ssl = true;
        }

        //初期値取得用
        public Config getDefaultStatus()
        {
            Config obj = new Config
            {
                Smtp = "smtp.gmail.com",
                MailAddress = "ojsinfosys01@gmail.com",
                PassWord = "ojsInfosys2020",
                Port = 587,
                Ssl = true,
            };
            return obj;
        }

        //設定データ更新
        //public bool UpdateStatus(Config cf)
        public bool UpdateStatus(string smtp,string mailAddress, string passWord, int port, bool ssl)
        {
            this.Smtp = smtp;
            this.MailAddress = mailAddress;
            this.PassWord = passWord;
            this.Port = port;
            this.Ssl = ssl;

            return true;
        }
    }
}

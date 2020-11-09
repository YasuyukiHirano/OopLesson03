﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Xml;
using System.Xml.Serialization;

namespace SendMailApp
{
    public class Config
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

        public void Serialise()     //シリアル化(P305参照)
        {
            var obj = new Config()
            {
                Smtp = this.Smtp,
                MailAddress = this.MailAddress,
                PassWord = this.PassWord,
                Port = this.Port,
                Ssl = this.Ssl
            };

            using (var write = XmlWriter.Create("config.xml"))
            {
                var serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(write, obj);
            }
        }

        public void DeSirialise()   //逆シリアル化(P307参照)
        {
            using (var reader = XmlReader.Create("config.xml"))
            {
                var serializer = new XmlSerializer(typeof(Config));
                var obj = serializer.Deserialize(reader) as Config;
                Console.WriteLine(obj);

                this.Smtp = obj.Smtp;
                this.MailAddress = obj.MailAddress;
                this.PassWord = obj.PassWord;
                this.Port = obj.Port;
                this.Ssl = obj.Ssl;
            }
        }
    }
}

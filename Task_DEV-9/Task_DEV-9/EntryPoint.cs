﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Task_DEV_9
{
    class EntryPoint
    {
        static void Main()
        {
            try
            {
                var driver = new ChromeDriver();
                var yandex = new Yandex.YandexLogin(driver);
                var yandexEmail = "dima.kupeshka@yandex.by";
                var yandexPassword = "taskdev9";
                var ramblerEmail = "dima.kupeshka@rambler.ru";
                var ramblerPassword = "Taskdev9";
                var message = "picabu.habr tushkan";
                var newNickname = "Picachu";

                yandex.GoToLogin();
                //yandex.Login(yandexEmail, yandexPassword).GoToSendLetterPage().SendMessage(ramblerEmail, message);
                var rambler = new Rambler.RamblerLogin(driver);
                rambler.GoToLogin();
                rambler.Login(ramblerEmail, ramblerPassword).ChooseUnreadLetter(yandexEmail).ReplyToLetter(message, newNickname);
                yandex.GoToLogin();
                yandex.Login(yandexEmail, yandexPassword).ReadLastLetter().GoToProfilePage().GoToSetting().ChangeNickname();
                driver.Quit();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

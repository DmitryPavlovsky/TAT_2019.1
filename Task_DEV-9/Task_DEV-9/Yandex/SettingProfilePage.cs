﻿using OpenQA.Selenium;

namespace Task_DEV_9.Yandex
{
    /// <summary>
    /// class for page setting profile
    /// </summary>
    class SettingProfilePage
    {
        IWebDriver Driver { get; set; }
        string NewNickname { get; set; }
        IWebElement PersonalDataButton => this.Driver.FindElement(By.XPath("//*[contains(text(), 'Изменить персональную информацию')]"), 10);

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="newNickname"></param>
        public SettingProfilePage(IWebDriver driver, string newNickname)
        {
            this.Driver = driver;
            this.NewNickname = newNickname;
        }

        /// <summary>
        /// method for go to personal data change page
        /// </summary>
        /// <returns></returns>
        public ChangePersonalDataPage GoToSetting()
        {
            this.PersonalDataButton.Click();

            return new ChangePersonalDataPage(this.Driver, this.NewNickname);
        }
    }
}
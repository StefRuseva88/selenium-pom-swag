﻿using OpenQA.Selenium;

namespace OnlineStorePomTests.Pages
{
    public class HiddenMenuPage : BasePage
    {
        private readonly By menuButton = By.CssSelector(".bm-burger-button");
        private readonly By logoutButton = By.Id("logout_sidebar_link");

        private readonly By menuContainer = By.ClassName("bm-menu-wrap");

        public HiddenMenuPage(IWebDriver driver) : base(driver) { }

        public void ClickMenuButton()
        {
            Click(menuButton);
        }

        public void ClickLogoutButton()
        {
            Click(logoutButton);
        }

        public bool IsMenuOpen()
        {
            return FindElement(logoutButton).Displayed;
        }
    }
}

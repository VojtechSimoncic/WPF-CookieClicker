using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CookieClickerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {       

        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer cookiesPerSecondTimer = new DispatcherTimer();
            cookiesPerSecondTimer.Tick += new EventHandler(cookiesPerSecondTimer_Tick);
            cookiesPerSecondTimer.Interval = new TimeSpan(0, 0, 1);
            cookiesPerSecondTimer.Start();
        }

        int cookiesPerClick = 1,
            gradnmaUpgrades = 0, 
            farmUpgrades = 0, 
            factoryUpgrades = 0, 
            mineUpgrades = 0, 
            shipmentUpgrade = 0, 
            alchemyLabUpgrade = 0, 
            portalUpgrade = 0, 
            timeMachineUpgrade = 0, 
            antimatterCondesnerUpgrade = 0;
       

        long cookies = 0,
            grandmaPrice = 15,
            farmPrice = 100,
            factoryPrice = 1100,
            minePrice = 12000,
            shipmentPrice = 130000,
            alchemylabPrice = 1400000,
            portalPrice = 20000000,
            timeMachinePrice = 330000000,
            antimatterCondenserPrice = 5100000000,
            cookiesPerSecond = 0,
            cookiesPerClickPrice = 100;
        

        private void cookiesPerSecondTimer_Tick(object sender, EventArgs e)
        {
            CookiesPerSecondTimer(cookiesPerSecond);
        }
        
        private void CookiesPerSecondTimer(long cps)
        {
            cookies += cps;

            cookieCounter.Text = "Cookies: " + cookies;
        }
        
        private void AddCookie(object sender, EventArgs e)
        {
            cookies += cookiesPerClick;
            cookieCounter.Text = "Cookies: " + cookies;
        }
        
        private void CloseWindow(object sender, EventArgs e) 
        {
            Close();
        }
        
        private string NotEnoughCookies()
        {
            return "You don´t have enough cookies to buy this upgrade!";
        }

        private void CookiesCounter(long c) 
        {
            cookieCounter.Text = "Cookies: " + c.ToString();
        }

        private void CookiesPerSecond(long cps)
        {
            txtCookiesPerSecond.Text = "Cookies per Second:" + cps.ToString();
        }

        private void Minimize(object sender, EventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Upgrade(object sender, EventArgs e)
        {
            Button upgradeButton = (Button)sender;
            string upgradeOption = upgradeButton.Name;
            switch (upgradeOption)
            {
                case "grandma":
                    {
                        if (cookies >= grandmaPrice)
                        {
                            gradnmaUpgrades += 1;
                            cookies -= grandmaPrice;
                            grandmaPrice = (long)(grandmaPrice * 1.2);
                            cookiesPerSecond += 1;

                            CookiesPerSecondTimer(cookiesPerSecond);
                            CookiesPerSecond(cookiesPerSecond);
                            CookiesCounter(cookies);
                            txtGrandmaPrice.Text = grandmaPrice.ToString();
                        }
                        else MessageBox.Show(NotEnoughCookies());
                        break;
                    }
                case "farm":
                    {
                        if (cookies >= farmPrice)
                        {
                            farmUpgrades += 1;
                            cookies -= farmPrice;
                            farmPrice = (long)(farmPrice * 1.2);
                            cookiesPerSecond += 8;

                            CookiesPerSecondTimer(cookiesPerSecond);
                            CookiesPerSecond(cookiesPerSecond);
                            CookiesCounter(cookies);
                            txtFarmPrice.Text = farmPrice.ToString();
                        }
                        else MessageBox.Show(NotEnoughCookies());
                        break;
                    }
                case "factory":
                    {
                        if (cookies >= factoryPrice)
                        {
                            factoryUpgrades += 1;
                            cookies -= factoryPrice;
                            factoryPrice = (long)(factoryPrice * 1.2);
                            cookiesPerSecond += 47;

                            CookiesPerSecondTimer(cookiesPerSecond);
                            CookiesPerSecond(cookiesPerSecond);
                            CookiesCounter(cookies);
                            txtFactoryPrice.Text = factoryPrice.ToString();
                        }
                        else MessageBox.Show(NotEnoughCookies());
                        break;
                    }
                case "mine":
                    {
                        if (cookies >= minePrice)
                        {
                            mineUpgrades += 1;
                            cookies -= minePrice;
                            minePrice = (long)(minePrice * 1.2);
                            cookiesPerSecond += 260;

                            CookiesPerSecondTimer(cookiesPerSecond);
                            CookiesPerSecond(cookiesPerSecond);
                            CookiesCounter(cookies);
                            txtMinePrice.Text = minePrice.ToString();   
                        }
                        else MessageBox.Show(NotEnoughCookies());
                        break;
                    }
                case "shipment":
                    {
                        if (cookies >= shipmentPrice)
                        {
                            shipmentUpgrade += 1;
                            cookies -= shipmentPrice;
                            shipmentPrice = (long)(shipmentPrice * 1.2);
                            cookiesPerSecond += 1400;

                            CookiesPerSecondTimer(cookiesPerSecond);
                            CookiesPerSecond(cookiesPerSecond);
                            CookiesCounter(cookies);
                            txtShipmentPrice.Text = shipmentPrice.ToString();
                        }
                        else MessageBox.Show(NotEnoughCookies());
                        break;
                    }
                case "alchemyLab":
                    {
                        if (cookies >= alchemylabPrice)
                        {
                            alchemyLabUpgrade += 1;
                            cookies -= alchemylabPrice;
                            alchemylabPrice = (long)(alchemylabPrice * 1.2);
                            cookiesPerSecond += 7800;

                            CookiesPerSecondTimer(cookiesPerSecond);
                            CookiesPerSecond(cookiesPerSecond);
                            CookiesCounter(cookies);
                            txtAlchemyLabPrice.Text = alchemylabPrice.ToString();
                        }
                        else MessageBox.Show(NotEnoughCookies());
                        break;
                    }
                case "portal":
                    {
                        if (cookies >= portalPrice)
                        {
                            portalUpgrade += 1;
                            cookies -= portalPrice;
                            portalPrice = (long)(portalPrice * 1.2);
                            cookiesPerSecond += 44000;

                            CookiesPerSecondTimer(cookiesPerSecond);
                            CookiesPerSecond(cookiesPerSecond);
                            CookiesCounter(cookies);
                            txtPortalPrice.Text = portalPrice.ToString();
                        }
                        else MessageBox.Show(NotEnoughCookies());
                        break;
                    }
                case "timeMachine":
                    {
                        if (cookies >= timeMachinePrice)
                        {
                            timeMachineUpgrade += 1;
                            cookies -= timeMachinePrice;
                            timeMachinePrice = (long)(timeMachinePrice * 1.2);
                            cookiesPerSecond += 260000;

                            CookiesPerSecondTimer(cookiesPerSecond);
                            CookiesPerSecond(cookiesPerSecond);
                            CookiesCounter(cookies);
                            txtTimeMachinePrice.Text = timeMachinePrice.ToString();
                        }
                        else MessageBox.Show(NotEnoughCookies());
                        break;
                    }
                case "antimatterCondenser":
                    {
                        if (cookies >= antimatterCondenserPrice)
                        {
                            antimatterCondesnerUpgrade += 1;
                            cookies -= antimatterCondenserPrice;
                            antimatterCondenserPrice = (long)(antimatterCondenserPrice * 1.2);
                            cookiesPerSecond += 1600000;

                            CookiesPerSecondTimer(cookiesPerSecond);
                            CookiesPerSecond(cookiesPerSecond);
                            CookiesCounter(cookies);
                            txtAntiCondPrice.Text = antimatterCondenserPrice.ToString();
                        }
                        else MessageBox.Show(NotEnoughCookies());
                        break;
                    }
                case "clickUpgrade":
                    {
                        if (cookies >= cookiesPerClickPrice)
                        {
                            cookiesPerClick *= 2;
                            cookies -= cookiesPerClickPrice;
                            cookiesPerClickPrice = (long)(cookiesPerClickPrice * 1.2);

                            txtCookiesPerClick.Text = "Cookies per click: " + cookiesPerClick.ToString();
                            CookiesCounter(cookies);
                            txtClickUpgradePrice.Text = cookiesPerClickPrice.ToString();
                        }
                        else MessageBox.Show(NotEnoughCookies());
                        break;
                    }
            }
        }
    }
}
